using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dyczko_ComputerClub_System
{
    public partial class Clients : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        readonly MySqlConnection conn = ConnDB.ConnMysqlClient();
        private readonly MySqlDataAdapter MySQLData = new MySqlDataAdapter();
        private readonly BindingSource SourceBind = new BindingSource();
        private readonly DataTable datatable = new DataTable();
        int selected_Row;
        public Clients()
        {
            InitializeComponent();
            #region Элементы контекстного меню
            // создаем элементы меню
            ToolStripMenuItem DelMenuItem = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem SelectMenuItem = new ToolStripMenuItem("Выделенный ID");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { DelMenuItem, SelectMenuItem });
            // ассоциируем контекстное меню с текстовым полем
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            DelMenuItem.Click += удалитьToolStripMenuItem_Click;
            SelectMenuItem.Click += выделенныйIDToolStripMenuItem_Click;
            #endregion
        }
        #region Основные методы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("s_ID", "Код");
            dataGridView1.Columns.Add("s_FIO", "ФИО");
            dataGridView1.Columns.Add("s_Age", "Возраст");
            dataGridView1.Columns.Add("s_Sex", "Пол");
            dataGridView1.Columns.Add("s_Number", "Телефонный номер");
            dataGridView1.Columns.Add("s_Email", "Электронная почта");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from K_Clients";

            MySqlCommand command = new MySqlCommand(querystring, conn);

            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadsSingleRow(dgw, reader);
            }
            reader.Close();
        }
        public void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;
            try
            {
                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                //Вызов метода обновления ДатаГрида
                RefreshDataGrid(dataGridView1);
            }
        }

        private void UpdateT()
        {
            conn.Open();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from K_Clients where s_ID = {id}";

                    var command = new MySqlCommand(deleteQuery, conn);
                    command.ExecuteNonQuery();
                }
                
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var age = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var gen = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var num = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var mail = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update K_Clients set s_FIO = '{fio}', s_Age = '{age}', c_Sex = '{gen}', s_Number = '{num}', s_Email = '{mail}' where s_ID = '{id}'";

                    var command = new MySqlCommand(changeQuery, conn);
                    command.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox1.Text;
            var fio = textBox2.Text;
            var gen = textBox4.Text;
            var num = textBox5.Text;
            var mail = textBox6.Text;
            int age;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBox4.Text, out age))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, gen, age, num, mail);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Возраст должен иметь числовой формат");
                }
            }
        }
        #endregion
        #region Items
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void выделенныйIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{selected_Row}");
        }
        #endregion

        private void Clients_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            #region Стиль
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Убираем заголовки строк
            dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Стиль
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Black", 9, FontStyle.Bold); //шрифт
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 85, 255); // цвет ряда-заголовка
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // цвет символов заголовков
            dataGridView1.GridColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            #endregion
        }
        #region ToolStrip
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Код LIKE'" + toolStripTextBox1.Text + "%'";
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Фамилия Имя LIKE'" + toolStripTextBox2.Text + "%'";
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Пол LIKE'" + toolStripTextBox3.Text + "%'";
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Возраст LIKE'" + toolStripTextBox4.Text + "%'";
        }

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Номер LIKE'" + toolStripTextBox5.Text + "%'";
        }

        private void toolStripTextBox6_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Email LIKE'" + toolStripTextBox6.Text + "%'";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
            toolStripTextBox2.Clear();
            toolStripTextBox3.Clear();
            toolStripTextBox4.Clear();
            toolStripTextBox5.Clear();
            toolStripTextBox6.Clear();
        }
        #endregion
        #region Управление записями
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateT();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClientAdd CLAD = new ClientAdd();
            CLAD.ShowDialog();
        }
    }
}
