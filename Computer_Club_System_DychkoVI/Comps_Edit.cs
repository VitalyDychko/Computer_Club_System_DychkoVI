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
    public partial class Comps_Edit : Form
    {
        public Comps_Edit()
        {
            InitializeComponent();
        }

        readonly Database DB = new Database();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //Определяем значение переменных для записи в БД
            DB.Edit_Comp(IDBox.SelectedValue, TypeBox.SelectedValue, NameBox.Text, SuppBox.Text);
            //Закрываем форму
            this.Close();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            SelectData();
        }
        public void SelectData()
        {
            string selected_ID = IDBox.SelectedValue.ToString();
            DB.OpenConnection();
            string msql = $"SELECT * FROM Comps WHERE ID={selected_ID}";
            MySqlCommand command = new MySqlCommand(msql, DB.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NameBox.Text = reader[1].ToString();
                SuppBox.Text = (reader[2].ToString());
                TypeBox.Text = reader[3].ToString();
            }
            reader.Close();
            DB.CloseConnection();
        }
        public void GetCompsList()
        {
            DataTable list_of_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            DB.OpenConnection();
            list_of_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            IDBox.DataSource = list_of_table;
            IDBox.DisplayMember = "ID";
            IDBox.ValueMember = "ID";
            string sql_list = "SELECT ID FROM Comps";
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

        private void Comps_Edit_Load(object sender, EventArgs e)
        {
            GetTypeList();
            GetCompsList();
            SelectData();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            SelectData();
        }
    }
}
