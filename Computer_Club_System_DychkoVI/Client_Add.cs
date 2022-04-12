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
        public delegate void AddClientDelegate(string fio, string _age, string gen, string num, string mail);
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
                AddClientDelegate ACD = new AddClientDelegate(DB.Add_Client);
                ACD.Invoke(FIOBox.Text, AgeBox.Text, GenBox.Text, NumberBox.Text, EmailBox.Text);
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

        private void GenBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(GenBox.Text))
            {
                string Picture = GenBox.Text;
                switch (Picture)
                {
                    case "Мужской":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.corporate;
                        break;
                    case "Женский":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.girl;
                        break;
                    case "Другой":
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.hacker;
                        break;
                    default:
                        this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.hacker;
                        break;

                }
            }
        }
    }
}
