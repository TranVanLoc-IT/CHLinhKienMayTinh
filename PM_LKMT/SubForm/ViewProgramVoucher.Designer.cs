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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtProgramId = new TextBox();
            label2 = new Label();
            label8 = new Label();
            cboDaXoa = new ComboBox();
            btnKhoiPhuc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProgramVour).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1142, 53);
            label1.TabIndex = 0;
            label1.Text = "Chương trình khuyến mãi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProgramVour
            // 
            dgvProgramVour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProgramVour.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProgramVour.Location = new Point(12, 56);
            dgvProgramVour.Name = "dgvProgramVour";
            dgvProgramVour.RowHeadersWidth = 62;
            dgvProgramVour.RowTemplate.Height = 33;
            dgvProgramVour.Size = new Size(1121, 310);
            dgvProgramVour.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(613, 407);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 4;
            label3.Text = "Ngày bắt đầu:";
            // 
            // txtDateStart
            // 
            txtDateStart.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateStart.Location = new Point(807, 404);
            txtDateStart.Name = "txtDateStart";
            txtDateStart.PlaceholderText = "dd/MM/yyyy";
            txtDateStart.Size = new Size(246, 37);
            txtDateStart.TabIndex = 5;
            // 
            // txtPercentValue
            // 
            txtPercentValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPercentValue.Location = new Point(217, 450);
            txtPercentValue.Name = "txtPercentValue";
            txtPercentValue.Size = new Size(246, 37);
            txtPercentValue.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 447);
            label4.Name = "label4";
            label4.Size = new Size(175, 30);
            label4.TabIndex = 6;
            label4.Text = "Giá trị phần trăm";
            // 
            // txtDateEnd
            // 
            txtDateEnd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateEnd.Location = new Point(807, 446);
            txtDateEnd.Name = "txtDateEnd";
            txtDateEnd.PlaceholderText = "dd/MM/yyyy";
            txtDateEnd.Size = new Size(246, 37);
            txtDateEnd.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(613, 453);
            label5.Name = "label5";
            label5.Size = new Size(147, 30);
            label5.TabIndex = 8;
            label5.Text = "Ngày kết thúc";
            // 
            // txtPercentInvoice
            // 
            txtPercentInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPercentInvoice.Location = new Point(807, 495);
            txtPercentInvoice.Name = "txtPercentInvoice";
            txtPercentInvoice.Size = new Size(246, 37);
            txtPercentInvoice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(613, 504);
            label6.Name = "label6";
            label6.Size = new Size(156, 30);
            label6.TabIndex = 10;
            label6.Text = "Giá trị hóa đơn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 498);
            label7.Name = "label7";
            label7.Size = new Size(189, 30);
            label7.TabIndex = 12;
            label7.Text = "Điều kiện áp dụng";
            // 
            // txtConditionApply
            // 
            txtConditionApply.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtConditionApply.Location = new Point(217, 501);
            txtConditionApply.Multiline = true;
            txtConditionApply.Name = "txtConditionApply";
            txtConditionApply.Size = new Size(246, 88);
            txtConditionApply.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(301, 611);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 48);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(449, 612);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 46);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(595, 611);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 48);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtProgramId
            // 
            txtProgramId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtProgramId.Location = new Point(217, 407);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.Size = new Size(246, 37);
            txtProgramId.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 407);
            label2.Name = "label2";
            label2.Size = new Size(178, 30);
            label2.TabIndex = 17;
            label2.Text = "Mã chương trình:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(613, 550);
            label8.Name = "label8";
            label8.Size = new Size(84, 30);
            label8.TabIndex = 19;
            label8.Text = "Đã xóa:";
            // 
            // cboDaXoa
            // 
            cboDaXoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cboDaXoa.FormattingEnabled = true;
            cboDaXoa.Location = new Point(807, 542);
            cboDaXoa.Name = "cboDaXoa";
            cboDaXoa.Size = new Size(246, 38);
            cboDaXoa.TabIndex = 20;
            // 
            // btnKhoiPhuc
            // 
            btnKhoiPhuc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhoiPhuc.Location = new Point(743, 611);
            btnKhoiPhuc.Name = "btnKhoiPhuc";
            btnKhoiPhuc.Size = new Size(123, 48);
            btnKhoiPhuc.TabIndex = 21;
            btnKhoiPhuc.Text = "Khôi phục";
            btnKhoiPhuc.UseVisualStyleBackColor = true;
            // 
            // ViewProgramVoucher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 679);
            Controls.Add(btnKhoiPhuc);
            Controls.Add(cboDaXoa);
            Controls.Add(label8);
            Controls.Add(txtProgramId);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
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
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtProgramId;
        private Label label2;
        private Label label8;
        private ComboBox cboDaXoa;
        private Button btnKhoiPhuc;
    }
}