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
    public partial class Hiring : Form
    {
        MySqlConnection conn = ConnDB.ConnMysqlClient();
        public Hiring()
        {
            InitializeComponent();
        }

        private void нанять(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 || textBox2.TextLength != 0 || textBox3.TextLength != 0 || textBox4.TextLength != 0)
            {
                try
                {
                    conn.Open();
                    Random rnd = new Random();
                    int rand = rnd.Next(1000, 9999);
                    string commandStr = $"INSERT INTO K_Staff (s_ID, s_Fam, s_Nam, s_Age, s_Sex, s_Number, s_Email, s_Post) VALUES (@ID,@FAM,@NAM,@Age,@Pol,@Num,@Mail,@Post)";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, conn))
                    {
                        cmnd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = "s-" + rand;
                        cmnd.Parameters.Add("@FAM", MySqlDbType.VarChar).Value = textBox1.Text;
                        cmnd.Parameters.Add("@NAM", MySqlDbType.VarChar).Value = textBox5.Text;
                        cmnd.Parameters.Add("@Age", MySqlDbType.VarChar).Value = textBox2.Text;
                        cmnd.Parameters.Add("@Num", MySqlDbType.VarChar).Value = textBox3.Text;
                        cmnd.Parameters.Add("@Mail", MySqlDbType.VarChar).Value = textBox4.Text;
                        cmnd.Parameters.Add("@Pol", MySqlDbType.VarChar).Value = comboBox1.Text;
                        cmnd.Parameters.Add("@Post", MySqlDbType.VarChar).Value = comboBox2.Text;
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

        private void очистить(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
