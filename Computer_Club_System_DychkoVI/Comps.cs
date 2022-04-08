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
    public partial class Comps : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }
        MySqlConnection conn = ConnDB.ConnMysqlClient();
        private MySqlDataAdapter MySQLData = new MySqlDataAdapter();
        private BindingSource SourceBind = new BindingSource();
        private DataTable datatable = new DataTable();
        private DataSet ds = new DataSet();
        int selected_Row;
        public Comps()
        {
            InitializeComponent();
            #region ContextMenu
            // создаем элементы меню
            ToolStripMenuItem OffMenuItem = new ToolStripMenuItem("Отключить");
            ToolStripMenuItem OnMenuItem = new ToolStripMenuItem("Включить");
            ToolStripMenuItem BusyMenuItem = new ToolStripMenuItem("Занят");
            ToolStripMenuItem SelectMenuItem = new ToolStripMenuItem("Выделенный ID");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { OffMenuItem, OnMenuItem, BusyMenuItem, SelectMenuItem });
            // ассоциируем контекстное меню с текстовым полем
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            OffMenuItem.Click += отключитьToolStripMenuItem_Click;
            OnMenuItem.Click += включитьToolStripMenuItem_Click;
            BusyMenuItem.Click += занятToolStripMenuItem_Click;
            SelectMenuItem.Click += выделенныйIDToolStripMenuItem_Click;
            #endregion
        }
        #region Основные методы
        public void UpdateT()
        {
            try
            {
                conn.Open();

                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from K_Comps where c_ID = {id}";

                        var command = new MySqlCommand(deleteQuery, conn);
                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var nam = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var supp = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var type = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var stat = dataGridView1.Rows[index].Cells[4].Value.ToString();

                        var changeQuery = $"update K_Comps set c_Name = '{nam}', c_Supp = '{supp}', c_Type = '{type}', c_Stat = '{stat}' where c_ID = '{id}'";

                        var command = new MySqlCommand(changeQuery, conn);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception oshibka)
            {
                MessageBox.Show($"{oshibka}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("c_ID", "Номер");
            dataGridView1.Columns.Add("c_Name", "Фамилия");
            dataGridView1.Columns.Add("c_Supp", "Поставщик");
            dataGridView1.Columns.Add("c_Type", "Тип");
            dataGridView1.Columns.Add("c_Stat", "Состояние");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from C_Comps";

            MySqlCommand command = new MySqlCommand(querystring, conn);

            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadsSingleRow(dgw, reader);
            }
            reader.Close();
        }
        public void DeleteUser()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;
            try
            {
                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
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
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            int id;
            var nam = textBox2.Text;
            var supp = textBox3.Text;
            var type = textBox4.Text;
            var stat = textBox5.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox1.Text, out id))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, nam, supp, type, stat);
                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Возраст должен иметь числовой формат");
                }
            }
        }
        public void ChangeState(string new_state)
        {
            int redact_id = selected_Row;
            conn.Open();
            string query2 = $"UPDATE K_Comps SET c_Stat='{new_state}' WHERE (c_ID='{redact_id}')";
            MySqlCommand command = new MySqlCommand(query2, conn);
            command.ExecuteNonQuery();
            conn.Close();
            UpdateT();
            ChangeColorDGV();
        }
        #endregion

        #region ContMenu
        private void выделенныйIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{selected_Row}");
        }
        private void отключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeState("Off");
        }
        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeState("On");
        }
        private void занятToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeState("Busy");
        }
        private void Reloading_Click(object sender, EventArgs e)
        {

        }
        private void Sbros_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
            toolStripTextBox2.Clear();
            toolStripTextBox3.Clear();
            toolStripTextBox4.Clear();
            toolStripTextBox5.Clear();
        }
        #endregion

        private void ChangeColorDGV()
        {
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount - 1;
            //Проходимся по ДатаГриду и красим строки в нужные нам цвета, в зависимости от статуса студента
            for (int i = 0; i < count_rows; i++)
            {

                //статус конкретного студента в Базе данных, на основании индекса строки
                string id_selected_status = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                //Логический блок для определения цветности
                if (id_selected_status == "Off")
                {
                    //Красим в красный
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
                if (id_selected_status == "On")
                {
                    //Красим в зелёный
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Green;
                }
                if (id_selected_status == "Busy")
                {
                    //Красим в желтый
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                }
            }
        }
        private void Comps_Load(object sender, EventArgs e)
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
            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
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
            ChangeColorDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CompAdd CAD = new CompAdd();
            CAD.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateT();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
            }
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Конструкция "LIKE" является способом "поиска" в полях. Это обычный синтаксис SQL
            SourceBind.Filter = "Номер LIKE'" + toolStripTextBox1.Text + "%'";
        }
        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            SourceBind.Filter = "Название LIKE'" + toolStripTextBox2.Text + "%'";
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            SourceBind.Filter = "Поставщик LIKE'" + toolStripTextBox3.Text + "%'";
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            SourceBind.Filter = "Тип LIKE'" + toolStripTextBox4.Text + "%'";
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            SourceBind.Filter = "Состояние LIKE'" + toolStripTextBox5.Text + "%'";
        }
    }
}
