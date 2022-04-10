
namespace Dyczko_ComputerClub_System
{
    partial class Staff_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.GenBox = new System.Windows.Forms.ComboBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 161);
            this.panel1.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.BtnChange);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(387, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 161);
            this.panel3.TabIndex = 62;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Location = new System.Drawing.Point(0, 87);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(197, 23);
            this.BtnAdd.TabIndex = 65;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.AddWorker);
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.Yellow;
            this.BtnChange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BtnChange.Location = new System.Drawing.Point(0, 110);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(197, 23);
            this.BtnChange.TabIndex = 64;
            this.BtnChange.Text = "Очистить поля";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnClear);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 24);
            this.button1.TabIndex = 63;
            this.button1.Text = "Закрыть форму";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnClose);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 67);
            this.panel4.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 67);
            this.label1.TabIndex = 60;
            this.label1.Text = "Добавление нового работника клуба\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Dyczko_ComputerClub_System.Properties.Resources.Иконушка_святая;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.JobBox);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.AgeBox);
            this.panel6.Controls.Add(this.GenBox);
            this.panel6.Controls.Add(this.EmailBox);
            this.panel6.Controls.Add(this.NumberBox);
            this.panel6.Controls.Add(this.FIOBox);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 161);
            this.panel6.TabIndex = 61;
            // 
            // JobBox
            // 
            this.JobBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Location = new System.Drawing.Point(83, 129);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(297, 21);
            this.JobBox.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "Отдел:";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(83, 38);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(297, 20);
            this.AgeBox.TabIndex = 61;
            // 
            // GenBox
            // 
            this.GenBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GenBox.FormattingEnabled = true;
            this.GenBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.GenBox.Location = new System.Drawing.Point(83, 60);
            this.GenBox.Name = "GenBox";
            this.GenBox.Size = new System.Drawing.Size(297, 21);
            this.GenBox.TabIndex = 59;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(83, 107);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(297, 20);
            this.EmailBox.TabIndex = 12;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(83, 84);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(297, 20);
            this.NumberBox.TabIndex = 9;
            // 
            // FIOBox
            // 
            this.FIOBox.Location = new System.Drawing.Point(83, 15);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(297, 20);
            this.FIOBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "E-mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Номер:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(41, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Пол:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(5, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Возраст:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Yellow;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(35, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "ФИО:";
            // 
            // Staff_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff_Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наём";
            this.Load += new System.EventHandler(this.Staff_Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.ComboBox GenBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button button1;
    }
}