﻿namespace PM_LKMT.SubForm
{
    partial class ProductCartLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            price = new Label();
            txtName = new TextBox();
            quantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            SuspendLayout();
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            price.Location = new Point(423, 22);
            price.Name = "price";
            price.Size = new Size(120, 25);
            price.TabIndex = 2;
            price.Text = "123344444";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(3, 16);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 34);
            txtName.TabIndex = 4;
            // 
            // quantity
            // 
            quantity.BackColor = Color.SteelBlue;
            quantity.BorderStyle = BorderStyle.None;
            quantity.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            quantity.ForeColor = SystemColors.InactiveBorder;
            quantity.Location = new Point(246, 19);
            quantity.Name = "quantity";
            quantity.Size = new Size(150, 30);
            quantity.TabIndex = 5;
            quantity.TextAlign = HorizontalAlignment.Right;
            quantity.ValueChanged += quantity_ValueChanged;
            // 
            // ProductCartLine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(quantity);
            Controls.Add(txtName);
            Controls.Add(price);
            Name = "ProductCartLine";
            Size = new Size(587, 57);
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label price;
        public TextBox txtName;
        public NumericUpDown quantity;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
