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
        Database DB = new Database();
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
            DB.openConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_client_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.String")));
            list_client_table.Columns.Add(new DataColumn("FIO", System.Type.GetType("System.String")));
            //Настройка видимости полей комбобокса
            comboBox1.DataSource = list_client_table;
            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "ID";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_client_users = "SELECT ID, FIO FROM Clients";
            list_client_command.CommandText = sql_client_users;
            list_client_command.Connection = DB.getConnection();
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
            DB.openConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_comp_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            //Настройка видимости полей комбобокса
            comboBox2.DataSource = list_comp_table;
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "ID";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_comps = "SELECT ID, Name FROM Comps";
            list_comp_command.CommandText = sql_list_comps;
            list_comp_command.Connection = DB.getConnection();
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
        private void addseans(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql_update_current_flight = $"INSERT INTO Seans (route_number, price, departure_station, departure_date, arrival_station, arrival_date, id_state)" +
                    $"VALUES (@User, @Comp, @Start, @Stop, @time, @price)";
                using (MySqlCommand command = new MySqlCommand(sql_update_current_flight, DB.getConnection()))
                {
                    command.Parameters.Add("@User", MySqlDbType.VarChar).Value = comboBox1.SelectedValue.ToString();
                    command.Parameters.Add("@Comp", MySqlDbType.VarChar).Value = comboBox2.SelectedValue.ToString();
                    command.Parameters.Add("@start", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
                    command.Parameters.Add("@stop", MySqlDbType.DateTime).Value = dateTimePicker2.Value;
                    command.Parameters.Add("@time", MySqlDbType.VarChar).Value = textBox1.Text;
                    command.Parameters.Add("@price", MySqlDbType.VarChar).Value = textBox2.Text;
                    DB.openConnection();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Рейс успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Введите данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DB.CloseConnection();
                    }
                }
            }
        }
        public void Calc()
        {
            TimeSpan result = dateTimePicker2.Value - dateTimePicker1.Value;
            textBox2.Text = result.TotalMinutes.ToString();

            string s = textBox2.Text;
            string[] tempArry = textBox2.Text.Split('.');
            textBox2.Text = tempArry[0];
        }
        private void Sum()
        {
            double rub = 0.98;
            int min = Convert.ToInt32(textBox2.Text);
            var result = min * rub;
            textBox1.Text = Convert.ToString(result);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Calc();
            Sum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserList();
            GetCompList();
        }

        private void Seans_Add_Load(object sender, EventArgs e)
        {
            GetUserList();
            GetCompList();
        }
    }
}