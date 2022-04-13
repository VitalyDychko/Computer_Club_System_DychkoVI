using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dyczko_ComputerClub_System
{
    public partial class Register : Form
    {
        Database DB = new Database();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public Register()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Вычисление хэша строки и возрат его из метода
        static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        private void RegBtn_Click(object sender, EventArgs e)
        {
            var login = LoginBox.Text;
            var password = PassBox.Text;
            var Hash = sha256(HashBox.Text);

            string querystring = $"INSERT INTO Users (login_user, password_user, hash) VALUES ('{login}','{password}','{Hash}')";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

            DB.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Form_Destroying();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            if (CheckUser())
            {
                return;
            }
            DB.CloseConnection();
        }
        private Boolean CheckUser()
        {
            var login = LoginBox.Text;
            var password = PassBox.Text;
            var hash = HashBox.Text;

            string querystring = $"select ID, login_user, password_user, hash from Users where login_user = '{login}', password_user = '{password}' and hash = '{hash}'";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

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
        private void Form_Destroying()
        {
            this.Close();
            new Thread(() => Application.Run(new Login())).Start();
        }
        private void Vhod_Click(object sender, EventArgs e)
        {
            Form_Destroying();
        }

        private void Open_eye_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = false;
            Open_eye.Visible = false;
            Hide_eye.Visible = true;
        }

        private void Hide_eye_Click(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = true;
            Hide_eye.Visible = false;
            Open_eye.Visible = true;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Open_eye.Visible = false;
            LoginBox.MaxLength = 50;
            PassBox.MaxLength = 50;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            HashBox.Text = sha256(PassBox.Text);
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
