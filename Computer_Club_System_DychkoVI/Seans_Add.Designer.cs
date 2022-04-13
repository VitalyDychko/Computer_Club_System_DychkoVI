
namespace Dyczko_ComputerClub_System
{
    partial class Seans_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seans_Add));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ClientBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.CompBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dateTimePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.PriceBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.MinuteBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 257);
            this.panel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BtnClose);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(318, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 257);
            this.panel3.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 63);
            this.label1.TabIndex = 60;
            this.label1.Text = "Добавление нового сеанса";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Seans_Add_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Red;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(0, 224);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(207, 33);
            this.BtnClose.TabIndex = 63;
            this.BtnClose.Text = "Закрыть форму";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.code;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Seans_Add_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel6.Controls.Add(this.BtnAdd);
            this.panel6.Controls.Add(this.ClientBox);
            this.panel6.Controls.Add(this.CompBox);
            this.panel6.Controls.Add(this.dateTimePicker2);
            this.panel6.Controls.Add(this.PriceBox);
            this.panel6.Controls.Add(this.MinuteBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 257);
            this.panel6.TabIndex = 63;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Seans_Add_MouseDown);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(0, 224);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(318, 33);
            this.BtnAdd.TabIndex = 65;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.Addseans);
            // 
            // ClientBox
            // 
            this.ClientBox.BackColor = System.Drawing.Color.Transparent;
            this.ClientBox.BackgroundColor = System.Drawing.Color.White;
            this.ClientBox.BorderColor = System.Drawing.Color.Silver;
            this.ClientBox.BorderRadius = 5;
            this.ClientBox.Color = System.Drawing.Color.Silver;
            this.ClientBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ClientBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ClientBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ClientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ClientBox.FillDropDown = true;
            this.ClientBox.FillIndicator = false;
            this.ClientBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientBox.ForeColor = System.Drawing.Color.Black;
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Icon = null;
            this.ClientBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ClientBox.IndicatorColor = System.Drawing.Color.Gray;
            this.ClientBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ClientBox.ItemBackColor = System.Drawing.Color.White;
            this.ClientBox.ItemBorderColor = System.Drawing.Color.White;
            this.ClientBox.ItemForeColor = System.Drawing.Color.Black;
            this.ClientBox.ItemHeight = 26;
            this.ClientBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ClientBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ClientBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.ClientBox.ItemTopMargin = 3;
            this.ClientBox.Location = new System.Drawing.Point(11, 56);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(301, 32);
            this.ClientBox.TabIndex = 78;
            this.ClientBox.Text = null;
            this.ClientBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ClientBox.TextLeftMargin = 5;
            // 
            // CompBox
            // 
            this.CompBox.BackColor = System.Drawing.Color.Transparent;
            this.CompBox.BackgroundColor = System.Drawing.Color.White;
            this.CompBox.BorderColor = System.Drawing.Color.Silver;
            this.CompBox.BorderRadius = 5;
            this.CompBox.Color = System.Drawing.Color.Silver;
            this.CompBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.CompBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CompBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CompBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.CompBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CompBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.CompBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CompBox.FillDropDown = true;
            this.CompBox.FillIndicator = false;
            this.CompBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CompBox.ForeColor = System.Drawing.Color.Black;
            this.CompBox.FormattingEnabled = true;
            this.CompBox.Icon = null;
            this.CompBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CompBox.IndicatorColor = System.Drawing.Color.Gray;
            this.CompBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.CompBox.ItemBackColor = System.Drawing.Color.White;
            this.CompBox.ItemBorderColor = System.Drawing.Color.White;
            this.CompBox.ItemForeColor = System.Drawing.Color.Black;
            this.CompBox.ItemHeight = 26;
            this.CompBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.CompBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.CompBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.CompBox.ItemTopMargin = 3;
            this.CompBox.Location = new System.Drawing.Point(12, 12);
            this.CompBox.Name = "CompBox";
            this.CompBox.Size = new System.Drawing.Size(301, 32);
            this.CompBox.TabIndex = 77;
            this.CompBox.Text = null;
            this.CompBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.CompBox.TextLeftMargin = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker2.BorderRadius = 5;
            this.dateTimePicker2.Color = System.Drawing.Color.Yellow;
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.CustomFormat = "dd:MM:yyyy hh:mm:ss tt";
            this.dateTimePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateTimePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateTimePicker2.DisabledColor = System.Drawing.Color.Gray;
            this.dateTimePicker2.DisplayWeekNumbers = false;
            this.dateTimePicker2.DPHeight = 0;
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.FillDatePicker = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker2.ForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("dateTimePicker2.Icon")));
            this.dateTimePicker2.IconColor = System.Drawing.Color.Yellow;
            this.dateTimePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateTimePicker2.LeftTextMargin = 5;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 94);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(302, 32);
            this.dateTimePicker2.TabIndex = 72;
            // 
            // PriceBox
            // 
            this.PriceBox.AcceptsReturn = false;
            this.PriceBox.AcceptsTab = false;
            this.PriceBox.AnimationSpeed = 200;
            this.PriceBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PriceBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PriceBox.BackColor = System.Drawing.Color.Transparent;
            this.PriceBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PriceBox.BackgroundImage")));
            this.PriceBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PriceBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PriceBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PriceBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.PriceBox.BorderRadius = 5;
            this.PriceBox.BorderThickness = 1;
            this.PriceBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PriceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PriceBox.DefaultText = "";
            this.PriceBox.FillColor = System.Drawing.Color.White;
            this.PriceBox.HideSelection = true;
            this.PriceBox.IconLeft = null;
            this.PriceBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBox.IconPadding = 10;
            this.PriceBox.IconRight = null;
            this.PriceBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceBox.Lines = new string[0];
            this.PriceBox.Location = new System.Drawing.Point(14, 176);
            this.PriceBox.MaxLength = 32767;
            this.PriceBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PriceBox.Modified = false;
            this.PriceBox.Multiline = false;
            this.PriceBox.Name = "PriceBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PriceBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PriceBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PriceBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PriceBox.OnIdleState = stateProperties4;
            this.PriceBox.Padding = new System.Windows.Forms.Padding(3);
            this.PriceBox.PasswordChar = '\0';
            this.PriceBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PriceBox.PlaceholderText = "Стоимость";
            this.PriceBox.ReadOnly = false;
            this.PriceBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PriceBox.SelectedText = "";
            this.PriceBox.SelectionLength = 0;
            this.PriceBox.SelectionStart = 0;
            this.PriceBox.ShortcutsEnabled = true;
            this.PriceBox.Size = new System.Drawing.Size(299, 38);
            this.PriceBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PriceBox.TabIndex = 76;
            this.PriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PriceBox.TextMarginBottom = 0;
            this.PriceBox.TextMarginLeft = 3;
            this.PriceBox.TextMarginTop = 0;
            this.PriceBox.TextPlaceholder = "Стоимость";
            this.PriceBox.UseSystemPasswordChar = false;
            this.PriceBox.WordWrap = true;
            // 
            // MinuteBox
            // 
            this.MinuteBox.AcceptsReturn = false;
            this.MinuteBox.AcceptsTab = false;
            this.MinuteBox.AnimationSpeed = 200;
            this.MinuteBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MinuteBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MinuteBox.BackColor = System.Drawing.Color.Transparent;
            this.MinuteBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinuteBox.BackgroundImage")));
            this.MinuteBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.MinuteBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MinuteBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.MinuteBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.MinuteBox.BorderRadius = 5;
            this.MinuteBox.BorderThickness = 1;
            this.MinuteBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MinuteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinuteBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MinuteBox.DefaultText = "";
            this.MinuteBox.FillColor = System.Drawing.Color.White;
            this.MinuteBox.HideSelection = true;
            this.MinuteBox.IconLeft = null;
            this.MinuteBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.MinuteBox.IconPadding = 10;
            this.MinuteBox.IconRight = null;
            this.MinuteBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.MinuteBox.Lines = new string[0];
            this.MinuteBox.Location = new System.Drawing.Point(14, 132);
            this.MinuteBox.MaxLength = 32767;
            this.MinuteBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.MinuteBox.Modified = false;
            this.MinuteBox.Multiline = false;
            this.MinuteBox.Name = "MinuteBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MinuteBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MinuteBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MinuteBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.MinuteBox.OnIdleState = stateProperties8;
            this.MinuteBox.Padding = new System.Windows.Forms.Padding(3);
            this.MinuteBox.PasswordChar = '\0';
            this.MinuteBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.MinuteBox.PlaceholderText = "Количество минут";
            this.MinuteBox.ReadOnly = false;
            this.MinuteBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MinuteBox.SelectedText = "";
            this.MinuteBox.SelectionLength = 0;
            this.MinuteBox.SelectionStart = 0;
            this.MinuteBox.ShortcutsEnabled = true;
            this.MinuteBox.Size = new System.Drawing.Size(299, 38);
            this.MinuteBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.MinuteBox.TabIndex = 75;
            this.MinuteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MinuteBox.TextMarginBottom = 0;
            this.MinuteBox.TextMarginLeft = 3;
            this.MinuteBox.TextMarginTop = 0;
            this.MinuteBox.TextPlaceholder = "Количество минут";
            this.MinuteBox.UseSystemPasswordChar = false;
            this.MinuteBox.WordWrap = true;
            this.MinuteBox.TextChanged += new System.EventHandler(this.MinuteBox_TextChanged_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Seans_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 257);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seans_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Seans_Add_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Seans_Add_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.UI.WinForms.BunifuDatePicker dateTimePicker2;
        private Bunifu.UI.WinForms.BunifuTextBox PriceBox;
        private Bunifu.UI.WinForms.BunifuTextBox MinuteBox;
        private Bunifu.UI.WinForms.BunifuDropdown ClientBox;
        private Bunifu.UI.WinForms.BunifuDropdown CompBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}