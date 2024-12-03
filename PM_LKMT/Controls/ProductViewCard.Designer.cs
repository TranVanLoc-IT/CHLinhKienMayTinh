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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewCard));
			imgBox = new PictureBox();
			brand = new Label();
			price = new Label();
			buttonView = new System.Windows.Forms.Button();
			productName = new TextBox();
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
			// brand
			// 
			brand.AutoSize = true;
			brand.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
			brand.Location = new Point(157, 185);
			brand.Name = "brand";
			brand.Size = new Size(65, 28);
			brand.TabIndex = 3;
			brand.Text = "label3";
			// 
			// price
			// 
			price.AutoSize = true;
			price.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			price.Location = new Point(3, 254);
			price.Name = "price";
			price.Size = new Size(60, 23);
			price.TabIndex = 4;
			price.Text = "label4";
			// 
			// buttonView
			// 
			buttonView.BackColor = Color.ForestGreen;
			buttonView.BackgroundImage = (Image)resources.GetObject("buttonView.BackgroundImage");
			buttonView.BackgroundImageLayout = ImageLayout.Center;
			buttonView.ImageAlign = ContentAlignment.TopCenter;
			buttonView.Location = new Point(148, 216);
			buttonView.Name = "buttonView";
			buttonView.Size = new Size(69, 64);
			buttonView.TabIndex = 5;
			buttonView.UseVisualStyleBackColor = false;
			buttonView.Click += buttonView_Click;
			// 
			// productName
			// 
			productName.BackColor = SystemColors.Control;
			productName.BorderStyle = BorderStyle.None;
			productName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			productName.Location = new Point(3, 170);
			productName.Multiline = true;
			productName.Name = "productName";
			productName.Size = new Size(139, 79);
			productName.TabIndex = 6;
			// 
			// ProductViewCard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(productName);
			Controls.Add(buttonView);
			Controls.Add(price);
			Controls.Add(brand);
			Controls.Add(imgBox);
			Name = "ProductViewCard";
			Size = new Size(220, 280);
			((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public PictureBox imgBox;
        public Label brand;
        public Label price;
        public System.Windows.Forms.Button buttonView;
        public TextBox productName;
    }
}
