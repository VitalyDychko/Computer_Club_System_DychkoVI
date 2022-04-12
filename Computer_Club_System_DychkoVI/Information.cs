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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        string X = "server=chuc.caseum.ru;port=33333;user=st_3_19_5;database=is_3_19_st5_KURS;password=54175268;";

        public void WorkersCount()
        {
            string stmt = "SELECT COUNT(*) FROM Staff";

            using (MySqlConnection thisConnection = new MySqlConnection(X))
            {
                using (MySqlCommand cmdCount = new MySqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    label3.Text = Convert.ToString(cmdCount.ExecuteScalar());
                }
                thisConnection.Close();
            }
        }

        public void ClientsCount()
        {
            string stmt = "SELECT COUNT(*) FROM Clients";

            using (MySqlConnection thisConnection = new MySqlConnection(X))
            {
                using (MySqlCommand cmdCount = new MySqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    label4.Text = Convert.ToString(cmdCount.ExecuteScalar());
                }
                thisConnection.Close();
            }
        }

        public void DevicesCount()
        {
            string stmt = "SELECT COUNT(*) FROM Comps";

            using (MySqlConnection thisConnection = new MySqlConnection(X))
            {
                using (MySqlCommand cmdCount = new MySqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    label6.Text = Convert.ToString(cmdCount.ExecuteScalar());
                }
                thisConnection.Close();
            }
        }
        public void GetTables(ListBox lb)
        {
            using (MySqlConnection connection = new MySqlConnection(X))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    lb.Items.Add(row[2].ToString());
                }
                connection.Close();
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            WorkersCount();
            ClientsCount();
            DevicesCount();
            GetTables(listBox1);
        }
    }
}
