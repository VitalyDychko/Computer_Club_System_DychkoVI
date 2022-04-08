using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Computer_Club_System_DychkoVI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class ConnDB
    {
        public static MySqlConnection ConnMysqlClient()
        {
            string ConnStr = "server=10.90.12.113;port=33333;user=st_3_19_5;database=is_3_19_st5_KURS;password=54175268;";
            MySqlConnection conn = new MySqlConnection(ConnStr);
            return conn;
        }
    }
}
