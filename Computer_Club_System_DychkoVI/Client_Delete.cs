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
    public partial class Client_Delete : Form
    {
        public Client_Delete()
        {
            InitializeComponent();
        }
        Database DB = new Database();
        public delegate void Universal_Remover_Delegate(string table, object id);
        public void GetClientList()
        {
            DataTable list_clients_table = new DataTable();
            MySqlCommand list_clients_command = new MySqlCommand();
            DB.OpenConnection();
            list_clients_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_clients_table.Columns.Add(new DataColumn("FIO", System.Type.GetType("System.String")));
            IDBox.DataSource = list_clients_table;
            IDBox.DisplayMember = "FIO";
            IDBox.ValueMember = "ID";
            string sql_list_clients = "SELECT ID, FIO FROM Clients";
            list_clients_command.CommandText = sql_list_clients;
            list_clients_command.Connection = DB.GetConnection();
            MySqlDataReader list_clients_reader;
            try
            {
                list_clients_reader = list_clients_command.ExecuteReader();
                while (list_clients_reader.Read())
                {
                    DataRow rowToAdd = list_clients_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_clients_reader[0]);
                    rowToAdd["FIO"] = list_clients_reader[1].ToString();
                    list_clients_table.Rows.Add(rowToAdd);
                }
                list_clients_reader.Close();
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
        private void Remove(object sender, EventArgs e)
        {
            Universal_Remover_Delegate UD = new Universal_Remover_Delegate(DB.Universal_Remover);
            UD.Invoke("Clients", IDBox.SelectedValue);
            GetClientList();
        }

        private void Client_Delete_Load(object sender, EventArgs e)
        {
            GetClientList();
        }
    }
}
