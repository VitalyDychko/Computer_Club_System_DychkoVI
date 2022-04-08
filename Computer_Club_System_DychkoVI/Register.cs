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
    public partial class Register : Form
    {
        MySqlConnection conn = ConnDB.ConnMysqlClient();
        public Register()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            var login = textBox_login;
            var password = textBox_password;

            string querystring = $"Insert into K_Users(login_user, password_user) values('{login}','{password}')";

            MySqlCommand command = new MySqlCommand(querystring, conn);

            conn.Open();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Log_in logn = new Log_in();
                this.Hide();
                logn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            conn.Close();
            if (CheckUser())

            {
                return;
            }
        }
        private Boolean CheckUser()
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, id_user, login_user, password_user from K_User where login_user = '{loginUser}' and password_user = '{passUser}'";

            MySqlCommand command = new MySqlCommand(querystring, conn);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Vhod_Click(object sender, EventArgs e)
        {
            Log_in logn = new Log_in();
            logn.ShowDialog();
            this.Hide();
        }

        private void Open_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            Open_eye.Visible = false;
            Hide_eye.Visible = true;
        }

        private void Hide_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            Hide_eye.Visible = false;
            Open_eye.Visible = true;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            Open_eye.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }
    }
}
