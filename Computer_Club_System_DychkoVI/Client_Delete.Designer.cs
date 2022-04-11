
namespace Dyczko_ComputerClub_System
{
    partial class Client_Delete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tnRemove = new System.Windows.Forms.Button();
            this.IDBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tnRemove);
            this.panel1.Controls.Add(this.IDBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 31);
            this.panel1.TabIndex = 0;
            // 
            // tnRemove
            // 
            this.tnRemove.BackColor = System.Drawing.Color.Black;
            this.tnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.tnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tnRemove.FlatAppearance.BorderSize = 2;
            this.tnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tnRemove.Location = new System.Drawing.Point(0, 0);
            this.tnRemove.Name = "tnRemove";
            this.tnRemove.Size = new System.Drawing.Size(172, 31);
            this.tnRemove.TabIndex = 1;
            this.tnRemove.Text = "Удалить!";
            this.tnRemove.UseVisualStyleBackColor = false;
            this.tnRemove.Click += new System.EventHandler(this.Remove);
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
            this.IDBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.IDBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IDBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.IDBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IDBox.FillDropDown = true;
            this.IDBox.FillIndicator = false;
            this.IDBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
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
            this.IDBox.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IDBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.IDBox.ItemTopMargin = 3;
            this.IDBox.Location = new System.Drawing.Point(172, 0);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(262, 32);
            this.IDBox.TabIndex = 0;
            this.IDBox.Text = null;
            this.IDBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IDBox.TextLeftMargin = 5;
            // 
            // Client_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 31);
            this.Controls.Add(this.panel1);
            this.Name = "Client_Delete";
            this.Text = "Удаление клиента из базы данных";
            this.Load += new System.EventHandler(this.Client_Delete_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tnRemove;
        private Bunifu.UI.WinForms.BunifuDropdown IDBox;
    }
}