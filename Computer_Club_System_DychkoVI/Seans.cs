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
    public partial class Seans : Form
    {
        public Seans()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seans_Add SA = new Seans_Add();
            SA.ShowDialog();
        }
    }
}
