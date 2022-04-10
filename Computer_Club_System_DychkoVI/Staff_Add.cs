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
    public partial class Staff_Add : Form
    {
        Database DB = new Database();
        public Staff_Add()
        {
            InitializeComponent();
        }
        public void GetJobList()
        {
            DataTable list_job_table = new DataTable();
            MySqlCommand list_job_command = new MySqlCommand();
            DB.openConnection();
            list_job_table.Columns.Add(new DataColumn("ID_cat", System.Type.GetType("System.Int32")));
            list_job_table.Columns.Add(new DataColumn("Job", System.Type.GetType("System.String")));
            JobBox.DataSource = list_job_table;
            JobBox.DisplayMember = "Job";
            JobBox.ValueMember = "ID_cat";
            string sql_list_job = "SELECT ID_cat, Job FROM Job_Categories";
            list_job_command.CommandText = sql_list_job;
            list_job_command.Connection = DB.getConnection();
            MySqlDataReader list_job_reader;
            try
            {
                list_job_reader = list_job_command.ExecuteReader();
                while (list_job_reader.Read())
                {
                    DataRow rowToAdd = list_job_table.NewRow();
                    rowToAdd["ID_cat"] = Convert.ToInt32(list_job_reader[0]);
                    rowToAdd["Job"] = list_job_reader[1].ToString();
                    list_job_table.Rows.Add(rowToAdd);
                }
                list_job_reader.Close();
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
        private void AddWorker(object sender, EventArgs e)
        {
            if (FIOBox.TextLength != 0 || AgeBox.TextLength != 0 || NumberBox.TextLength != 0 || EmailBox.TextLength != 0)
            {
                try
                {
                    DB.openConnection();

                    var fio = FIOBox.Text;
                    int age;
                    var num = NumberBox.Text;
                    var mail = EmailBox.Text;
                    var gen = GenBox.Text;
                    var post = JobBox.Text;
                    if (int.TryParse(AgeBox.Text, out age))
                    {
                        string commandStr = $"INSERT INTO Staff (FIO, Age, Gen, Num, Email, Post)" +
                            $"VALUES ('{fio}', '{age}','{gen}', '{num}', '{mail}', '{post}')";
                        using (MySqlCommand cmnd = new MySqlCommand(commandStr, DB.getConnection()))
                            cmnd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    DB.CloseConnection();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }
        }

        private void BtnClear(object sender, EventArgs e)
        {
            FIOBox.Clear();
            AgeBox.Clear();
            NumberBox.Clear();
            EmailBox.Clear();
        }

        private void BtnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Add_Load(object sender, EventArgs e)
        {
            GetJobList();
        }
    }
}
