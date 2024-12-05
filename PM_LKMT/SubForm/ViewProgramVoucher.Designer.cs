namespace PM_LKMT.SubForm
{
    partial class ViewProgramVoucher
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvProgramVour = new DataGridView();
            label3 = new Label();
            txtDateStart = new TextBox();
            txtPercentValue = new TextBox();
            label4 = new Label();
            txtDateEnd = new TextBox();
            label5 = new Label();
            txtPercentInvoice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtConditionApply = new TextBox();
            txtProgramId = new TextBox();
            label2 = new Label();
            label8 = new Label();
            cboDaXoa = new ComboBox();
            btnAdd = new Button();
            btnKhoiPhuc = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProgramVour).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1783, 74);
            label1.TabIndex = 0;
            label1.Text = "Chương trình khuyến mãi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProgramVour
            // 
            dgvProgramVour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProgramVour.BackgroundColor = Color.White;
            dgvProgramVour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProgramVour.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProgramVour.Location = new Point(0, 77);
            dgvProgramVour.Name = "dgvProgramVour";
            dgvProgramVour.RowHeadersWidth = 62;
            dgvProgramVour.Size = new Size(1783, 262);
            dgvProgramVour.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(971, 365);
            label3.Name = "label3";
            label3.Size = new Size(189, 38);
            label3.TabIndex = 4;
            label3.Text = "Ngày bắt đầu:";
            // 
            // txtDateStart
            // 
            txtDateStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtDateStart.Font = new Font("Segoe UI", 14F);
            txtDateStart.Location = new Point(1183, 362);
            txtDateStart.Name = "txtDateStart";
            txtDateStart.PlaceholderText = "dd/MM/yyyy";
            txtDateStart.Size = new Size(595, 45);
            txtDateStart.TabIndex = 5;
            // 
            // txtPercentValue
            // 
            txtPercentValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPercentValue.Font = new Font("Segoe UI", 14F);
            txtPercentValue.Location = new Point(268, 421);
            txtPercentValue.Name = "txtPercentValue";
            txtPercentValue.Size = new Size(625, 45);
            txtPercentValue.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(15, 418);
            label4.Name = "label4";
            label4.Size = new Size(226, 38);
            label4.TabIndex = 6;
            label4.Text = "Giá trị phần trăm";
            // 
            // txtDateEnd
            // 
            txtDateEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtDateEnd.Font = new Font("Segoe UI", 14F);
            txtDateEnd.Location = new Point(1183, 414);
            txtDateEnd.Name = "txtDateEnd";
            txtDateEnd.PlaceholderText = "dd/MM/yyyy";
            txtDateEnd.Size = new Size(595, 45);
            txtDateEnd.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(971, 421);
            label5.Name = "label5";
            label5.Size = new Size(190, 38);
            label5.TabIndex = 8;
            label5.Text = "Ngày kết thúc";
            // 
            // txtPercentInvoice
            // 
            txtPercentInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPercentInvoice.Font = new Font("Segoe UI", 14F);
            txtPercentInvoice.Location = new Point(1183, 469);
            txtPercentInvoice.Name = "txtPercentInvoice";
            txtPercentInvoice.Size = new Size(595, 45);
            txtPercentInvoice.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(971, 478);
            label6.Name = "label6";
            label6.Size = new Size(202, 38);
            label6.TabIndex = 10;
            label6.Text = "Giá trị hóa đơn";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(12, 480);
            label7.Name = "label7";
            label7.Size = new Size(245, 38);
            label7.TabIndex = 12;
            label7.Text = "Điều kiện áp dụng";
            // 
            // txtConditionApply
            // 
            txtConditionApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtConditionApply.Font = new Font("Segoe UI", 14F);
            txtConditionApply.Location = new Point(268, 483);
            txtConditionApply.Multiline = true;
            txtConditionApply.Name = "txtConditionApply";
            txtConditionApply.Size = new Size(625, 88);
            txtConditionApply.TabIndex = 13;
            // 
            // txtProgramId
            // 
            txtProgramId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtProgramId.Font = new Font("Segoe UI", 14F);
            txtProgramId.Location = new Point(268, 365);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.Size = new Size(625, 45);
            txtProgramId.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(15, 365);
            label2.Name = "label2";
            label2.Size = new Size(224, 38);
            label2.TabIndex = 17;
            label2.Text = "Mã chương trình";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(971, 534);
            label8.Name = "label8";
            label8.Size = new Size(108, 38);
            label8.TabIndex = 19;
            label8.Text = "Đã xóa:";
            // 
            // cboDaXoa
            // 
            cboDaXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cboDaXoa.Font = new Font("Segoe UI", 14F);
            cboDaXoa.FormattingEnabled = true;
            cboDaXoa.Location = new Point(1183, 526);
            cboDaXoa.Name = "cboDaXoa";
            cboDaXoa.Size = new Size(595, 46);
            cboDaXoa.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.BackgroundImage = Resource.add;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(516, 597);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 74);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnKhoiPhuc
            // 
            btnKhoiPhuc.Anchor = AnchorStyles.Bottom;
            btnKhoiPhuc.BackColor = Color.Green;
            btnKhoiPhuc.BackgroundImage = Resource.update2;
            btnKhoiPhuc.BackgroundImageLayout = ImageLayout.None;
            btnKhoiPhuc.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnKhoiPhuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKhoiPhuc.ForeColor = SystemColors.ButtonFace;
            btnKhoiPhuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoiPhuc.Location = new Point(1150, 597);
            btnKhoiPhuc.Margin = new Padding(4);
            btnKhoiPhuc.Name = "btnKhoiPhuc";
            btnKhoiPhuc.Size = new Size(149, 74);
            btnKhoiPhuc.TabIndex = 26;
            btnKhoiPhuc.Text = "Restore";
            btnKhoiPhuc.TextAlign = ContentAlignment.MiddleRight;
            btnKhoiPhuc.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.BackgroundImage = Resource.delete;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(734, 597);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 74);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.BackgroundImage = Resource.update2;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(945, 598);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 74);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // ViewProgramVoucher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1783, 748);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnKhoiPhuc);
            Controls.Add(btnAdd);
            Controls.Add(cboDaXoa);
            Controls.Add(label8);
            Controls.Add(txtProgramId);
            Controls.Add(label2);
            Controls.Add(txtConditionApply);
            Controls.Add(label7);
            Controls.Add(txtPercentInvoice);
            Controls.Add(label6);
            Controls.Add(txtDateEnd);
            Controls.Add(label5);
            Controls.Add(txtPercentValue);
            Controls.Add(label4);
            Controls.Add(txtDateStart);
            Controls.Add(label3);
            Controls.Add(dgvProgramVour);
            Controls.Add(label1);
            Name = "ViewProgramVoucher";
            Text = "ViewProgramVoucher";
            ((System.ComponentModel.ISupportInitialize)dgvProgramVour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProgramVour;
        private Label label3;
        private TextBox txtDateStart;
        private TextBox txtPercentValue;
        private Label label4;
        private TextBox txtDateEnd;
        private Label label5;
        private TextBox txtPercentInvoice;
        private Label label6;
        private Label label7;
        private TextBox txtConditionApply;
        private TextBox txtProgramId;
        private Label label2;
        private Label label8;
        private ComboBox cboDaXoa;
        public Button btnAdd;
        public Button btnKhoiPhuc;
        public Button btnDelete;
        public Button btnUpdate;
    }
}