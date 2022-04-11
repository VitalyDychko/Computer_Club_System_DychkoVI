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
    public partial class Client_Add : Form
    {
        Database DB = new Database();
        public Client_Add()
        {
            InitializeComponent();
        }
        private void BtnClear(object sender, EventArgs e)
        {
            FIOBox.Clear();
            AgeBox.Clear();
            NumberBox.Clear();
            EmailBox.Clear();
        }
        private void BtnAddClient(object sender, EventArgs e)
        {
            if (FIOBox.TextLength != 0 || AgeBox.TextLength != 0 || NumberBox.TextLength != 0 || EmailBox.TextLength != 0)
            {
                DB.Add_Client(FIOBox.Text, AgeBox.Text, GenBox.Text, NumberBox.Text, EmailBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
