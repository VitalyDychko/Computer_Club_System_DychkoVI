using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyczko_ComputerClub_System
{
    public partial class FunctMenu : Form
    {
        public FunctMenu()
        {
            InitializeComponent();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            Client_Add CLAD = new Client_Add();
            CLAD.ShowDialog();
        }

        private void RedClient_Click(object sender, EventArgs e)
        {
            Client_Edit CLED = new Client_Edit();
            CLED.ShowDialog();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Staff_Add SA = new Staff_Add();
            SA.ShowDialog();
        }

        private void RedactEmploye_Click(object sender, EventArgs e)
        {
            Staff_Edit SE = new Staff_Edit();
            SE.ShowDialog();
        }

        private void AddComp_Click(object sender, EventArgs e)
        {
            Comps_Add CAD = new Comps_Add();
            CAD.ShowDialog();
        }

        private void RedComp_Click(object sender, EventArgs e)
        {
            Comps_Edit CED = new Comps_Edit();
            CED.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            User_Add USA = new User_Add();
            USA.ShowDialog();
        }

        private void RedUser_Click(object sender, EventArgs e)
        {
            User_Edit USE = new User_Edit();
            USE.ShowDialog();
        }

        private void AddSeans_Click(object sender, EventArgs e)
        {
            Seans_Add SAD = new Seans_Add();
            SAD.ShowDialog();
        }
    }
}
