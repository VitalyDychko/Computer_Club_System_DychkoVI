using MySql.Data.MySqlClient;
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

namespace Dyczko_ComputerClub_System
{
    public partial class Services_Add : Form
    {
        Database DB = new Database();
        public Services_Add()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string serv = ServiceBox.Text;
            string desk = DescBox.Text;
            int price = Convert.ToInt32(PriceBox.Text);
            try
            {
                DB.OpenConnection();
                string commandStr = $"INSERT INTO Services (Service, Description)" +
                                    $"VALUES ('{serv}','{desk}')";
                string commanda = $"INSERT INTO Prices (Price)" +
                                    $"VALUES ('{price}')";
                using (MySqlCommand cmnd = new MySqlCommand(commandStr, DB.GetConnection()))
                    cmnd.ExecuteNonQuery();
                using (MySqlCommand cmnda = new MySqlCommand(commanda, DB.GetConnection()))
                    cmnda.ExecuteNonQuery();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Services_Add_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
