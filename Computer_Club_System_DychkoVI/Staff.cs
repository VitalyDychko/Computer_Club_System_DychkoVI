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
        readonly Database DB = new Database();
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содердит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        int selected_Row;
        public Staff()
        {
            InitializeComponent();
        }
        #region Основные методы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Код");
            dataGridView1.Columns.Add("FIO", "ФИО");
            dataGridView1.Columns.Add("Age", "Возраст");
            dataGridView1.Columns.Add("Gen", "Пол");
            dataGridView1.Columns.Add("Num", "Телефонный номер");
            dataGridView1.Columns.Add("Email", "Электронная почта");
            dataGridView1.Columns.Add("Post", "Должность");
            dataGridView1.Columns.Add("Stat", "Статус");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        public void UpdateT()
        {
            try
            {
                DB.OpenConnection();

                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from Staff where ID = {id}";

                        var command = new MySqlCommand(deleteQuery, DB.GetConnection());
                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var fio = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var age = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var gen = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var num = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var mail = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var post = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var stat = dataGridView1.Rows[index].Cells[7].Value.ToString();

                        var changeQuery = $"update Staff set FIO = '{fio}', Age = '{age}', Gen = '{gen}', Num = '{num}', Email = '{mail}', Post = '{post}', Stat = '{stat}' where ID = '{id}'";

                        var command = new MySqlCommand(changeQuery, DB.GetConnection());
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
                DB.CloseConnection();
                ChangeColorDGV();
            }
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            try
            {
                dgw.Rows.Clear();

                string querystring = $"select * from Staff";

                MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

                DB.OpenConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadsSingleRow(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                ChangeColorDGV();
                DB.CloseConnection();
            }
        }
        public void DeleteRow()
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
                DB.CloseConnection();
                //Вызов метода обновления ДатаГрида
            }
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = IDBox.Text;
            var fio = FioBox.Text;
            var gen = GenBox.Text;
            var num = NumBox.Text;
            var mail = MailBox.Text;
            var post = JobBox.SelectedValue.ToString();
            var stat = StatBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(AgeBox.Text, out int age))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, age, gen, num, mail, post, stat);
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Возраст должен иметь числовой формат");
                }
            }
        }
        public void GetJobList()
        {
            DataTable list_job_table = new DataTable();
            MySqlCommand list_job_command = new MySqlCommand();
            DB.OpenConnection();
            list_job_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_job_table.Columns.Add(new DataColumn("Job", System.Type.GetType("System.String")));
            JobBox.DataSource = list_job_table;
            JobBox.DisplayMember = "Job";
            JobBox.ValueMember = "Job";
            string sql_list_job = "SELECT ID, Job FROM Job_Categories";
            list_job_command.CommandText = sql_list_job;
            list_job_command.Connection = DB.GetConnection();
            MySqlDataReader list_job_reader;
            try
            {
                list_job_reader = list_job_command.ExecuteReader();
                while (list_job_reader.Read())
                {
                    DataRow rowToAdd = list_job_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_job_reader[0]);
                    rowToAdd["Job"] = list_job_reader[1].ToString();
                    list_job_table.Rows.Add(rowToAdd);
                }
                list_job_reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения списка.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }
        public void ChangeState(string new_state)
        {
            int redact_id = selected_Row;
            DB.OpenConnection();
            string query2 = $"UPDATE Staff SET Stat='{new_state}' WHERE (ID='{redact_id}')";
            MySqlCommand command = new MySqlCommand(query2, DB.GetConnection());
            command.ExecuteNonQuery();
            DB.CloseConnection();
            UpdateT();
            ChangeColorDGV();
        }
        #endregion
        private void ChangeColorDGV()
        {
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount;
            toolStripLabel2.Text = (count_rows).ToString();
            //Проходимся по ДатаГриду и красим строки в нужные нам цвета, в зависимости от статуса студента
            for (int i = 0; i < count_rows; i++)
            {

                //статус конкретного студента в Базе данных, на основании индекса строки
                string id_selected_status = Convert.ToString(dataGridView1.Rows[i].Cells[7].Value);
                //Логический блок для определения цветности
                if (id_selected_status == "Увольнение")
                {
                    //Красим в красный
                    dataGridView1.Rows[i].Cells[7].Style.BackColor = Color.Red;
                }
                if (id_selected_status == "Работает")
                {
                    //Красим в зелёный
                    dataGridView1.Rows[i].Cells[7].Style.BackColor = Color.Green;
                }
                if (id_selected_status == "Отгул")
                {
                    //Красим в желтый
                    dataGridView1.Rows[i].Cells[7].Style.BackColor = Color.Cyan;
                }
            }
        }
        #region ТулСтрип

        private void Rename(object sender, EventArgs e)
        {
            UpdateT();
        }
        #endregion
        private void Staff_Load(object sender, EventArgs e)
        {
            //Вызываем метод для заполнение дата Грида
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            GetJobList();
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
            dataGridView1.Columns[8].Visible = false;
            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            //Растягивание полей грида
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Убираем заголовки строк
            dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Стиль
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold); //шрифт
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold; // цвет ряда-заголовка
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
        private void Staff_Adder(object sender, EventArgs e)
        {
            Staff_Add hiring = new Staff_Add();
            hiring.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateT();
        }
        #endregion

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                IDBox.Text = row.Cells[0].Value.ToString();
                FioBox.Text = row.Cells[1].Value.ToString();
                AgeBox.Text = row.Cells[2].Value.ToString();
                GenBox.Text = row.Cells[3].Value.ToString();
                NumBox.Text = row.Cells[4].Value.ToString();
                MailBox.Text = row.Cells[5].Value.ToString();
                JobBox.Text = row.Cells[6].Value.ToString();
                StatBox.Text = row.Cells[7].Value.ToString();
                toolStripLabel4.Text = row.Cells[0].Value.ToString();
            }
        }

        private void BtnDelete(object sender, EventArgs e)
        {
            DeleteRow();
            UpdateT();
        }

        private void BtnChange(object sender, EventArgs e)
        {
            Change();
            UpdateT();
        }

        private void Reload(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void BtnRedact_Click(object sender, EventArgs e)
        {
            Staff_Edit SE = new Staff_Edit();
            SE.Show();
        }
    }
}
