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
    public partial class Services : Form
    {
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
        }
        readonly Database DB = new Database();
        int selected_Row;
        public Services()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Service", "Услуга");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Price", "Стоимость");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"SELECT S.Service, S.Description, P.Price " +
                $"FROM Services AS S JOIN " +
                $"Prices AS P " +
                $"ON P.id = S.ID_s";

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
            Services_Add SAD = new Services_Add();
            SAD.ShowDialog();
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
                toolStripLabel4.Text = row.Cells[0].Value.ToString();
            }
        }

        private void Services_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            #region Стиль
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = false;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
