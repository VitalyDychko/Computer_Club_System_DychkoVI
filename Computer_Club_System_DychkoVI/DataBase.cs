using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dyczko_ComputerClub_System
{
    public class Database
    {
        public double Rub { get; set; } = 0.98;
        public static MySqlConnection Conn { get => conn; set => conn = value; }
        public static MySqlConnection conn = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_19_5;database=is_3_19_st5_KURS;password=54175268;");
        private static readonly MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private static readonly BindingSource bSource = new BindingSource();
        private static readonly DataSet ds = new DataSet();
        private static readonly DataTable table = new DataTable();

        public void OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return Conn;
        }
        #region Методы добавления
        public void Add_Client(string fio, string _age, string gen, string num, string mail)
        {
            try
            {
                OpenConnection();
                if (int.TryParse(_age, out int age))
                {
                    string commandStr = $"INSERT INTO Clients (FIO, Age, Sex, Number, Email)" +
                        $"VALUES ('{fio}', '{age}','{gen}', '{num}', '{mail}')";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, GetConnection()))
                        cmnd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Add_Worker(string fio, string _age, string gen, string num, string mail, string post)
        {
            try
            {
                OpenConnection();

                if (int.TryParse(_age, out int age))
                {
                    string commandStr = $"INSERT INTO Staff (FIO, Age, Gen, Num, Email, Post)" +
                        $"VALUES ('{fio}', '{age}','{gen}', '{num}', '{mail}', '{post}')";
                    using (MySqlCommand cmnd = new MySqlCommand(commandStr, GetConnection()))
                        cmnd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Add_Comp(string nam, string supp, object type)
        {
            try
            {
                OpenConnection();
                string commandStr = $"INSERT INTO Comps (Name, Supp, Type)" +
                                    $"VALUES ('{nam}', '{supp}','{type}')";
                using (MySqlCommand cmnd = new MySqlCommand(commandStr, GetConnection()))
                    cmnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
        #region Методы редактирования
        public void Edit_Staff(object id, string fio, int age, string gen, string num, string mail, object post)
        {
            //Формируем запрос на изменение
            var changeQuery = $"update Staff set FIO = '{fio}', Age = '{age}', Gen = '{gen}', Num = '{num}', Email = '{mail}', Post = '{post}' where ID = '{id}'";
            // устанавливаем соединение с БД
            OpenConnection();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(changeQuery, GetConnection());
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            CloseConnection();
        }
        public void Edit_Client(object id, string fio, int age, string gen, string num, string mail)
        {
            //Формируем запрос на изменение
            var changeQuery = $"update Clients set FIO = '{fio}', Age = '{age}', Sex = '{gen}', Number = '{num}', Email = '{mail}' where ID = '{id}'";
            // устанавливаем соединение с БД
            OpenConnection();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(changeQuery, GetConnection());
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            CloseConnection();
        }
        public void Edit_Comp(object id, object type,string name, string supp)
        {
            //Формируем запрос на изменение
            var changeQuery = $"update Comps set Name = '{name}', Supp = '{supp}', Type = '{type}' where ID = '{id}'";
            // устанавливаем соединение с БД
            OpenConnection();
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(changeQuery, GetConnection());
            // выполняем запрос
            command.ExecuteNonQuery();
            // закрываем подключение к БД
            CloseConnection();
        }
        #endregion
        public void Universal_Remover(string table, object id)
        {
            // открываем соединение
            OpenConnection();
            // запрос удаления данных
            string query = $"DELETE FROM {table} WHERE (ID='{id}')";
            try
            {
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                // выполняем запрос
                command.ExecuteNonQuery();
                // закрываем подключение к БД
                CloseConnection();
            }
            catch (Exception ex)
            {
                //Если возникла ошибка, то запрос не вставит ни одной строки
                MessageBox.Show($"Произошла ошибка {ex.HResult}");
            }
        }
    }
    static class Auth
    {
        //Статичное поле, которое хранит значение статуса авторизации
        public static bool auth = false;
        //Статичное поле, которое хранит значения ID пользователя
        public static string auth_id = null;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_login = null;
    }
}