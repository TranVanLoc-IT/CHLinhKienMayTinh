namespace PM_LKMT.Controls
{
    partial class ProductDetails
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
            productImg = new PictureBox();
            label1 = new Label();
            txtDId = new TextBox();
            txtDQuantityLeft = new TextBox();
            label2 = new Label();
            txtDPrice = new TextBox();
            label3 = new Label();
            txtDBrand = new TextBox();
            label4 = new Label();
            txtDName = new TextBox();
            label5 = new Label();
            btnAddToCart = new Button.Add();
            ((System.ComponentModel.ISupportInitialize)productImg).BeginInit();
            SuspendLayout();
            // 
            // productImg
            // 
            productImg.BackColor = SystemColors.ButtonFace;
            productImg.BackgroundImageLayout = ImageLayout.Stretch;
            productImg.Location = new Point(0, 0);
            productImg.Name = "productImg";
            productImg.Size = new Size(244, 226);
            productImg.TabIndex = 0;
            productImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.Location = new Point(264, 23);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm";
            // 
            // txtDId
            // 
            txtDId.BorderStyle = BorderStyle.FixedSingle;
            txtDId.Enabled = false;
            txtDId.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtDId.ForeColor = Color.SteelBlue;
            txtDId.Location = new Point(420, 9);
            txtDId.Name = "txtDId";
            txtDId.Size = new Size(220, 34);
            txtDId.TabIndex = 2;
            // 
            // txtDQuantityLeft
            // 
            txtDQuantityLeft.BorderStyle = BorderStyle.FixedSingle;
            txtDQuantityLeft.Enabled = false;
            txtDQuantityLeft.Font = new Font("Times New Roman", 13.8F);
            txtDQuantityLeft.ForeColor = Color.SteelBlue;
            txtDQuantityLeft.Location = new Point(420, 195);
            txtDQuantityLeft.Name = "txtDQuantityLeft";
            txtDQuantityLeft.Size = new Size(131, 34);
            txtDQuantityLeft.TabIndex = 4;
            txtDQuantityLeft.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.Location = new Point(264, 207);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 3;
            label2.Text = "Số lượng còn";
            // 
            // txtDPrice
            // 
            txtDPrice.BorderStyle = BorderStyle.FixedSingle;
            txtDPrice.Enabled = false;
            txtDPrice.Font = new Font("Times New Roman", 13.8F);
            txtDPrice.ForeColor = Color.SteelBlue;
            txtDPrice.Location = new Point(419, 148);
            txtDPrice.Name = "txtDPrice";
            txtDPrice.Size = new Size(219, 34);
            txtDPrice.TabIndex = 6;
            txtDPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.Location = new Point(264, 160);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 5;
            label3.Text = "Giá bán";
            // 
            // txtDBrand
            // 
            txtDBrand.BorderStyle = BorderStyle.FixedSingle;
            txtDBrand.Enabled = false;
            txtDBrand.Font = new Font("Times New Roman", 13.8F);
            txtDBrand.ForeColor = Color.SteelBlue;
            txtDBrand.Location = new Point(420, 100);
            txtDBrand.Name = "txtDBrand";
            txtDBrand.Size = new Size(220, 34);
            txtDBrand.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.Location = new Point(264, 112);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 7;
            label4.Text = "Thương hiệu";
            // 
            // txtDName
            // 
            txtDName.BorderStyle = BorderStyle.FixedSingle;
            txtDName.Enabled = false;
            txtDName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            txtDName.ForeColor = Color.SteelBlue;
            txtDName.Location = new Point(420, 53);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(220, 34);
            txtDName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.Location = new Point(264, 65);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 9;
            label5.Text = "Tên sản phẩm";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(481, 245);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(133, 67);
            btnAddToCart.TabIndex = 1;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddToCart);
            Controls.Add(txtDName);
            Controls.Add(label5);
            Controls.Add(txtDBrand);
            Controls.Add(label4);
            Controls.Add(txtDPrice);
            Controls.Add(label3);
            Controls.Add(txtDQuantityLeft);
            Controls.Add(label2);
            Controls.Add(txtDId);
            Controls.Add(label1);
            Controls.Add(productImg);
            Name = "ProductDetails";
            Size = new Size(670, 312);
            ((System.ComponentModel.ISupportInitialize)productImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox productImg;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox txtDId;
        public TextBox txtDQuantityLeft;
        public TextBox txtDPrice;
        public TextBox txtDBrand;
        public TextBox txtDName;
        public Button.Add btnAddToCart;
	}
}
