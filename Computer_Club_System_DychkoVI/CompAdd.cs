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
    public partial class CompAdd : Form
    {
        MySqlConnection conn = ConnDB.ConnMysqlClient();
        public CompAdd()
        {
            InitializeComponent();
        }

        private void addcomp(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 || textBox2.TextLength != 0)
            {
                try
                {
                    conn.Open();

                    string commandStr = $"INSERT INTO K_Clients (s_Name, s_Supp, s_Type) VALUES (@NAM,@SUPP,@TYPE)";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, conn))
                    {
                        cmnd.Parameters.Add("@NAM", MySqlDbType.VarChar).Value = textBox1.Text;
                        cmnd.Parameters.Add("@SUPP", MySqlDbType.VarChar).Value = textBox2.Text;
                        cmnd.Parameters.Add("TYPE", MySqlDbType.VarChar).Value = comboBox1.Text;
                        cmnd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    MessageBox.Show("Компьютер добавлен.");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }
        }
    }
}
