namespace PM_LKMT.SubForm
{
    partial class ViewVourcher
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
            label1 = new Label();
            dvgVourcher = new DataGridView();
            label2 = new Label();
            txtMaKM = new TextBox();
            txtMaCT = new TextBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            btnTaoMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgVourcher).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(926, 91);
            label1.TabIndex = 0;
            label1.Text = "KHUYẾN MÃI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dvgVourcher
            // 
            dvgVourcher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgVourcher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVourcher.Location = new Point(0, 74);
            dvgVourcher.Name = "dvgVourcher";
            dvgVourcher.RowHeadersWidth = 62;
            dvgVourcher.RowTemplate.Height = 33;
            dvgVourcher.Size = new Size(926, 338);
            dvgVourcher.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 465);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã khuyến mãi";
            // 
            // txtMaKM
            // 
            txtMaKM.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKM.Location = new Point(188, 462);
            txtMaKM.Name = "txtMaKM";
            txtMaKM.Size = new Size(239, 33);
            txtMaKM.TabIndex = 3;
            // 
            // txtMaCT
            // 
            txtMaCT.Enabled = false;
            txtMaCT.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCT.Location = new Point(188, 501);
            txtMaCT.Name = "txtMaCT";
            txtMaCT.Size = new Size(239, 33);
            txtMaCT.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 504);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 4;
            label3.Text = "Mã chương trình";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(596, 457);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(303, 33);
            txtSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(469, 465);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoMoi.Location = new Point(471, 504);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(122, 46);
            btnTaoMoi.TabIndex = 8;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(625, 504);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 46);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhat.Location = new Point(777, 504);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(122, 46);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // ViewVourcher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 597);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnTaoMoi);
            Controls.Add(txtSoLuong);
            Controls.Add(label4);
            Controls.Add(txtMaCT);
            Controls.Add(label3);
            Controls.Add(txtMaKM);
            Controls.Add(label2);
            Controls.Add(dvgVourcher);
            Controls.Add(label1);
            Name = "ViewVourcher";
            Text = "ViewVourcher";
            ((System.ComponentModel.ISupportInitialize)dvgVourcher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dvgVourcher;
        private Label label2;
        private TextBox txtMaKM;
        private TextBox txtMaCT;
        private Label label3;
        private TextBox txtSoLuong;
        private Label label4;
        private Button btnTaoMoi;
        private Button btnXoa;
        private Button btnCapNhat;
    }
}