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
    public partial class Staff_Edit : Form
    {
        public Staff_Edit()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        readonly Database DB = new Database();
        public delegate void EditStaffDelegate(object id, string fio, int age, string gen, string num, string mail, object post);
        public void SelectWorkerData()
        {
            string selected_ID = IDBox.SelectedValue.ToString();
            DB.OpenConnection();
            string msql = $"SELECT * FROM Staff WHERE ID={selected_ID}";
            MySqlCommand command = new MySqlCommand(msql, DB.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FIOBox.Text = reader[1].ToString();
                AgeBox.Text = (reader[2].ToString());
                GenBox.Text = reader[3].ToString();
                NumBox.Text = reader[4].ToString();
                EmailBox.Text = reader[5].ToString();
                JobBox.Text = reader[6].ToString();
            }
            reader.Close();
            DB.CloseConnection();
        }
        public void GetWorkerList()
        {
            DataTable list_Worker_table = new DataTable();
            MySqlCommand list_Worker_command = new MySqlCommand();
            DB.OpenConnection();
            list_Worker_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_Worker_table.Columns.Add(new DataColumn("FIO", System.Type.GetType("System.String")));
            IDBox.DataSource = list_Worker_table;
            IDBox.DisplayMember = "FIO";
            IDBox.ValueMember = "ID";
            string sql_list_clients = "SELECT ID, FIO FROM Staff";
            list_Worker_command.CommandText = sql_list_clients;
            list_Worker_command.Connection = DB.GetConnection();
            MySqlDataReader list_clients_reader;
            try
            {
                list_clients_reader = list_Worker_command.ExecuteReader();
                while (list_clients_reader.Read())
                {
                    DataRow rowToAdd = list_Worker_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_clients_reader[0]);
                    rowToAdd["FIO"] = list_clients_reader[1].ToString();
                    list_Worker_table.Rows.Add(rowToAdd);
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
        public void GetJobList()
        {
            DataTable list_job_table = new DataTable();
            MySqlCommand list_job_command = new MySqlCommand();
            DB.OpenConnection();
            list_job_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_job_table.Columns.Add(new DataColumn("Job", System.Type.GetType("System.String")));
            JobBox.DataSource = list_job_table;
            JobBox.DisplayMember = "Job";
            JobBox.ValueMember = "Job";
            string sql_list_job = "SELECT ID, Job FROM Job_Categories";
            list_job_command.CommandText = sql_list_job;
            list_job_command.Connection = DB.GetConnection();
            MySqlDataReader list_job_reader;
            try
            {
                list_job_reader = list_job_command.ExecuteReader();
                while (list_job_reader.Read())
                {
                    DataRow rowToAdd = list_job_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_job_reader[0]);
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
        private void BtnChange_Click(object sender, EventArgs e)
        {
            //Определяем значение переменных для записи в БД
            EditStaffDelegate ESD = new EditStaffDelegate(DB.Edit_Staff);
            ESD.Invoke(IDBox.SelectedValue, FIOBox.Text, Convert.ToInt32(AgeBox.Text), GenBox.Text, NumBox.Text, EmailBox.Text, JobBox.SelectedValue);
            //Закрываем форму
            this.Close();
        }

        private void Staff_Edit_Load(object sender, EventArgs e)
        {
            GetJobList();
            GetWorkerList();
            SelectWorkerData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectWorkerData();
        }

        private void JobBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(GenBox.Text))
            {
                string Picture = JobBox.Text;
                switch (Picture)
                {
                    case "Администрация":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.corporate;
                        break;
                    case "Бухгалтерия":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Buhgalter;
                        break;
                    case "Обслуживание":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Worker;
                        break;
                    case "Служба Безопасности":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.police;
                        break;
                    case "Техподдержка и ремонт":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Repairer;
                        break;
                    default:
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.hacker;
                        break;

                }
            }
        }

        private void Staff_Edit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
