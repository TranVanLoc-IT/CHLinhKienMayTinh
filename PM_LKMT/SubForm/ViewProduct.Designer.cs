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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panelBanChay = new FlowLayoutPanel();
            labels = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            cbBrandFilter = new ComboBox();
            label4 = new Label();
            cbProductTypeFilter = new ComboBox();
            searchBox = new TextBox();
            refreshBtn = new Button();
            panelAll = new FlowLayoutPanel();
            label3 = new Label();
            panelThuongHieuHot = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panelBanChay);
            flowLayoutPanel1.Controls.Add(labels);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
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
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 48);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 3;
            label1.Text = "Bán chạy";
            // 
            // panelBanChay
            // 
            panelBanChay.AutoScroll = true;
            panelBanChay.BorderStyle = BorderStyle.Fixed3D;
            panelBanChay.Location = new Point(3, 57);
            panelBanChay.Name = "panelBanChay";
            panelBanChay.Size = new Size(94, 300);
            panelBanChay.TabIndex = 8;
            panelBanChay.WrapContents = false;
            // 
            // labels
            // 
            labels.AutoSize = true;
            labels.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labels.ForeColor = Color.SteelBlue;
            labels.Location = new Point(3, 360);
            labels.Name = "labels";
            labels.Size = new Size(94, 35);
            labels.TabIndex = 9;
            labels.Text = "Tất cả";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.SteelBlue;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(cbBrandFilter);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(cbProductTypeFilter);
            flowLayoutPanel2.Controls.Add(searchBox);
            flowLayoutPanel2.Controls.Add(refreshBtn);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 398);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(94, 36);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(77, 85);
            label2.TabIndex = 14;
            label2.Text = "Thương hiệu";
            // 
            // cbBrandFilter
            // 
            cbBrandFilter.FormattingEnabled = true;
            cbBrandFilter.Items.AddRange(new object[] { "Tất cả thương hiệu" });
            cbBrandFilter.Location = new Point(3, 88);
            cbBrandFilter.Name = "cbBrandFilter";
            cbBrandFilter.Size = new Size(151, 28);
            cbBrandFilter.TabIndex = 12;
            cbBrandFilter.SelectedIndexChanged += cbBrandFilter_SelectedIndexChanged;
            cbBrandFilter.Click += cbBrandFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(3, 119);
            label4.Name = "label4";
            label4.Size = new Size(64, 100);
            label4.TabIndex = 15;
            label4.Text = "Linh kiện theo loại";
            // 
            // cbProductTypeFilter
            // 
            cbProductTypeFilter.FormattingEnabled = true;
            cbProductTypeFilter.Items.AddRange(new object[] { "Tất cả loại" });
            cbProductTypeFilter.Location = new Point(3, 222);
            cbProductTypeFilter.Name = "cbProductTypeFilter";
            cbProductTypeFilter.Size = new Size(151, 28);
            cbProductTypeFilter.TabIndex = 13;
            cbProductTypeFilter.SelectedIndexChanged += cbProductTypeFilter_SelectedIndexChanged;
            cbProductTypeFilter.Click += cbProductTypeFilter_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(3, 256);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Tìm kiếm bằng mã hoặc tên";
            searchBox.Size = new Size(284, 27);
            searchBox.TabIndex = 2;
            // 
            // refreshBtn
            // 
            refreshBtn.BackgroundImage = (Image)resources.GetObject("refreshBtn.BackgroundImage");
            refreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            refreshBtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Location = new Point(3, 289);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(42, 33);
            refreshBtn.TabIndex = 16;
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += button1_Click;
            // 
            // panelAll
            // 
            panelAll.AutoScroll = true;
            panelAll.Location = new Point(103, 3);
            panelAll.Name = "panelAll";
            panelAll.Size = new Size(252, 320);
            panelAll.TabIndex = 10;
            panelAll.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(103, 326);
            label3.Name = "label3";
            label3.Size = new Size(252, 35);
            label3.TabIndex = 11;
            label3.Text = "Thương hiệu HOT";
            // 
            // panelThuongHieuHot
            // 
            panelThuongHieuHot.AutoScroll = true;
            panelThuongHieuHot.BackColor = SystemColors.ButtonFace;
            panelThuongHieuHot.Location = new Point(103, 364);
            panelThuongHieuHot.Name = "panelThuongHieuHot";
            panelThuongHieuHot.Size = new Size(252, 192);
            panelThuongHieuHot.TabIndex = 13;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label labels;
        private FlowLayoutPanel panelAll;
        private Label label3;
        private FlowLayoutPanel panelBanChay;
        private FlowLayoutPanel flowLayoutPanel2;
        private ComboBox cbBrandFilter;
        private ComboBox cbProductTypeFilter;
        private Label label2;
        private Label label4;
        private Button refreshBtn;
        private Panel panel1;
        private TextBox searchBox;
        private FlowLayoutPanel panelThuongHieuHot;
    }
}