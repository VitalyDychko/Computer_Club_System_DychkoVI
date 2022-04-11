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
    public partial class Seans_Add : Form
    {
        readonly Database DB = new Database();
        public Seans_Add()
        {
            InitializeComponent();
        }
        public void GetUserList()
        {
            //Формирование списка статусов
            DataTable list_client_table = new DataTable();
            MySqlCommand list_client_command = new MySqlCommand();
            //Открываем соединение
            DB.OpenConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_client_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.String")));
            list_client_table.Columns.Add(new DataColumn("FIO", System.Type.GetType("System.String")));
            //Настройка видимости полей комбобокса
            ClientBox.DataSource = list_client_table;
            ClientBox.DisplayMember = "FIO";
            ClientBox.ValueMember = "FIO";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_client_users = "SELECT ID, FIO FROM Clients";
            list_client_command.CommandText = sql_client_users;
            list_client_command.Connection = DB.GetConnection();
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_client_reader;
            try
            {
                //Инициализируем ридер
                list_client_reader = list_client_command.ExecuteReader();
                while (list_client_reader.Read())
                {
                    DataRow rowToAdd = list_client_table.NewRow();
                    rowToAdd["ID"] = list_client_reader[0].ToString();
                    rowToAdd["FIO"] = list_client_reader[1].ToString();
                    list_client_table.Rows.Add(rowToAdd);
                }
                list_client_reader.Close();
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка ЦП \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }
        public void GetCompList()
        {
            //Формирование списка статусов
            DataTable list_comp_table = new DataTable();
            MySqlCommand list_comp_command = new MySqlCommand();
            //Открываем соединение
            DB.OpenConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_comp_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            //Настройка видимости полей комбобокса
            CompBox.DataSource = list_comp_table;
            CompBox.ValueMember = "ID";
            CompBox.DisplayMember = "ID";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_comps = "SELECT ID, Name FROM Comps";
            list_comp_command.CommandText = sql_list_comps;
            list_comp_command.Connection = DB.GetConnection();
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_comp_reader;
            try
            {
                //Инициализируем ридер
                list_comp_reader = list_comp_command.ExecuteReader();
                while (list_comp_reader.Read())
                {
                    DataRow rowToAdd = list_comp_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_comp_reader[0]);
                    list_comp_table.Rows.Add(rowToAdd);
                }
                list_comp_reader.Close();
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка ЦП \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        private void Addseans(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(MinuteBox.Text) || !String.IsNullOrWhiteSpace(PriceBox.Text))
            {
                DateTime current_time = dateTimePicker2.Value;
                DateTime Ending = current_time.AddMinutes(Convert.ToDouble(MinuteBox.Text));

                string sql_seans_add = $"INSERT INTO Seans (comp, user, time, start, end, price) " +
                                        $"VALUES (@PC, @US, @MIN, @START, @END, @PRICE)";
                using (MySqlCommand command = new MySqlCommand(sql_seans_add, DB.GetConnection()))
                {
                    command.Parameters.Add("@PC", MySqlDbType.VarChar).Value = CompBox.SelectedValue.ToString();
                    command.Parameters.Add("@US", MySqlDbType.VarChar).Value = ClientBox.SelectedValue.ToString();
                    command.Parameters.Add("@MIN", MySqlDbType.VarChar).Value = MinuteBox.Text;
                    command.Parameters.Add("@START", MySqlDbType.DateTime).Value = dateTimePicker2.Value;
                    command.Parameters.Add("@END", MySqlDbType.DateTime).Value = Ending;
                    command.Parameters.Add("@PRICE", MySqlDbType.VarChar).Value = PriceBox.Text;
                    DB.OpenConnection();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Рейс успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}");
                    }

                    finally
                    {
                        DB.CloseConnection();
                    }
                }
                this.Close();
            }
            else MessageBox.Show("Введите данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void Calc()
        {
            //TimeSpan result = dateTimePicker2.Value - dateTimePicker1.Value;
            //PriceBox.Text = result.TotalMinutes.ToString();

            //string s = PriceBox.Text;
            //string[] tempArry = PriceBox.Text.Split('.');
            //PriceBox.Text = tempArry[0];
        }
        private void Seans_Add_Load(object sender, EventArgs e)
        {
            GetUserList();
            GetCompList();
        }
        private void Sum()
        {
            int min = Convert.ToInt32(MinuteBox.Text);
            var result = min * DB.Rub;
            PriceBox.Text = Convert.ToString(Math.Round(result));
        }
        private void MinuteBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(MinuteBox.Text))
            {
                Sum();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}