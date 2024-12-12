namespace PM_LKMT.SubForm
{
    partial class ImportReceiptForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel4 = new Panel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            btnDeletePN = new Button();
            btnAddPN = new Button();
            dgvPN = new DataGridView();
            searchTxt = new TextBox();
            panel1 = new Panel();
            dgvCTPN = new DataGridView();
            txtSuaSLSP = new TextBox();
            label5 = new Label();
            txtGiaNhap = new TextBox();
            txtSL = new TextBox();
            txtMaTH = new TextBox();
            dgvSP = new DataGridView();
            label4 = new Label();
            button7 = new Button();
            label3 = new Label();
            txtSearchSP = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnDeleteCTPN = new Button();
            btnAddCTPN = new Button();
            btnUpdateCTPN = new Button();
            txtMaSP = new TextBox();
            label1 = new Label();
            txtTotalPrice = new TextBox();
            label6 = new Label();
            labelsl = new Label();
            labelgn = new Label();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPN).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(dgvPN);
            panel4.Controls.Add(searchTxt);
            panel4.Location = new Point(192, 473);
            panel4.Name = "panel4";
            panel4.Size = new Size(1317, 399);
            panel4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImage = Resource.see;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Enabled = false;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(8, 8);
            button1.Name = "button1";
            button1.Size = new Size(85, 36);
            button1.TabIndex = 21;
            button1.Text = "Tìm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeletePN);
            groupBox2.Controls.Add(btnAddPN);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1112, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 283);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác phiếu nhập";
            // 
            // btnDeletePN
            // 
            btnDeletePN.BackColor = Color.DarkRed;
            btnDeletePN.BackgroundImage = Resource.delete;
            btnDeletePN.BackgroundImageLayout = ImageLayout.None;
            btnDeletePN.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeletePN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePN.ForeColor = SystemColors.ButtonFace;
            btnDeletePN.Location = new Point(40, 115);
            btnDeletePN.Name = "btnDeletePN";
            btnDeletePN.Size = new Size(119, 59);
            btnDeletePN.TabIndex = 20;
            btnDeletePN.Text = "Xóa";
            btnDeletePN.TextAlign = ContentAlignment.MiddleRight;
            btnDeletePN.UseVisualStyleBackColor = false;
            // 
            // btnAddPN
            // 
            btnAddPN.BackColor = Color.DarkGreen;
            btnAddPN.BackgroundImage = Resource.add;
            btnAddPN.BackgroundImageLayout = ImageLayout.None;
            btnAddPN.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAddPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPN.ForeColor = SystemColors.ButtonFace;
            btnAddPN.Location = new Point(40, 34);
            btnAddPN.Name = "btnAddPN";
            btnAddPN.Size = new Size(119, 59);
            btnAddPN.TabIndex = 19;
            btnAddPN.Text = "Thêm";
            btnAddPN.TextAlign = ContentAlignment.MiddleRight;
            btnAddPN.UseVisualStyleBackColor = false;
            // 
            // dgvPN
            // 
            dgvPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPN.BackgroundColor = SystemColors.ActiveCaption;
            dgvPN.BorderStyle = BorderStyle.Fixed3D;
            dgvPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPN.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPN.Location = new Point(3, 48);
            dgvPN.Name = "dgvPN";
            dgvPN.RowHeadersWidth = 51;
            dgvPN.Size = new Size(1103, 348);
            dgvPN.TabIndex = 6;
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.Location = new Point(107, 14);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Tìm kiếm bằng mã";
            searchTxt.Size = new Size(204, 28);
            searchTxt.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dgvCTPN);
            panel1.Controls.Add(txtSuaSLSP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGiaNhap);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(txtMaTH);
            panel1.Controls.Add(dgvSP);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSearchSP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelsl);
            panel1.Controls.Add(labelgn);
            panel1.Location = new Point(25, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1635, 425);
            panel1.TabIndex = 4;
            // 
            // dgvCTPN
            // 
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTPN.BackgroundColor = SystemColors.ActiveCaption;
            dgvCTPN.BorderStyle = BorderStyle.Fixed3D;
            dgvCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCTPN.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCTPN.Location = new Point(996, 70);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersWidth = 51;
            dgvCTPN.Size = new Size(612, 279);
            dgvCTPN.TabIndex = 33;
            // 
            // txtSuaSLSP
            // 
            txtSuaSLSP.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSuaSLSP.Location = new Point(1125, 366);
            txtSuaSLSP.Name = "txtSuaSLSP";
            txtSuaSLSP.Size = new Size(97, 39);
            txtSuaSLSP.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1302, 385);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 31;
            label5.Text = "Tổng tiền";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(167, 390);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(214, 27);
            txtGiaNhap.TabIndex = 30;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(591, 390);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(213, 27);
            txtSL.TabIndex = 29;
            // 
            // txtMaTH
            // 
            txtMaTH.Location = new Point(591, 351);
            txtMaTH.Name = "txtMaTH";
            txtMaTH.Size = new Size(213, 27);
            txtMaTH.TabIndex = 28;
            // 
            // dgvSP
            // 
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSP.BackgroundColor = SystemColors.ActiveCaption;
            dgvSP.BorderStyle = BorderStyle.Fixed3D;
            dgvSP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSP.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSP.Location = new Point(5, 70);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.Size = new Size(799, 274);
            dgvSP.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(410, 357);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 27;
            label4.Text = "Mã thương hiệu";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HotTrack;
            button7.BackgroundImage = Resource.see;
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Enabled = false;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(5, 3);
            button7.Name = "button7";
            button7.Size = new Size(85, 36);
            button7.TabIndex = 24;
            button7.Text = "Tìm";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 42);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 26;
            label3.Text = "Danh sách sản phẩm";
            // 
            // txtSearchSP
            // 
            txtSearchSP.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchSP.Location = new Point(96, 9);
            txtSearchSP.Name = "txtSearchSP";
            txtSearchSP.PlaceholderText = "Tìm kiếm bằng tên sản phẩm";
            txtSearchSP.Size = new Size(230, 28);
            txtSearchSP.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(992, 14);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 24;
            label2.Text = "Danh sách sản phẩm nhập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteCTPN);
            groupBox1.Controls.Add(btnAddCTPN);
            groupBox1.Controls.Add(btnUpdateCTPN);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(810, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 280);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác sản phẩm";
            // 
            // btnDeleteCTPN
            // 
            btnDeleteCTPN.BackColor = Color.DarkRed;
            btnDeleteCTPN.BackgroundImage = Resource.delete;
            btnDeleteCTPN.BackgroundImageLayout = ImageLayout.None;
            btnDeleteCTPN.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeleteCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCTPN.ForeColor = SystemColors.ButtonFace;
            btnDeleteCTPN.Location = new Point(29, 117);
            btnDeleteCTPN.Name = "btnDeleteCTPN";
            btnDeleteCTPN.Size = new Size(119, 59);
            btnDeleteCTPN.TabIndex = 20;
            btnDeleteCTPN.Text = "Xóa";
            btnDeleteCTPN.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteCTPN.UseVisualStyleBackColor = false;
            // 
            // btnAddCTPN
            // 
            btnAddCTPN.BackColor = Color.DarkGreen;
            btnAddCTPN.BackgroundImage = Resource.add;
            btnAddCTPN.BackgroundImageLayout = ImageLayout.None;
            btnAddCTPN.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAddCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCTPN.ForeColor = SystemColors.ButtonFace;
            btnAddCTPN.Location = new Point(29, 35);
            btnAddCTPN.Name = "btnAddCTPN";
            btnAddCTPN.Size = new Size(119, 59);
            btnAddCTPN.TabIndex = 19;
            btnAddCTPN.Text = "Thêm";
            btnAddCTPN.TextAlign = ContentAlignment.MiddleRight;
            btnAddCTPN.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCTPN
            // 
            btnUpdateCTPN.BackColor = Color.DarkCyan;
            btnUpdateCTPN.BackgroundImage = Resource.update2;
            btnUpdateCTPN.BackgroundImageLayout = ImageLayout.None;
            btnUpdateCTPN.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnUpdateCTPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCTPN.ForeColor = SystemColors.ButtonFace;
            btnUpdateCTPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateCTPN.Location = new Point(29, 197);
            btnUpdateCTPN.Name = "btnUpdateCTPN";
            btnUpdateCTPN.Size = new Size(119, 59);
            btnUpdateCTPN.TabIndex = 18;
            btnUpdateCTPN.Text = "Sửa";
            btnUpdateCTPN.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateCTPN.UseVisualStyleBackColor = false;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(167, 351);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(214, 27);
            txtMaSP.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 357);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 19;
            label1.Text = "Mã sản phẩm";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(1402, 366);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(230, 39);
            txtTotalPrice.TabIndex = 11;
            txtTotalPrice.TextChanged += txtTotalPrice_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(996, 386);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 10;
            label6.Text = "Sửa số lượng";
            // 
            // labelsl
            // 
            labelsl.AutoSize = true;
            labelsl.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            labelsl.ForeColor = Color.Black;
            labelsl.Location = new Point(410, 395);
            labelsl.Name = "labelsl";
            labelsl.Size = new Size(137, 25);
            labelsl.TabIndex = 4;
            labelsl.Text = "Nhập số lượng";
            // 
            // labelgn
            // 
            labelgn.AutoSize = true;
            labelgn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            labelgn.ForeColor = Color.Black;
            labelgn.Location = new Point(24, 395);
            labelgn.Name = "labelgn";
            labelgn.Size = new Size(137, 25);
            labelgn.TabIndex = 2;
            labelgn.Text = "Nhập giá nhập";
            // 
            // ImportReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 893);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "ImportReceiptForm";
            Text = "ImportReceiptForm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPN).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox searchTxt;
        private Panel panel1;
        private TextBox txtTotalPrice;
        private Label label6;
        private TextBox txtCustomerName;
        private Label labelsl;
        private TextBox txtSDT;
        private Label labelgn;
        private DataGridView dgvPN;
        private TextBox txtMaSP;
        private Label label1;
        private GroupBox groupBox1;
        private Controls.Button.Create createBtn;
        private Controls.Button.Delete deleteBtn;
        private Button btnUpdateCTPN;
        private Button btnAddCTPN;
        private Button btnDeleteCTPN;
        private GroupBox groupBox2;
        private Button btnDeletePN;
        private Button btnAddPN;
        private Label label2;
        private Button button1;
        private Label label4;
        private Button button7;
        private Label label3;
        private TextBox txtSearchSP;
        private DataGridView dgvSP;
        private TextBox txtMaTH;
        private TextBox txtSL;
        private TextBox txtGiaNhap;
        private TextBox txtSuaSLSP;
        private Label label5;
        private DataGridView dgvCTPN;
    }
}