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
    public partial class Staff_Add : Form
    {
        readonly Database DB = new Database();
        public delegate void AddStaffDelegate(string fio, string _age, string gen, string num, string mail, string post);
        public Staff_Add()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void GetJobList()
        {
            DataTable list_job_table = new DataTable();
            MySqlCommand list_job_command = new MySqlCommand();
            DB.OpenConnection();
            list_job_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_job_table.Columns.Add(new DataColumn("Job", System.Type.GetType("System.String")));
            JobBox.DataSource = list_job_table;
            JobBox.DisplayMember = "Job";
            JobBox.ValueMember = "ID";
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
        private void AddWorker(object sender, EventArgs e)
        {
            if (FIOBox.TextLength != 0 || AgeBox.TextLength != 0 || NumberBox.TextLength != 0 || EmailBox.TextLength != 0)
            {
                AddStaffDelegate ASD = new AddStaffDelegate(DB.Add_Worker);
                ASD.Invoke(FIOBox.Text, AgeBox.Text, GenBox.Text, NumberBox.Text, EmailBox.Text, JobBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }

        private void BtnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Add_Load(object sender, EventArgs e)
        {
            GetJobList();
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

        private void Staff_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
