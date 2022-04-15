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
    public partial class Comps_Add : Form
    {
        Database DB = new Database();
        public delegate void AddCompDelegate(string nam, string supp, object type);
        public Comps_Add()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void GetTypeList()
        {
            DataTable list_of_table = new DataTable();
            MySqlCommand list_command = new MySqlCommand();
            DB.OpenConnection();
            list_of_table.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            list_of_table.Columns.Add(new DataColumn("Type", System.Type.GetType("System.String")));
            TypeBox.DataSource = list_of_table;
            TypeBox.DisplayMember = "Type";
            TypeBox.ValueMember = "Type";
            string sql_list = "SELECT ID, Type FROM Devices_Categories";
            list_command.CommandText = sql_list;
            list_command.Connection = DB.GetConnection();
            MySqlDataReader list_reader;
            try
            {
                list_reader = list_command.ExecuteReader();
                while (list_reader.Read())
                {
                    DataRow rowToAdd = list_of_table.NewRow();
                    rowToAdd["ID"] = Convert.ToInt32(list_reader[0]);
                    rowToAdd["Type"] = list_reader[1].ToString();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (NameBox.TextLength != 0 || SuppBox.TextLength != 0)
            {
                AddCompDelegate ACD = new AddCompDelegate(DB.Add_Comp);
                ACD.Invoke(NameBox.Text, SuppBox.Text, TypeBox.SelectedValue);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }
        }

        private void Comps_Add_Load(object sender, EventArgs e)
        {
            GetTypeList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TypeBox.Text))
            {
                string Picture = TypeBox.Text;
                switch (Picture)
                {
                    case "Игровой компьютер":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Comp;
                        break;
                    case "Playstation":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.PS;
                        break;
                    case "Xbox":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Xbox;
                        break;
                    case "Другое устройство":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.laptop;
                        break;
                    default:
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.premium_icon_light_saber_922809;
                        break;

                }
            }
        }

        private void Comps_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
