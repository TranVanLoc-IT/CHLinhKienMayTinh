﻿namespace PM_LKMT
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUserName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(369, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 450);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Resource.logocompany;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 257);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 61);
            label1.Name = "label1";
            label1.Size = new Size(330, 32);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM BÁN HÀNG";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ActiveCaption;
            txtUserName.Font = new Font("Times New Roman", 12F);
            txtUserName.ForeColor = SystemColors.InactiveBorder;
            txtUserName.Location = new Point(196, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(185, 30);
            txtUserName.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Resource.login1;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(121, 269);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 2;
            button1.Text = "ĐĂNG NHẬP";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(52, 198);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(52, 137);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 4;
            label3.Text = "Tên đăng nhập";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ActiveCaption;
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.ForeColor = SystemColors.InactiveBorder;
            txtPassword.Location = new Point(177, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 30);
            txtPassword.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox txtUserName;
        private Label label1;
    }
}