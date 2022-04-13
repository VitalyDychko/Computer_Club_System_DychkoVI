
namespace Dyczko_ComputerClub_System
{
    partial class Comps_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comps_Add));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TypeBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuppBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.NameBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 205);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(317, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 205);
            this.panel2.TabIndex = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Comp;
            this.pictureBox2.Location = new System.Drawing.Point(0, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Comps_Add_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 55);
            this.label1.TabIndex = 60;
            this.label1.Text = "Добавление нового компьютера\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Comps_Add_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(0, 167);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(200, 38);
            this.BtnClose.TabIndex = 56;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TypeBox);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.SuppBox);
            this.panel3.Controls.Add(this.NameBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 205);
            this.panel3.TabIndex = 63;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Comps_Add_MouseDown);
            // 
            // TypeBox
            // 
            this.TypeBox.BackColor = System.Drawing.Color.Transparent;
            this.TypeBox.BackgroundColor = System.Drawing.Color.White;
            this.TypeBox.BorderColor = System.Drawing.Color.Silver;
            this.TypeBox.BorderRadius = 5;
            this.TypeBox.Color = System.Drawing.Color.Silver;
            this.TypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.TypeBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TypeBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TypeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TypeBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TypeBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.TypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TypeBox.FillDropDown = true;
            this.TypeBox.FillIndicator = false;
            this.TypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TypeBox.ForeColor = System.Drawing.Color.Black;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Icon = null;
            this.TypeBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TypeBox.IndicatorColor = System.Drawing.Color.Gray;
            this.TypeBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TypeBox.ItemBackColor = System.Drawing.Color.White;
            this.TypeBox.ItemBorderColor = System.Drawing.Color.White;
            this.TypeBox.ItemForeColor = System.Drawing.Color.Black;
            this.TypeBox.ItemHeight = 26;
            this.TypeBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.TypeBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.TypeBox.ItemTopMargin = 3;
            this.TypeBox.Location = new System.Drawing.Point(11, 109);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(298, 32);
            this.TypeBox.TabIndex = 65;
            this.TypeBox.Text = null;
            this.TypeBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TypeBox.TextLeftMargin = 5;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(0, 165);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(316, 38);
            this.BtnAdd.TabIndex = 58;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // SuppBox
            // 
            this.SuppBox.AcceptsReturn = false;
            this.SuppBox.AcceptsTab = false;
            this.SuppBox.AnimationSpeed = 200;
            this.SuppBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SuppBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SuppBox.BackColor = System.Drawing.Color.Transparent;
            this.SuppBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SuppBox.BackgroundImage")));
            this.SuppBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SuppBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SuppBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SuppBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SuppBox.BorderRadius = 5;
            this.SuppBox.BorderThickness = 1;
            this.SuppBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SuppBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SuppBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SuppBox.DefaultText = "";
            this.SuppBox.FillColor = System.Drawing.Color.White;
            this.SuppBox.HideSelection = true;
            this.SuppBox.IconLeft = null;
            this.SuppBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SuppBox.IconPadding = 10;
            this.SuppBox.IconRight = null;
            this.SuppBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SuppBox.Lines = new string[0];
            this.SuppBox.Location = new System.Drawing.Point(11, 55);
            this.SuppBox.MaxLength = 32767;
            this.SuppBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SuppBox.Modified = false;
            this.SuppBox.Multiline = false;
            this.SuppBox.Name = "SuppBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SuppBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SuppBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SuppBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SuppBox.OnIdleState = stateProperties4;
            this.SuppBox.Padding = new System.Windows.Forms.Padding(3);
            this.SuppBox.PasswordChar = '\0';
            this.SuppBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SuppBox.PlaceholderText = "Поставщик";
            this.SuppBox.ReadOnly = false;
            this.SuppBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SuppBox.SelectedText = "";
            this.SuppBox.SelectionLength = 0;
            this.SuppBox.SelectionStart = 0;
            this.SuppBox.ShortcutsEnabled = true;
            this.SuppBox.Size = new System.Drawing.Size(298, 38);
            this.SuppBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SuppBox.TabIndex = 64;
            this.SuppBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SuppBox.TextMarginBottom = 0;
            this.SuppBox.TextMarginLeft = 3;
            this.SuppBox.TextMarginTop = 0;
            this.SuppBox.TextPlaceholder = "Поставщик";
            this.SuppBox.UseSystemPasswordChar = false;
            this.SuppBox.WordWrap = true;
            // 
            // NameBox
            // 
            this.NameBox.AcceptsReturn = false;
            this.NameBox.AcceptsTab = false;
            this.NameBox.AnimationSpeed = 200;
            this.NameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameBox.BackColor = System.Drawing.Color.Transparent;
            this.NameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NameBox.BackgroundImage")));
            this.NameBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.NameBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NameBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.NameBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.NameBox.BorderRadius = 5;
            this.NameBox.BorderThickness = 1;
            this.NameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NameBox.DefaultText = "";
            this.NameBox.FillColor = System.Drawing.Color.White;
            this.NameBox.HideSelection = true;
            this.NameBox.IconLeft = null;
            this.NameBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.IconPadding = 10;
            this.NameBox.IconRight = null;
            this.NameBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.Lines = new string[0];
            this.NameBox.Location = new System.Drawing.Point(11, 11);
            this.NameBox.MaxLength = 32767;
            this.NameBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.NameBox.Modified = false;
            this.NameBox.Multiline = false;
            this.NameBox.Name = "NameBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NameBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.NameBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NameBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.NameBox.OnIdleState = stateProperties8;
            this.NameBox.Padding = new System.Windows.Forms.Padding(3);
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.NameBox.PlaceholderText = "Название";
            this.NameBox.ReadOnly = false;
            this.NameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameBox.SelectedText = "";
            this.NameBox.SelectionLength = 0;
            this.NameBox.SelectionStart = 0;
            this.NameBox.ShortcutsEnabled = true;
            this.NameBox.Size = new System.Drawing.Size(298, 38);
            this.NameBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.NameBox.TabIndex = 63;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameBox.TextMarginBottom = 0;
            this.NameBox.TextMarginLeft = 3;
            this.NameBox.TextMarginTop = 0;
            this.NameBox.TextPlaceholder = "Название";
            this.NameBox.UseSystemPasswordChar = false;
            this.NameBox.WordWrap = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Comps_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 205);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comps_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Comps_Add_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Comps_Add_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAdd;
        private Bunifu.UI.WinForms.BunifuDropdown TypeBox;
        private Bunifu.UI.WinForms.BunifuTextBox SuppBox;
        private System.Windows.Forms.Button BtnClose;
        private Bunifu.UI.WinForms.BunifuTextBox NameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}