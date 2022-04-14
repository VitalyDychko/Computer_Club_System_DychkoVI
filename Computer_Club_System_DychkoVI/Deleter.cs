using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dyczko_ComputerClub_System
{
    public partial class Deleter : Form
    {
        public Deleter()
        {
            InitializeComponent();
            GetTables(TableBox);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        Database DB = new Database();
        public delegate void Universal_Remover_Delegate(string table, object id);
        public void GetUniversalList(object table)
        {
            DataTable list_clients_table = new DataTable();
            MySqlCommand list_clients_command = new MySqlCommand();
            DB.OpenConnection();
            list_clients_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            IDBox.DataSource = list_clients_table;
            IDBox.DisplayMember = "ID";
            IDBox.ValueMember = "ID";
            string sql_list_clients = $"SELECT ID FROM {table}";
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
                    list_clients_table.Rows.Add(rowToAdd);
                }
                list_clients_reader.Close();
            }
            catch { MessageBox.Show($"таблица {TableBox.Text} не поддерживается!"); }
            finally { DB.CloseConnection(); }
        }
        private void Remove(object sender, EventArgs e)
        {
            Universal_Remover_Delegate UD = new Universal_Remover_Delegate(DB.Universal_Remover);
            UD.Invoke(TableBox.Text, IDBox.SelectedValue);
            GetUniversalList(TableBox.Text);
        }

        private void Client_Delete_Load(object sender, EventArgs e)
        {
            GetTables(TableBox);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetTables(ComboBox cb)
        {
            using (MySqlConnection connection = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_19_5;database=is_3_19_st5_KURS;password=54175268;"))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    cb.Items.Add(row[2].ToString());
                }
                connection.Close();
            }
        }

        private void TableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUniversalList(TableBox.Text);
        }

        private void Deleter_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
