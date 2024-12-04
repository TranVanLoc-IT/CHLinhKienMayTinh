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
            panel4 = new Panel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            dgvPN = new DataGridView();
            searchTxt = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button7 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            txtTenSP = new TextBox();
            label1 = new Label();
            dgvCTPN = new DataGridView();
            txtTotalPrice = new TextBox();
            label6 = new Label();
            txtCustomerName = new TextBox();
            txtSL = new Label();
            txtSDT = new TextBox();
            txtGiaNhap = new Label();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPN).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
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
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1112, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 283);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác phiếu nhập";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkRed;
            button5.BackgroundImage = Resource.delete;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(40, 115);
            button5.Name = "button5";
            button5.Size = new Size(119, 59);
            button5.TabIndex = 20;
            button5.Text = "Xóa";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGreen;
            button6.BackgroundImage = Resource.add;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.MouseOverBackColor = Color.Green;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(40, 34);
            button6.Name = "button6";
            button6.Size = new Size(119, 59);
            button6.TabIndex = 19;
            button6.Text = "Thêm";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvCTPN);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtGiaNhap);
            panel1.Location = new Point(25, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1635, 425);
            panel1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(541, 350);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(414, 353);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 27;
            label4.Text = "Thương hiệu";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HotTrack;
            button7.BackgroundImage = Resource.see;
            button7.BackgroundImageLayout = ImageLayout.None;
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
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(96, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm bằng tên sản phẩm";
            textBox1.Size = new Size(230, 28);
            textBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(8, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 274);
            dataGridView1.TabIndex = 25;
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
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(810, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 280);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác sản phẩm";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.BackgroundImage = Resource.delete;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(29, 117);
            button4.Name = "button4";
            button4.Size = new Size(119, 59);
            button4.TabIndex = 20;
            button4.Text = "Xóa";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGreen;
            button3.BackgroundImage = Resource.add;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.MouseOverBackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(29, 35);
            button3.Name = "button3";
            button3.Size = new Size(119, 59);
            button3.TabIndex = 19;
            button3.Text = "Thêm";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.BackgroundImage = Resource.update2;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(29, 197);
            button2.Name = "button2";
            button2.Size = new Size(119, 59);
            button2.TabIndex = 18;
            button2.Text = "Sửa";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(167, 351);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(214, 27);
            txtTenSP.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 353);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 19;
            label1.Text = "Mã sản phẩm";
            // 
            // dgvCTPN
            // 
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCTPN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTPN.BackgroundColor = SystemColors.ActiveCaption;
            dgvCTPN.BorderStyle = BorderStyle.Fixed3D;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPN.GridColor = SystemColors.HotTrack;
            dgvCTPN.Location = new Point(992, 42);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersWidth = 51;
            dgvCTPN.Size = new Size(640, 302);
            dgvCTPN.TabIndex = 17;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(1093, 358);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(230, 39);
            txtTotalPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(993, 366);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(541, 393);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(213, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // txtSL
            // 
            txtSL.AutoSize = true;
            txtSL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtSL.ForeColor = Color.Black;
            txtSL.Location = new Point(398, 392);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(137, 25);
            txtSL.TabIndex = 4;
            txtSL.Text = "Nhập số lượng";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(167, 390);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(214, 27);
            txtSDT.TabIndex = 3;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.AutoSize = true;
            txtGiaNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtGiaNhap.ForeColor = Color.Black;
            txtGiaNhap.Location = new Point(24, 389);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(137, 25);
            txtGiaNhap.TabIndex = 2;
            txtGiaNhap.Text = "Nhập giá nhập";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox searchTxt;
        private Panel panel1;
        private DataGridView dgvCTPN;
        private TextBox txtTotalPrice;
        private Label label6;
        private TextBox txtCustomerName;
        private Label txtSL;
        private TextBox txtSDT;
        private Label txtGiaNhap;
        private DataGridView dgvPN;
        private TextBox txtTenSP;
        private Label label1;
        private GroupBox groupBox1;
        private Controls.Button.Create createBtn;
        private Controls.Button.Delete deleteBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
        private Button button7;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}