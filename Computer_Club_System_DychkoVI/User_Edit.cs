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
    public partial class User_Edit : Form
    {
        public User_Edit()
        {
            InitializeComponent();
        }
        Database DB = new Database();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
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
        public void SelectData()
        {
            string selected_ID = IDBox.SelectedValue.ToString();
            DB.OpenConnection();
            string msql = $"SELECT * FROM Users WHERE id_user={selected_ID}";
            MySqlCommand command = new MySqlCommand(msql, DB.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LoginBox.Text = reader[1].ToString();
                PassBox.Text = (reader[2].ToString());
                HashBox.Text = reader[3].ToString();
            }
            reader.Close();
            DB.CloseConnection();
        }
        public void GetUsersList()
        {
            DataTable list_of_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            DB.OpenConnection();
            list_of_table.Columns.Add(new DataColumn("id_user", System.Type.GetType("System.Int32")));
            IDBox.DataSource = list_of_table;
            IDBox.DisplayMember = "id_user";
            IDBox.ValueMember = "id_user";
            string sql_list = "SELECT id_user FROM Users";
            list_command.CommandText = sql_list;
            list_command.Connection = DB.GetConnection();
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_of_table.NewRow();
                    rowToAdd["id_user"] = Convert.ToInt32(list_reader[0]);
                    list_of_table.Rows.Add(rowToAdd);
                }
                list_reader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения списка.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                var id = IDBox.SelectedValue.ToString();
                var login = LoginBox.Text;
                var password = PassBox.Text;
                var Hash = HashBox.Text;
                DB.OpenConnection();
                //Формируем запрос на изменение
                var changeQuery = $"update Users set login_user = '{login}', password_user = '{password}', hash = '{Hash}' where id_user = '{id}'";
                // устанавливаем соединение с БД
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(changeQuery, DB.GetConnection());
                // выполняем запрос
                command.ExecuteNonQuery();
                // закрываем подключение к БД
            }
            catch
            {
                MessageBox.Show("Технические неполадки!");
            }
            finally
            {
                MessageBox.Show($"Данные пользователя {LoginBox.Text} успешно изменены!");
            }
            DB.CloseConnection();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectData();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            HashBox.Text = sha256(PassBox.Text);
        }

        private void User_Edit_Load(object sender, EventArgs e)
        {
            GetUsersList();
            SelectData();
        }
    }
}
