
namespace Dyczko_ComputerClub_System
{
    partial class Deleter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TableBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TableBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 55);
            this.panel4.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Выберите таблицу, из которой надо удалить данные";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Deleter_MouseDown);
            // 
            // TableBox
            // 
            this.TableBox.BackColor = System.Drawing.Color.Transparent;
            this.TableBox.BackgroundColor = System.Drawing.Color.White;
            this.TableBox.BorderColor = System.Drawing.Color.Silver;
            this.TableBox.BorderRadius = 1;
            this.TableBox.Color = System.Drawing.Color.Silver;
            this.TableBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.TableBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TableBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TableBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TableBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.TableBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TableBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.TableBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TableBox.FillDropDown = true;
            this.TableBox.FillIndicator = false;
            this.TableBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TableBox.ForeColor = System.Drawing.Color.Black;
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Icon = null;
            this.TableBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TableBox.IndicatorColor = System.Drawing.Color.Gray;
            this.TableBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TableBox.ItemBackColor = System.Drawing.Color.White;
            this.TableBox.ItemBorderColor = System.Drawing.Color.White;
            this.TableBox.ItemForeColor = System.Drawing.Color.Black;
            this.TableBox.ItemHeight = 26;
            this.TableBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.TableBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.TableBox.ItemTopMargin = 3;
            this.TableBox.Location = new System.Drawing.Point(0, 23);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(556, 32);
            this.TableBox.TabIndex = 68;
            this.TableBox.Text = null;
            this.TableBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TableBox.TextLeftMargin = 5;
            this.TableBox.SelectedIndexChanged += new System.EventHandler(this.TableBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.IDBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 55);
            this.panel3.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Выберите строку, которую вам нужно удалить:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Deleter_MouseDown);
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.Transparent;
            this.IDBox.BackgroundColor = System.Drawing.Color.White;
            this.IDBox.BorderColor = System.Drawing.Color.Silver;
            this.IDBox.BorderRadius = 1;
            this.IDBox.Color = System.Drawing.Color.Silver;
            this.IDBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.IDBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IDBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IDBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IDBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.IDBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IDBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IDBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.IDBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IDBox.FillDropDown = true;
            this.IDBox.FillIndicator = false;
            this.IDBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDBox.ForeColor = System.Drawing.Color.Black;
            this.IDBox.FormattingEnabled = true;
            this.IDBox.Icon = null;
            this.IDBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.IDBox.IndicatorColor = System.Drawing.Color.Gray;
            this.IDBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.IDBox.ItemBackColor = System.Drawing.Color.White;
            this.IDBox.ItemBorderColor = System.Drawing.Color.White;
            this.IDBox.ItemForeColor = System.Drawing.Color.Black;
            this.IDBox.ItemHeight = 26;
            this.IDBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.IDBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.IDBox.ItemTopMargin = 3;
            this.IDBox.Location = new System.Drawing.Point(0, 23);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(556, 32);
            this.IDBox.TabIndex = 68;
            this.IDBox.Text = null;
            this.IDBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IDBox.TextLeftMargin = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(556, 38);
            this.button1.TabIndex = 67;
            this.button1.Text = "Удалить!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Remove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(556, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 65;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Trash_Can_Empty;
            this.pictureBox2.Location = new System.Drawing.Point(0, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Deleter_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(0, 112);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(200, 38);
            this.BtnClose.TabIndex = 56;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 60;
            this.label1.Text = "Удаление данных из любой таблицы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Deleter_MouseDown);
            // 
            // Deleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(756, 150);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deleter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление данных";
            this.Load += new System.EventHandler(this.Client_Delete_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Deleter_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown IDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown TableBox;
    }
}