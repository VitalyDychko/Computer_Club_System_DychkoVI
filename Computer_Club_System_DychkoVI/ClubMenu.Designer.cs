
namespace Dyczko_ComputerClub_System
{
    partial class ClubMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClubMenu));
            this.panelforbuttons = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtnForLeave = new System.Windows.Forms.Button();
            this.btnforMin = new System.Windows.Forms.Button();
            this.btnforMax = new System.Windows.Forms.Button();
            this.btnforClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBonus = new System.Windows.Forms.Button();
            this.BtnAuth = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnSetup = new System.Windows.Forms.Button();
            this.BtnComp = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnSotr = new System.Windows.Forms.Button();
            this.panelforbuttons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelforbuttons
            // 
            this.panelforbuttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelforbuttons.Controls.Add(this.BtnBonus);
            this.panelforbuttons.Controls.Add(this.BtnAuth);
            this.panelforbuttons.Controls.Add(this.BtnInfo);
            this.panelforbuttons.Controls.Add(this.BtnSetup);
            this.panelforbuttons.Controls.Add(this.BtnComp);
            this.panelforbuttons.Controls.Add(this.BtnClients);
            this.panelforbuttons.Controls.Add(this.BtnSotr);
            this.panelforbuttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelforbuttons.Location = new System.Drawing.Point(0, 36);
            this.panelforbuttons.Name = "panelforbuttons";
            this.panelforbuttons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelforbuttons.Size = new System.Drawing.Size(924, 41);
            this.panelforbuttons.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.lblTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(241, 36);
            this.panelLogo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ДОМАШНЯЯ СТРАНИЦА";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.BtnForLeave);
            this.panelTitleBar.Controls.Add(this.btnforMin);
            this.panelTitleBar.Controls.Add(this.btnforMax);
            this.panelTitleBar.Controls.Add(this.btnforClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.panelLogo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(924, 36);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // BtnForLeave
            // 
            this.BtnForLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnForLeave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnForLeave.FlatAppearance.BorderSize = 0;
            this.BtnForLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForLeave.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnForLeave.Location = new System.Drawing.Point(736, 0);
            this.BtnForLeave.Name = "BtnForLeave";
            this.BtnForLeave.Size = new System.Drawing.Size(47, 36);
            this.BtnForLeave.TabIndex = 5;
            this.BtnForLeave.Text = "🚪";
            this.BtnForLeave.UseVisualStyleBackColor = true;
            this.BtnForLeave.Click += new System.EventHandler(this.BtnForLeave_Click);
            // 
            // btnforMin
            // 
            this.btnforMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnforMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnforMin.FlatAppearance.BorderSize = 0;
            this.btnforMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforMin.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnforMin.Location = new System.Drawing.Point(783, 0);
            this.btnforMin.Name = "btnforMin";
            this.btnforMin.Size = new System.Drawing.Size(47, 36);
            this.btnforMin.TabIndex = 4;
            this.btnforMin.Text = "–";
            this.btnforMin.UseVisualStyleBackColor = true;
            this.btnforMin.Click += new System.EventHandler(this.BtnMin);
            // 
            // btnforMax
            // 
            this.btnforMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnforMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnforMax.FlatAppearance.BorderSize = 0;
            this.btnforMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforMax.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnforMax.Location = new System.Drawing.Point(830, 0);
            this.btnforMax.Name = "btnforMax";
            this.btnforMax.Size = new System.Drawing.Size(47, 36);
            this.btnforMax.TabIndex = 3;
            this.btnforMax.Text = "◳\t";
            this.btnforMax.UseVisualStyleBackColor = true;
            this.btnforMax.Click += new System.EventHandler(this.BtnMax);
            // 
            // btnforClose
            // 
            this.btnforClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnforClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnforClose.FlatAppearance.BorderSize = 0;
            this.btnforClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforClose.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnforClose.Location = new System.Drawing.Point(877, 0);
            this.btnforClose.Name = "btnforClose";
            this.btnforClose.Size = new System.Drawing.Size(47, 36);
            this.btnforClose.TabIndex = 2;
            this.btnforClose.Text = "x";
            this.btnforClose.UseVisualStyleBackColor = true;
            this.btnforClose.Click += new System.EventHandler(this.BtnClose);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseChildForm.Location = new System.Drawing.Point(241, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(74, 36);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "↑";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.panel2);
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(924, 553);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 476);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panelforbuttons);
            this.panel1.Controls.Add(this.panelTitleBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 77);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBonus
            // 
            this.BtnBonus.AutoSize = true;
            this.BtnBonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnBonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBonus.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBonus.FlatAppearance.BorderSize = 0;
            this.BtnBonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBonus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBonus.ForeColor = System.Drawing.Color.White;
            this.BtnBonus.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0computer;
            this.BtnBonus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBonus.Location = new System.Drawing.Point(785, 0);
            this.BtnBonus.Name = "BtnBonus";
            this.BtnBonus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnBonus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnBonus.Size = new System.Drawing.Size(119, 41);
            this.BtnBonus.TabIndex = 9;
            this.BtnBonus.Text = "Функции";
            this.BtnBonus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBonus.UseVisualStyleBackColor = false;
            this.BtnBonus.Click += new System.EventHandler(this.BtnBonus_Click);
            // 
            // BtnAuth
            // 
            this.BtnAuth.AutoSize = true;
            this.BtnAuth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAuth.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAuth.FlatAppearance.BorderSize = 0;
            this.BtnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAuth.ForeColor = System.Drawing.Color.White;
            this.BtnAuth.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0profile;
            this.BtnAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAuth.Location = new System.Drawing.Point(628, 0);
            this.BtnAuth.Name = "BtnAuth";
            this.BtnAuth.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAuth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAuth.Size = new System.Drawing.Size(157, 41);
            this.BtnAuth.TabIndex = 8;
            this.BtnAuth.Text = "Пользователи";
            this.BtnAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAuth.UseVisualStyleBackColor = false;
            this.BtnAuth.Click += new System.EventHandler(this.BtnAuth_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.AutoSize = true;
            this.BtnInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0file;
            this.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.Location = new System.Drawing.Point(527, 0);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnInfo.Size = new System.Drawing.Size(101, 41);
            this.BtnInfo.TabIndex = 7;
            this.BtnInfo.Text = "Инфо";
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnLicenses_Click);
            // 
            // BtnSetup
            // 
            this.BtnSetup.AutoSize = true;
            this.BtnSetup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetup.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSetup.FlatAppearance.BorderSize = 0;
            this.BtnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSetup.ForeColor = System.Drawing.Color.White;
            this.BtnSetup.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0drink;
            this.BtnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetup.Location = new System.Drawing.Point(417, 0);
            this.BtnSetup.Name = "BtnSetup";
            this.BtnSetup.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSetup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSetup.Size = new System.Drawing.Size(110, 41);
            this.BtnSetup.TabIndex = 4;
            this.BtnSetup.Text = "Заказы";
            this.BtnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSetup.UseVisualStyleBackColor = false;
            this.BtnSetup.Click += new System.EventHandler(this.BtnSeans_Click);
            // 
            // BtnComp
            // 
            this.BtnComp.AutoSize = true;
            this.BtnComp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComp.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnComp.FlatAppearance.BorderSize = 0;
            this.BtnComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComp.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnComp.ForeColor = System.Drawing.Color.White;
            this.BtnComp.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0comp;
            this.BtnComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComp.Location = new System.Drawing.Point(264, 0);
            this.BtnComp.Name = "BtnComp";
            this.BtnComp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnComp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnComp.Size = new System.Drawing.Size(153, 41);
            this.BtnComp.TabIndex = 3;
            this.BtnComp.Text = "Компьютеры\r\n";
            this.BtnComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnComp.UseVisualStyleBackColor = false;
            this.BtnComp.Click += new System.EventHandler(this.BtnComp_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.AutoSize = true;
            this.BtnClients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClients.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClients.ForeColor = System.Drawing.Color.White;
            this.BtnClients.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0hackerman;
            this.BtnClients.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnClients.Location = new System.Drawing.Point(144, 0);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnClients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClients.Size = new System.Drawing.Size(120, 41);
            this.BtnClients.TabIndex = 2;
            this.BtnClients.Text = "Клиенты";
            this.BtnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClients.UseVisualStyleBackColor = false;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnSotr
            // 
            this.BtnSotr.AutoSize = true;
            this.BtnSotr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSotr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnSotr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSotr.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSotr.FlatAppearance.BorderSize = 0;
            this.BtnSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSotr.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSotr.ForeColor = System.Drawing.Color.White;
            this.BtnSotr.Image = global::Dyczko_ComputerClub_System.Properties.Resources._0man;
            this.BtnSotr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSotr.Location = new System.Drawing.Point(0, 0);
            this.BtnSotr.Name = "BtnSotr";
            this.BtnSotr.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSotr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSotr.Size = new System.Drawing.Size(144, 41);
            this.BtnSotr.TabIndex = 1;
            this.BtnSotr.Text = "Сотрудники";
            this.BtnSotr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSotr.UseVisualStyleBackColor = false;
            this.BtnSotr.Click += new System.EventHandler(this.BtnSotr_Click);
            // 
            // ClubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.panelDesktopPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютерный клуб";
            this.panelforbuttons.ResumeLayout(false);
            this.panelforbuttons.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelforbuttons;
        private System.Windows.Forms.Button BtnSotr;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button BtnComp;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSetup;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnAuth;
        private System.Windows.Forms.Button btnforMin;
        private System.Windows.Forms.Button btnforMax;
        private System.Windows.Forms.Button btnforClose;
        private System.Windows.Forms.Button BtnBonus;
        private System.Windows.Forms.Button BtnForLeave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

