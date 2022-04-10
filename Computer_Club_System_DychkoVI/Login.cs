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
    public partial class Login : Form
    {
        Database DB = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from Users where login_user = '{loginUser}' and password_user = '{passUser}'";

            MySqlCommand command = new MySqlCommand(querystring, DB.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "успешо!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClubMenu clubMenu = new ClubMenu();
                this.Hide();
                clubMenu.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Такого аккаунта не существует!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Zareg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            this.Hide();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            Open_eye.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void Open_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            Open_eye.Visible = false;
            Hide_eye.Visible = true;
        }

        private void Hide_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            Hide_eye.Visible = false;
            Open_eye.Visible = true;
        }
    }
}
