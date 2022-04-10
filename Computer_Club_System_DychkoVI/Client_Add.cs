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
                try
                {
                    DB.openConnection();

                    var fio = FIOBox.Text;
                    int age;
                    var num = NumberBox.Text;
                    var mail = EmailBox.Text;
                    var gen = GenBox.Text;
                    if(int.TryParse(AgeBox.Text, out age))
                    {
                         string commandStr = $"INSERT INTO Clients (FIO, Age, Sex, Number, Email)" +
                             $"VALUES ('{fio}', '{age}','{gen}', '{num}', '{mail}')";
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

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
