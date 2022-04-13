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
    public partial class Login : Form
    {
        Database DB = new Database();
        public void GetUserInfo(string login_user)
        {
            // устанавливаем соединение с БД
            DB.OpenConnection();
            // запрос
            string sql = $"SELECT * FROM Users WHERE login_user = '{login_user}'";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, DB.GetConnection());
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                Auth.auth_id = reader[0].ToString();
                Auth.auth_login = reader[1].ToString();
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            DB.CloseConnection();
        }
        public Login()
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

            string querystring = $"select ID, login_user, password_user from Users where login_user = '{loginUser}' and password_user = '{passUser}'";

            MySqlCommand command = new MySqlCommand(querystring, DB.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            DB.CloseConnection();

            if (table.Rows.Count == 1)
            {
                //Присваеваем глобальный признак авторизации
                Auth.auth = true;
                //Достаем данные пользователя в случае успеха
                GetUserInfo(textBox_login.Text);
                //закрываем форму
                this.Close();
                //передача потока
                new Thread(() => Application.Run(new ClubMenu())).Start();
            }
            else MessageBox.Show("Такого аккаунта не существует!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Zareg_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new Register())).Start();
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

        private void Login_MouseDown(object sender, MouseEventArgs e)
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
