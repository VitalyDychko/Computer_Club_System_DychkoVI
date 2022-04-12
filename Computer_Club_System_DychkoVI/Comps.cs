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
        Database DB = new Database();
        int selected_Row;
        public Comps()
        {
            InitializeComponent();
            #region ContextMenu
            // создаем элементы меню
            ToolStripMenuItem OffMenuItem = new ToolStripMenuItem("Отключить");
            ToolStripMenuItem OnMenuItem = new ToolStripMenuItem("Включить");
            ToolStripMenuItem BusyMenuItem = new ToolStripMenuItem("На ремонте");
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
                DB.OpenConnection();

                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                        var deleteQuery = $"delete from Comps where ID = {id}";

                        var command = new MySqlCommand(deleteQuery, DB.GetConnection());
                        command.ExecuteNonQuery();
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var nam = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var supp = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var type = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var stat = dataGridView1.Rows[index].Cells[4].Value.ToString();

                        var changeQuery = $"update Comps set Name = '{nam}', Supp = '{supp}', Type = '{type}', Stat = '{stat}' where ID = '{id}'";

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
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "Номер");
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Supp", "Поставщик");
            dataGridView1.Columns.Add("Type", "Тип");
            dataGridView1.Columns.Add("Stat", "Состояние");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }
        private void ReadsSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querystring = $"select * from Comps";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

            DB.OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
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
                DB.CloseConnection();
                //Вызов метода обновления ДатаГрида
                RefreshDataGrid(dataGridView1);
            }
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            int id;
            var nam = NameBox.Text;
            var supp = SuppBox.Text;
            var type = TypeBox.Text;
            var stat = StatBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(IDBox.Text, out id))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, nam, supp, type, stat);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Возраст должен иметь числовой формат");
                }
            }
        }
        public void GetTypeList()
        {
            DataTable list_of_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            DB.OpenConnection();
            list_of_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_of_table.Columns.Add(new DataColumn("Type", System.Type.GetType("System.String")));
            TypeBox.DataSource = list_of_table;
            TypeBox.DisplayMember = "Type";
            TypeBox.ValueMember = "Type";
            string sql_list = "SELECT ID, Type FROM Devices_Categories";
            list_command.CommandText = sql_list;
            list_command.Connection = DB.GetConnection();
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_of_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_reader[0]);
                    rowToAdd["Type"] = list_reader[1].ToString();
                    list_of_table.Rows.Add(rowToAdd);
                }
                list_reader.Close();
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
            ChangeState("On repair");
        }
        #endregion
        public void ChangeState(string new_state)
        {
            int redact_id = selected_Row;
            DB.OpenConnection();
            string query2 = $"UPDATE Comps SET Stat='{new_state}' WHERE (ID='{redact_id}')";
            MySqlCommand command = new MySqlCommand(query2, DB.GetConnection());
            command.ExecuteNonQuery();
            DB.CloseConnection();
            UpdateT();
            ChangeColorDGV();
        }
        private void ChangeColorDGV()
        {
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount;
            toolStripLabel2.Text = (count_rows).ToString();
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
                if (id_selected_status == "On repair")
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
            GetTypeList();
            #region Стиль
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = false;
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9, FontStyle.Bold); //шрифт
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold; // цвет ряда-заголовка
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_Row = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selected_Row];

                IDBox.Text = row.Cells[0].Value.ToString();
                NameBox.Text = row.Cells[1].Value.ToString();
                SuppBox.Text = row.Cells[2].Value.ToString();
                TypeBox.Text = row.Cells[3].Value.ToString();
                StatBox.Text = row.Cells[4].Value.ToString();
                toolStripLabel4.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
            UpdateT();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteRow();
            UpdateT();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ChangeColorDGV();
        }

        private void BtnAdding_Click(object sender, EventArgs e)
        {
            Comps_Add CAD = new Comps_Add();
            CAD.ShowDialog();
        }

        private void BtnRedact_Click(object sender, EventArgs e)
        {
            Comps_Edit CED = new Comps_Edit();
            CED.ShowDialog();
        }
    }
}
