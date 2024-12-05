namespace PM_LKMT.Controls
{
	partial class OrderCard
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
			txtMaDH = new TextBox();
			buttonView = new System.Windows.Forms.Button();
			totalPrice = new Label();
			imgBox = new PictureBox();
			txtKH = new TextBox();
			((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
			SuspendLayout();
			// 
			// txtMaDH
			// 
			txtMaDH.BackColor = SystemColors.Control;
			txtMaDH.BorderStyle = BorderStyle.None;
			txtMaDH.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtMaDH.Location = new Point(3, 96);
			txtMaDH.Multiline = true;
			txtMaDH.Name = "txtMaDH";
			txtMaDH.Size = new Size(155, 23);
			txtMaDH.TabIndex = 11;
			// 
			// buttonView
			// 
			buttonView.BackColor = SystemColors.ActiveCaption;
			buttonView.BackgroundImage = Resource.see;
			buttonView.BackgroundImageLayout = ImageLayout.None;
			buttonView.Location = new Point(96, 150);
			buttonView.Name = "buttonView";
			buttonView.Size = new Size(43, 41);
			buttonView.TabIndex = 10;
			buttonView.UseVisualStyleBackColor = false;
			// 
			// totalPrice
			// 
			totalPrice.AutoSize = true;
			totalPrice.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			totalPrice.Location = new Point(15, 150);
			totalPrice.Name = "totalPrice";
			totalPrice.Size = new Size(55, 20);
			totalPrice.TabIndex = 9;
			totalPrice.Text = "label4";
			// 
			// imgBox
			// 
			imgBox.BackgroundImage = Resource.icons8_cart_481;
			imgBox.BackgroundImageLayout = ImageLayout.Zoom;
			imgBox.Dock = DockStyle.Top;
			imgBox.Location = new Point(0, 0);
			imgBox.Name = "imgBox";
			imgBox.Size = new Size(161, 90);
			imgBox.TabIndex = 7;
			imgBox.TabStop = false;
			// 
			// txtKH
			// 
			txtKH.BackColor = SystemColors.Control;
			txtKH.BorderStyle = BorderStyle.None;
			txtKH.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtKH.Location = new Point(3, 121);
			txtKH.Multiline = true;
			txtKH.Name = "txtKH";
			txtKH.Size = new Size(155, 23);
			txtKH.TabIndex = 12;
			// 
			// OrderCard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(txtKH);
			Controls.Add(txtMaDH);
			Controls.Add(buttonView);
			Controls.Add(totalPrice);
			Controls.Add(imgBox);
			Name = "OrderCard";
			Size = new Size(161, 198);
			((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public TextBox txtMaDH;
		public System.Windows.Forms.Button buttonView;
		public Label totalPrice;
		public PictureBox imgBox;
		public TextBox txtKH;
	}
}
