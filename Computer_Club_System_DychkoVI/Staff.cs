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
    public partial class Staff : Form
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

        int selected_Row;
        public Staff()
        {
            InitializeComponent();
            #region Элементы контекстного меню
            // создаем элементы меню
            ToolStripMenuItem DelMenuItem = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem HireMenuItem = new ToolStripMenuItem("Нанять");
            ToolStripMenuItem FireMenuItem = new ToolStripMenuItem("Уволить");
            ToolStripMenuItem SelectMenuItem = new ToolStripMenuItem("Выделенный ID");
            // добавляем элементы в меню
            contextMenuStrip1.Items.AddRange(new[] { DelMenuItem, HireMenuItem, FireMenuItem, SelectMenuItem });
            // ассоциируем контекстное меню с текстовым полем
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            // устанавливаем обработчики событий для меню
            DelMenuItem.Click += удалитьToolStripMenuItem_Click;
            HireMenuItem.Click += зачислитьToolStripMenuItem_Click;
            FireMenuItem.Click += отчислитьToolStripMenuItem_Click;
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
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from K_Staff where s_ID = {id}";

                        var command = new MySqlCommand(deleteQuery, conn);
                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var fam = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var nam = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var age = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var gen = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var num = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var mail = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var post = dataGridView1.Rows[index].Cells[7].Value.ToString();
                        var stat = dataGridView1.Rows[index].Cells[8].Value.ToString();

                        var changeQuery = $"update K_Clients set s_Fam = '{fam}', s_Nam = '{nam}', s_Age = '{age}', s_Sex = '{gen}', s_Number = '{num}', s_Email = '{mail}', s_Post = '{post}', s_Stat = '{stat}' where s_ID = '{id}'";

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
            dataGridView1.Columns.Add("s_ID", "Код");
            dataGridView1.Columns.Add("s_Fam", "Фамилия");
            dataGridView1.Columns.Add("s_Nam", "Имя");
            dataGridView1.Columns.Add("s_Age", "Возраст");
            dataGridView1.Columns.Add("s_Sex", "Пол");
            dataGridView1.Columns.Add("s_Number", "Телефонный номер");
            dataGridView1.Columns.Add("s_Email", "Электронная почта");
            dataGridView1.Columns.Add("s_Post", "Должность");
            dataGridView1.Columns.Add("s_Stat", "Статус");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from K_Staff";

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
                    dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
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

            var id = textBox1.Text;
            var fam = textBox2.Text;
            var nam = textBox3.Text;
            var sex = textBox5.Text;
            var num = textBox6.Text;
            var mail = textBox7.Text;
            var post = textBox8.Text;
            var stat = textBox9.Text;
            int age;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox4.Text, out age))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fam, nam, age, sex, num, mail, post, stat);
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
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
            string query2 = $"UPDATE K_Staff SET s_Stat='{new_state}' WHERE (s_ID='{redact_id}')";
            MySqlCommand command = new MySqlCommand(query2, conn);
            command.ExecuteNonQuery();
            conn.Close();
            UpdateT();
            ChangeColorDGV();
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeState("1");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeState("2");
        }

        private void ChangeColorDGV()
        {
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount - 1;
            toolStripLabel2.Text = (count_rows).ToString();
            //Проходимся по ДатаГриду и красим строки в нужные нам цвета, в зависимости от статуса студента
            for (int i = 0; i < count_rows; i++)
            {

                //статус конкретного студента в Базе данных, на основании индекса строки
                int id_selected_status = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                //Логический блок для определения цветности
                if (id_selected_status == 1)
                {
                    //Красим в красный
                    dataGridView1.Rows[i].Cells[8].Style.BackColor = Color.Red;
                }
                if (id_selected_status == 2)
                {
                    //Красим в зелёный
                    dataGridView1.Rows[i].Cells[8].Style.BackColor = Color.Green;
                }
                if (id_selected_status == 3)
                {
                    //Красим в желтый
                    dataGridView1.Rows[i].Cells[8].Style.BackColor = Color.Cyan;
                }
            }
        }
        #region ТулСтрип

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
        private void зачислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeState("2");
        }

        private void отчислитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeState("1");
        }

        private void выделенныйIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{selected_Row}");
        }
        private void сброс(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
            toolStripTextBox2.Clear();
            toolStripTextBox3.Clear();
            toolStripTextBox4.Clear();
            toolStripTextBox5.Clear();
            toolStripTextBox6.Clear();
            toolStripTextBox7.Clear();
            toolStripTextBox8.Clear();
            toolStripTextBox9.Clear();
        }

        private void перезагрузка(object sender, EventArgs e)
        {
            UpdateT();
        }
        #endregion
        private void Staff_Load(object sender, EventArgs e)
        {
            //Вызываем метод для заполнение дата Грида
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
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[7].Visible = true;
            dataGridView1.Columns[8].Visible = true;
            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            ChangeColorDGV();
        }
        #region Управление
        private void button4_Click(object sender, EventArgs e)
        {
            Hiring hiring = new Hiring();
            hiring.ShowDialog();
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
        #endregion

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
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
                textBox9.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
