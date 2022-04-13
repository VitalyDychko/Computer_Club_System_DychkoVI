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
    public partial class User_Add : Form
    {
        Database DB = new Database();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        public User_Add()
        {
            InitializeComponent();
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
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
                    Login logn = new Login();
                    this.Hide();
                    logn.ShowDialog();
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
            catch { MessageBox.Show("Произошли технические неполадки!"); }
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

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            HashBox.Text = sha256(PassBox.Text);
        }

        private void User_Add_Load(object sender, EventArgs e)
        {
            LoginBox.MaxLength = 50;
            PassBox.MaxLength = 50;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
