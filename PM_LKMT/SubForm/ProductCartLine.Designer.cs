namespace PM_LKMT.SubForm
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
            price.Location = new Point(516, 7);
            price.Name = "price";
            price.Size = new Size(120, 25);
            price.TabIndex = 2;
            price.Text = "123344444";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Dock = DockStyle.Left;
            txtName.Enabled = false;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(0, 0);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 70);
            txtName.TabIndex = 4;
            // 
            // quantity
            // 
            quantity.BackColor = Color.SteelBlue;
            quantity.BorderStyle = BorderStyle.None;
            quantity.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            quantity.ForeColor = SystemColors.InactiveBorder;
            quantity.Location = new Point(334, 0);
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
            Margin = new Padding(5);
            Name = "ProductCartLine";
            Size = new Size(686, 70);
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
