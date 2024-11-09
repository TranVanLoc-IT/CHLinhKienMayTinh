namespace PM_LKMT.Controls
{
    partial class ProductViewCard
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
            imgBox = new PictureBox();
            productName = new Label();
            brand = new Label();
            price = new Label();
            buttonView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
            SuspendLayout();
            // 
            // imgBox
            // 
            imgBox.BackgroundImageLayout = ImageLayout.Stretch;
            imgBox.Dock = DockStyle.Top;
            imgBox.Location = new Point(0, 0);
            imgBox.Name = "imgBox";
            imgBox.Size = new Size(220, 164);
            imgBox.TabIndex = 1;
            imgBox.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.BackColor = SystemColors.Control;
            productName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            productName.Location = new Point(3, 187);
            productName.Name = "productName";
            productName.Size = new Size(51, 20);
            productName.TabIndex = 2;
            productName.Text = "label2";
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            brand.Location = new Point(157, 185);
            brand.Name = "brand";
            brand.Size = new Size(48, 20);
            brand.TabIndex = 3;
            brand.Text = "label3";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(3, 254);
            price.Name = "price";
            price.Size = new Size(55, 20);
            price.TabIndex = 4;
            price.Text = "label4";
            // 
            // buttonView
            // 
            buttonView.BackColor = SystemColors.ActiveCaption;
            buttonView.BackgroundImage = Resource.see;
            buttonView.BackgroundImageLayout = ImageLayout.None;
            buttonView.Location = new Point(157, 208);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(43, 41);
            buttonView.TabIndex = 5;
            buttonView.UseVisualStyleBackColor = false;
            buttonView.Click += buttonView_Click;
            // 
            // ProductViewCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonView);
            Controls.Add(price);
            Controls.Add(brand);
            Controls.Add(productName);
            Controls.Add(imgBox);
            Name = "ProductViewCard";
            Size = new Size(220, 280);
            ((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox imgBox;
        public Label productName;
        public Label brand;
        public Label price;
        public System.Windows.Forms.Button buttonView;
    }
}
