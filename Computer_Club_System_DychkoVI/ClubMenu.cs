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
    public partial class ClubMenu : Form
    {
        //Поля
        private Button currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form activeForm;
        //Конструктор
        public ClubMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Методы
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            pictureBox1.Visible = false;
            btnDczk.Visible = false;
            label1.Visible = false;
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void BtnSotr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff(), sender);
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clients(), sender);
        }

        private void BtnComp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Comps(), sender);
        }

        private void BtnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "ДОМАШНЯЯ СТРАНИЦА";
            panelTitleBar.BackColor = Color.FromArgb(16, 16, 24);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            pictureBox1.Visible = true;
            btnDczk.Visible = true;
            label1.Visible = true;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void BtnAuth_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserList(), sender);
        }

        private void BtnSeans_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seans(), sender);
        }

        private void BtnLicenses_Click(object sender, EventArgs e)
        {
            Information Info = new Information();
            Info.ShowDialog();
        }

        private void btnDczk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/vitdczk");
        }

        private void BtnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMax(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void BtnMin(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnBonus_Click(object sender, EventArgs e)
        {
            FunctMenu FM = new FunctMenu();
            FM.Show();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
