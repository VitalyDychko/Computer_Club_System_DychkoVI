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
    public partial class Seans : Form
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
        public Seans()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Код");
            dataGridView1.Columns.Add("comp", "Компьютер");
            dataGridView1.Columns.Add("user", "Пользователь");
            dataGridView1.Columns.Add("time", "Минуты");
            dataGridView1.Columns.Add("start", "Начало");
            dataGridView1.Columns.Add("end", "Конец");
            dataGridView1.Columns.Add("price", "Стоимость");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Seans";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

            DB.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
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
                    dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                    return;
                }
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки \n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateT()
        {
            DB.OpenConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Seans where ID = {id}";

                    var command = new MySqlCommand(deleteQuery, DB.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            Count_of_Rows();
            DB.CloseConnection();
        }
        private void Count_of_Rows()
        {
            int count_rows = dataGridView1.RowCount;
            toolStripLabel2.Text = (count_rows).ToString();
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void BtnAdding_Click(object sender, EventArgs e)
        {
            Seans_Add SA = new Seans_Add();
            SA.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DeleteRow();
            UpdateT();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                row.Cells[0].Value.ToString();
                row.Cells[1].Value.ToString();
                row.Cells[2].Value.ToString();
                row.Cells[3].Value.ToString();
                row.Cells[4].Value.ToString();
                row.Cells[5].Value.ToString();
                row.Cells[6].Value.ToString();
                toolStripLabel4.Text = row.Cells[0].Value.ToString();
            }
        }

        private void Seans_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[7].Visible = false;
            //Растягивание полей грида
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
    }
}
