namespace PM_LKMT.SubForm
{
    partial class ViewProduct
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			label1 = new Label();
			searchBox = new TextBox();
			panelBanChay = new FlowLayoutPanel();
			labels = new Label();
			panelAll = new FlowLayoutPanel();
			label3 = new Label();
			panelThuongHieuHot = new FlowLayoutPanel();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = SystemColors.Control;
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(searchBox);
			flowLayoutPanel1.Controls.Add(panelBanChay);
			flowLayoutPanel1.Controls.Add(labels);
			flowLayoutPanel1.Controls.Add(panelAll);
			flowLayoutPanel1.Controls.Add(label3);
			flowLayoutPanel1.Controls.Add(panelThuongHieuHot);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.ForeColor = SystemColors.ControlText;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(800, 576);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(87, 23);
			label1.TabIndex = 3;
			label1.Text = "Bán chạy";
			// 
			// searchBox
			// 
			searchBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			searchBox.Location = new Point(3, 26);
			searchBox.Name = "searchBox";
			searchBox.PlaceholderText = "Tìm kiếm bằng mã hoặc tên";
			searchBox.Size = new Size(284, 31);
			searchBox.TabIndex = 1;
			searchBox.TextChanged += searchBox_TextChanged;
			searchBox.Enter += searchBox_TextChanged;
			// 
			// panelBanChay
			// 
			panelBanChay.AutoScroll = true;
			panelBanChay.Location = new Point(3, 63);
			panelBanChay.Name = "panelBanChay";
			panelBanChay.Size = new Size(785, 300);
			panelBanChay.TabIndex = 8;
			panelBanChay.WrapContents = false;
			// 
			// labels
			// 
			labels.AutoSize = true;
			labels.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
			labels.Location = new Point(3, 366);
			labels.Name = "labels";
			labels.Size = new Size(64, 23);
			labels.TabIndex = 9;
			labels.Text = "Tất cả";
			// 
			// panelAll
			// 
			panelAll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panelAll.AutoScroll = true;
			panelAll.Location = new Point(794, 3);
			panelAll.Name = "panelAll";
			panelAll.Size = new Size(0, 320);
			panelAll.TabIndex = 10;
			panelAll.WrapContents = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
			label3.Location = new Point(800, 0);
			label3.Name = "label3";
			label3.Size = new Size(165, 23);
			label3.TabIndex = 11;
			label3.Text = "Thương hiệu HOT";
			// 
			// panelThuongHieuHot
			// 
			panelThuongHieuHot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panelThuongHieuHot.AutoScroll = true;
			panelThuongHieuHot.Location = new Point(800, 26);
			panelThuongHieuHot.Name = "panelThuongHieuHot";
			panelThuongHieuHot.Size = new Size(165, 250);
			panelThuongHieuHot.TabIndex = 11;
			panelThuongHieuHot.WrapContents = false;
			// 
			// ViewProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 576);
			Controls.Add(flowLayoutPanel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ViewProduct";
			Text = "ViewProduct";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox searchBox;
        private Label labels;
        private FlowLayoutPanel panelAll;
        private Label label3;
        private FlowLayoutPanel panelThuongHieuHot;
        private FlowLayoutPanel panelBanChay;
    }
}