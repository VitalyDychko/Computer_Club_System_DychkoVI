using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dyczko_ComputerClub_System
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public class Database
    {
        MySqlConnection conn = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_19_5;database=is_3_19_st5_KURS;password=54175268;");
        //Определяем  поле, которое харнит ID студенты из From10 и выводится в форме Menu
        public static string ID_STUD = "0";
        //DataAdapter представляет собой объект Command , получающий данные из источника данных.
        private static readonly MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных.
        private static readonly BindingSource bSource = new BindingSource();
        //DataSet - расположенное в оперативной памяти представление данных, обеспечивающее согласованную реляционную программную 
        //модель независимо от источника данных.DataSet представляет полный набор данных, включая таблицы, содержащие, упорядочивающие 
        //и ограничивающие данные, а также связи между таблицами.
        private static DataSet ds = new DataSet();
        //Представляет одну таблицу данных в памяти.
        private static DataTable table = new DataTable();

        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return conn;
        }
    }
}