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
    public partial class ClientAdd : Form
    {
        MySqlConnection conn = ConnDB.ConnMysqlClient();
        public ClientAdd()
        {
            InitializeComponent();
        }
        private void Шаблон(object sender, EventArgs e)
        {
            textBox1.Text = "Юля Захаренко";
            textBox2.Text = "18";
            textBox3.Text = "+78904523";
            textBox4.Text = "Sakhar@yandex.ru";
            comboBox1.Text = "Женский";
        }
        private void добавить(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 || textBox2.TextLength != 0 || textBox3.TextLength != 0 || textBox4.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    Random rnd = new Random();
                    int rand = rnd.Next(1000, 9999);

                    string commandStr = $"INSERT INTO K_Clients (s_ID, s_FIO, s_Age, s_Sex, s_Number, s_Email) VALUES (@ID,@FIO,@Age,@Pol,@Num,@Mail)";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, conn))
                    {
                        cmnd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = "c-" + rand;
                        cmnd.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = textBox1.Text;
                        cmnd.Parameters.Add("@Age", MySqlDbType.VarChar).Value = textBox2.Text;
                        cmnd.Parameters.Add("@Num", MySqlDbType.VarChar).Value = textBox3.Text;
                        cmnd.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = textBox4.Text;
                        cmnd.Parameters.Add("@Pol", MySqlDbType.VarChar).Value = comboBox1.Text;
                        cmnd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    MessageBox.Show("Сотрудник добавлен.");
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
