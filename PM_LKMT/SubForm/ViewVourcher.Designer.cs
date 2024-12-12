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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dvgVourcher = new DataGridView();
            label2 = new Label();
            txtMaKM = new TextBox();
            txtMaCT = new TextBox();
            label3 = new Label();
            txtHoaDon = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            cboDaDung = new ComboBox();
            label8 = new Label();
            btnBack = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgVourcher).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1426, 73);
            label1.TabIndex = 0;
            label1.Text = "KHUYẾN MÃI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dvgVourcher
            // 
            dvgVourcher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgVourcher.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgVourcher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgVourcher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgVourcher.Location = new Point(0, 70);
            dvgVourcher.Margin = new Padding(2);
            dvgVourcher.Name = "dvgVourcher";
            dvgVourcher.RowHeadersWidth = 62;
            dvgVourcher.Size = new Size(1426, 271);
            dvgVourcher.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(10, 406);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 2;
            label2.Text = "Mã khuyến mãi";
            // 
            // txtMaKM
            // 
            txtMaKM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMaKM.Font = new Font("Segoe UI", 14F);
            txtMaKM.Location = new Point(202, 401);
            txtMaKM.Margin = new Padding(2);
            txtMaKM.Name = "txtMaKM";
            txtMaKM.Size = new Size(372, 39);
            txtMaKM.TabIndex = 3;
            // 
            // txtMaCT
            // 
            txtMaCT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMaCT.Enabled = false;
            txtMaCT.Font = new Font("Segoe UI", 14F);
            txtMaCT.Location = new Point(202, 354);
            txtMaCT.Margin = new Padding(2);
            txtMaCT.Name = "txtMaCT";
            txtMaCT.Size = new Size(546, 39);
            txtMaCT.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(10, 359);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 4;
            label3.Text = "Mã chương trình";
            // 
            // txtHoaDon
            // 
            txtHoaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtHoaDon.Font = new Font("Segoe UI", 14F);
            txtHoaDon.Location = new Point(895, 354);
            txtHoaDon.Margin = new Padding(2);
            txtHoaDon.Name = "txtHoaDon";
            txtHoaDon.Size = new Size(514, 39);
            txtHoaDon.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(762, 359);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 8;
            label5.Text = "Hóa đơn";
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
            btnAdd.Location = new Point(569, 474);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 59);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
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
            btnDelete.Location = new Point(767, 474);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 59);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // cboDaDung
            // 
            cboDaDung.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cboDaDung.Font = new Font("Segoe UI", 14F);
            cboDaDung.FormattingEnabled = true;
            cboDaDung.Location = new Point(895, 404);
            cboDaDung.Margin = new Padding(2);
            cboDaDung.Name = "cboDaDung";
            cboDaDung.Size = new Size(514, 39);
            cboDaDung.TabIndex = 30;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(763, 412);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(137, 32);
            label8.TabIndex = 29;
            label8.Text = "Đã sử dụng";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.DarkCyan;
            btnBack.BackgroundImage = Resource.update2;
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(954, 474);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 59);
            btnBack.TabIndex = 31;
            btnBack.Text = "Trở ra";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(614, 401);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 32;
            button1.Text = "Tự sinh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewVourcher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1426, 598);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(cboDaDung);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtHoaDon);
            Controls.Add(label5);
            Controls.Add(txtMaCT);
            Controls.Add(label3);
            Controls.Add(txtMaKM);
            Controls.Add(label2);
            Controls.Add(dvgVourcher);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private TextBox txtHoaDon;
        private Label label5;
        public Button btnAdd;
        public Button btnDelete;
        private ComboBox cboDaDung;
        private Label label8;
        public Button btnBack;
        private Button button1;
    }
}