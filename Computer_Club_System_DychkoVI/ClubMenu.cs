using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
                    currentButton.BackColor = Color.Gold;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTitle.BackColor = color;
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelforbuttons.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            pictureBox1.Visible = false;
            panel3.Visible = false;
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
            panelTitleBar.BackColor = Color.Black;
            lblTitle.BackColor = Color.Black;
            pictureBox1.Visible = true;
            panel3.Visible = true;
            currentButton = null;
            btnCloseChildForm.Visible = false;
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
        private void BtnAuth_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserList(), sender);
        }
        private void BtnSeans_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seans(), sender);
        }
        private void Servicesbtn(object sender, EventArgs e)
        {
            OpenChildForm(new Services(), sender);
        }
        private void BtnLicenses_Click(object sender, EventArgs e)
        {
            Information Info = new Information();
            Info.ShowDialog();
        }
        private void BtnBonus_Click(object sender, EventArgs e)
        {
            FunctMenu FM = new FunctMenu();
            FM.Show();
        }
        private void AddStaff_Click(object sender, EventArgs e)
        {
            Staff_Add STAD = new Staff_Add();
            STAD.ShowDialog();
        }
        private void AddClient_Click(object sender, EventArgs e)
        {
            Client_Add CTAD = new Client_Add();
            CTAD.ShowDialog();
        }
        private void BtnDeleter_Click(object sender, EventArgs e)
        {
            Deleter deleter = new Deleter();
            deleter.ShowDialog();
        }
        private void AddComp_Click(object sender, EventArgs e)
        {
            Comps_Add CSAD = new Comps_Add();
            CSAD.ShowDialog();
        }
        private void AddSeans_Click(object sender, EventArgs e)
        {
            Seans_Add SANS = new Seans_Add();
            SANS.ShowDialog();
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
        private void ClubMenu_Load(object sender, EventArgs e)
        {
            Loginlabel.Text = Auth.auth_login;
        }
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnForLeave_Click(object sender, EventArgs e)
        {
            Auth.auth = false;
            Auth.auth_id = null;
            Auth.auth_login = null;
            this.Close();
            new Thread(() => Application.Run(new Login())).Start();
        }
    }
}
