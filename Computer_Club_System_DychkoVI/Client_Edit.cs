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
    public partial class Client_Edit : Form
    {
        public Client_Edit()
        {
            InitializeComponent();
        }
        Database DB = new Database();
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear(object sender, EventArgs e)
        {
            SelectData();
        }
        public void SelectData()
        {
            string selected_ID = IDBox.SelectedValue.ToString();
            DB.openConnection();
            string msql = $"SELECT * FROM Clients WHERE ID={selected_ID}";
            MySqlCommand command = new MySqlCommand(msql, DB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FIOBox.Text = reader[1].ToString();
                AgeBox.Text = (reader[2].ToString());
                GenBox.Text = reader[3].ToString();
                NumBox.Text = reader[4].ToString();
                EmailBox.Text = reader[5].ToString();
            }
            reader.Close();
            DB.CloseConnection();
        }
        public void GetClientList()
        {
            DataTable list_clients_table = new DataTable();
            MySqlCommand list_clients_command = new MySqlCommand();
            DB.openConnection();
            list_clients_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_clients_table.Columns.Add(new DataColumn("FIO", System.Type.GetType("System.String")));
            IDBox.DataSource = list_clients_table;
            IDBox.DisplayMember = "FIO";
            IDBox.ValueMember = "ID";
            string sql_list_clients = "SELECT ID, FIO FROM Clients";
            list_clients_command.CommandText = sql_list_clients;
            list_clients_command.Connection = DB.getConnection();
            MySqlDataReader list_clients_reader;
            try
            {
                list_clients_reader = list_clients_command.ExecuteReader();
                while (list_clients_reader.Read())
                {
                    DataRow rowToAdd = list_clients_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_clients_reader[0]);
                    rowToAdd["FIO"] = list_clients_reader[1].ToString();
                    list_clients_table.Rows.Add(rowToAdd);
                }
                list_clients_reader.Close();
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
        private void Redact(object sender, EventArgs e)
        {
            //Определяем значение переменных для записи в БД
            var id = IDBox.SelectedValue.ToString();
            var fio = FIOBox.Text;
            var age = AgeBox.Text;
            var gen = GenBox.Text;
            var num = NumBox.Text;
            var mail = EmailBox.Text;
            //Формируем запрос на изменение
            var changeQuery = $"update Clients set FIO = '{fio}', Age = '{age}', Sex = '{gen}', Number = '{num}', Email = '{mail}' where ID = '{id}'";
            // устанавливаем соединение с БД
            DB.openConnection();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(changeQuery, DB.getConnection());
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            DB.CloseConnection();
            //Закрываем форму
            this.Close();
        }

        private void Client_Edit_Load(object sender, EventArgs e)
        {
            GetClientList();
            SelectData();
        }
    }
}
