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
        readonly Database DB = new Database();
        int selected_Row;
        public Clients()
        {
            InitializeComponent();
        }
        #region Основные методы
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Код");
            dataGridView1.Columns.Add("FIO", "ФИО");
            dataGridView1.Columns.Add("Age", "Возраст");
            dataGridView1.Columns.Add("Sex", "Пол");
            dataGridView1.Columns.Add("Number", "Телефонный номер");
            dataGridView1.Columns.Add("Email", "Электронная почта");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Clients";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

            DB.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadsSingleRow(dgw, reader);
            }
            reader.Close();
            Count_of_Rows();
        }
        public void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;
            try
            {
                if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateT()
        {
            DB.OpenConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Clients where ID = {id}";

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

                    var changeQuery = $"update Clients set FIO = '{fio}', Age = '{age}', Sex = '{gen}', Number = '{num}', Email = '{mail}' where ID = '{id}'";

                    var command = new MySqlCommand(changeQuery, DB.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            Count_of_Rows();
            DB.CloseConnection();
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = IDBox.Text;
            var fio = FIOBox.Text;
            var gen = GenBox.Text;
            var num = NumBox.Text;
            var mail = EmailBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(AgeBox.Text, out int age))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fio, age, gen, num, mail);
                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Возраст должен иметь числовой формат");
                }
            }
        }
        private void Count_of_Rows()
        {
            int count_rows = dataGridView1.RowCount;
            toolStripLabel2.Text = (count_rows).ToString();
        }
        #endregion
        #region Items
        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void ВыделенныйIDToolStripMenuItem_Click(object sender, EventArgs e)
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
            dataGridView1.Columns[6].Visible = false;
            //Режим для полей "Только для чтения"
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            //Растягивание полей грида
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        }
        #region ToolStrip
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        #endregion
        #region Управление записями

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                IDBox.Text = row.Cells[0].Value.ToString();
                FIOBox.Text = row.Cells[1].Value.ToString();
                AgeBox.Text = row.Cells[2].Value.ToString();
                GenBox.Text = row.Cells[3].Value.ToString();
                NumBox.Text = row.Cells[4].Value.ToString();
                EmailBox.Text = row.Cells[5].Value.ToString();
                toolStripLabel4.Text = row.Cells[0].Value.ToString();
            }
        }

        private void BtnNewClient(object sender, EventArgs e)
        {
            Client_Add CLAD = new Client_Add();
            CLAD.ShowDialog();
        }

        private void BtnChange(object sender, EventArgs e)
        {
            Change();
            UpdateT();
        }

        private void BtnDel(object sender, EventArgs e)
        {
            DeleteRow();
            UpdateT();
        }
        #endregion

        private void BtnAddon(object sender, EventArgs e)
        {
            Client_Add CA = new Client_Add();
            CA.ShowDialog();
        }

        private void BtnRedact_Click(object sender, EventArgs e)
        {
            Client_Edit CE = new Client_Edit();
            CE.ShowDialog();
        }

        private void Reload(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
