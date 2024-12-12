namespace PM_LKMT.UserControlCustom
{
    partial class WarehouseForm
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
            dgvkho = new DataGridView();
            label1 = new Label();
            cbProducts = new ComboBox();
            txtTongSLBan = new TextBox();
            label2 = new Label();
            lb1 = new Label();
            txtTongDoanhThu = new TextBox();
            label4 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            txtCapNhatGanNhat = new TextBox();
            label5 = new Label();
            txtThoiGianBaoHanh = new TextBox();
            label6 = new Label();
            txtSoLuongTon = new TextBox();
            label7 = new Label();
            txtTongSanPham = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvkho).BeginInit();
            SuspendLayout();
            // 
            // dgvkho
            // 
            dgvkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkho.Dock = DockStyle.Right;
            dgvkho.Location = new Point(137, 0);
            dgvkho.Margin = new Padding(3, 2, 3, 2);
            dgvkho.Name = "dgvkho";
            dgvkho.RowHeadersWidth = 51;
            dgvkho.Size = new Size(1497, 847);
            dgvkho.TabIndex = 0;
            dgvkho.CellClick += dgvkho_CellClick;
            dgvkho.CellContentClick += dgvkho_CellContentClick;
            dgvkho.DataBindingComplete += dgvkho_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(31, 105);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 1;
            label1.Text = "Chọn sản phẩm";
            // 
            // cbProducts
            // 
            cbProducts.Font = new Font("Times New Roman", 12F);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(190, 105);
            cbProducts.Margin = new Padding(3, 2, 3, 2);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(149, 27);
            cbProducts.TabIndex = 2;
            // 
            // txtTongSLBan
            // 
            txtTongSLBan.Font = new Font("Times New Roman", 12F);
            txtTongSLBan.Location = new Point(190, 287);
            txtTongSLBan.Margin = new Padding(3, 2, 3, 2);
            txtTongSLBan.Name = "txtTongSLBan";
            txtTongSLBan.Size = new Size(149, 26);
            txtTongSLBan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(30, 293);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 4;
            label2.Text = "Tổng số lượng bán ra";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Times New Roman", 12F);
            lb1.Location = new Point(28, 243);
            lb1.Name = "lb1";
            lb1.Size = new Size(103, 19);
            lb1.TabIndex = 6;
            lb1.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.Font = new Font("Times New Roman", 12F);
            txtTongDoanhThu.Location = new Point(190, 236);
            txtTongDoanhThu.Margin = new Padding(3, 2, 3, 2);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(149, 26);
            txtTongDoanhThu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(31, 195);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 8;
            label4.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Times New Roman", 12F);
            txtDonGia.Location = new Point(190, 188);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(149, 26);
            txtDonGia.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(31, 426);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 14;
            label3.Text = "Cập nhật gần nhất";
            // 
            // txtCapNhatGanNhat
            // 
            txtCapNhatGanNhat.Font = new Font("Times New Roman", 12F);
            txtCapNhatGanNhat.Location = new Point(190, 419);
            txtCapNhatGanNhat.Margin = new Padding(3, 2, 3, 2);
            txtCapNhatGanNhat.Name = "txtCapNhatGanNhat";
            txtCapNhatGanNhat.Size = new Size(149, 26);
            txtCapNhatGanNhat.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(28, 385);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 12;
            label5.Text = "Thời gian bảo hành";
            // 
            // txtThoiGianBaoHanh
            // 
            txtThoiGianBaoHanh.Font = new Font("Times New Roman", 12F);
            txtThoiGianBaoHanh.Location = new Point(190, 378);
            txtThoiGianBaoHanh.Margin = new Padding(3, 2, 3, 2);
            txtThoiGianBaoHanh.Name = "txtThoiGianBaoHanh";
            txtThoiGianBaoHanh.Size = new Size(149, 26);
            txtThoiGianBaoHanh.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(30, 336);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 10;
            label6.Text = "Tổng số lượng tồn";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Font = new Font("Times New Roman", 12F);
            txtSoLuongTon.Location = new Point(190, 330);
            txtSoLuongTon.Margin = new Padding(3, 2, 3, 2);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(149, 26);
            txtSoLuongTon.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(31, 154);
            label7.Name = "label7";
            label7.Size = new Size(101, 19);
            label7.TabIndex = 16;
            label7.Text = "Tổng sản phẩm";
            // 
            // txtTongSanPham
            // 
            txtTongSanPham.Font = new Font("Times New Roman", 12F);
            txtTongSanPham.Location = new Point(190, 147);
            txtTongSanPham.Margin = new Padding(3, 2, 3, 2);
            txtTongSanPham.Name = "txtTongSanPham";
            txtTongSanPham.Size = new Size(149, 26);
            txtTongSanPham.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(65, 29);
            label8.Name = "label8";
            label8.Size = new Size(182, 36);
            label8.TabIndex = 17;
            label8.Text = "KHO HÀNG";
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 847);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTongSanPham);
            Controls.Add(label3);
            Controls.Add(txtCapNhatGanNhat);
            Controls.Add(label5);
            Controls.Add(txtThoiGianBaoHanh);
            Controls.Add(label6);
            Controls.Add(txtSoLuongTon);
            Controls.Add(label4);
            Controls.Add(txtDonGia);
            Controls.Add(lb1);
            Controls.Add(txtTongDoanhThu);
            Controls.Add(label2);
            Controls.Add(txtTongSLBan);
            Controls.Add(cbProducts);
            Controls.Add(label1);
            Controls.Add(dgvkho);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WarehouseForm";
            Text = "WarehouseForm";
            Load += WarehouseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvkho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvkho;
		private Label label1;
		private ComboBox cbProducts;
		private TextBox txtTongSLBan;
		private Label label2;
		private Label lb1;
		private TextBox txtTongDoanhThu;
		private Label label4;
		private TextBox txtDonGia;
        private Label label3;
        private TextBox txtCapNhatGanNhat;
        private Label label5;
        private TextBox txtThoiGianBaoHanh;
        private Label label6;
        private TextBox txtSoLuongTon;
        private Label label7;
        private TextBox txtTongSanPham;
        private Label label8;
    }
}