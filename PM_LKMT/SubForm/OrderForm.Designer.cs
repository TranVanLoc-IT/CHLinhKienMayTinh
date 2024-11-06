namespace PM_LKMT.SubForm
{
    partial class OrderForm
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
            panel1 = new Panel();
            deleteBtn = new Controls.Button.Delete();
            createBtn = new Controls.Button.Create();
            productSelectedList = new ListBox();
            txtTotalPrice = new TextBox();
            label6 = new Label();
            txtTotalQuantity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            label2 = new Label();
            txtMaHD = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            txtSLDB = new TextBox();
            label11 = new Label();
            txtSLC = new TextBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            addBtn = new Controls.Button.Add();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            cancelBtn = new Controls.Button.Cancel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(productSelectedList);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtTotalQuantity);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 506);
            panel1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(171, 423);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(120, 61);
            deleteBtn.TabIndex = 13;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(43, 426);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(122, 59);
            createBtn.TabIndex = 13;
            // 
            // productSelectedList
            // 
            productSelectedList.FormattingEnabled = true;
            productSelectedList.Location = new Point(176, 214);
            productSelectedList.Name = "productSelectedList";
            productSelectedList.Size = new Size(259, 144);
            productSelectedList.TabIndex = 12;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(276, 379);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(159, 25);
            txtTotalPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(176, 382);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(118, 376);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.Size = new Size(47, 27);
            txtTotalQuantity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(34, 382);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 8;
            label5.Text = "Tổng SL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 206);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 6;
            label4.Text = "Sản phẩm mua";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(193, 141);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(242, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 146);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên khách hàng";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(171, 81);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(216, 27);
            txtSDT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 86);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtMaHD
            // 
            txtMaHD.Enabled = false;
            txtMaHD.Location = new Point(161, 33);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(284, 27);
            txtMaHD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(448, 318);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(479, 188);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(451, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 318);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSLDB);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtSLC);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(292, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 164);
            panel3.TabIndex = 2;
            // 
            // txtSLDB
            // 
            txtSLDB.Location = new Point(8, 118);
            txtSLDB.Name = "txtSLDB";
            txtSLDB.Size = new Size(143, 30);
            txtSLDB.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(8, 90);
            label11.Name = "label11";
            label11.Size = new Size(151, 25);
            label11.TabIndex = 12;
            label11.Text = "Số lượng đã bán";
            // 
            // txtSLC
            // 
            txtSLC.Location = new Point(8, 38);
            txtSLC.Name = "txtSLC";
            txtSLC.Size = new Size(143, 30);
            txtSLC.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(8, 10);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 10;
            label9.Text = "Số lượng còn";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(3, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 164);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 125);
            panel2.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(337, 54);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(130, 66);
            addBtn.TabIndex = 12;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(157, 90);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(69, 30);
            textBox9.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(12, 99);
            label10.Name = "label10";
            label10.Size = new Size(137, 25);
            label10.TabIndex = 10;
            label10.Text = "Nhập số lượng";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 30);
            textBox4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(10, 63);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 6;
            label7.Text = "Giá bán";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(145, 15);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(269, 30);
            textBox7.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(10, 20);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 4;
            label8.Text = "Tên sản phẩm";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(297, 423);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(124, 68);
            cancelBtn.TabIndex = 14;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 506);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMaHD;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtSDT;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtTotalPrice;
        private Label label6;
        private TextBox txtTotalQuantity;
        private Label label5;
        private ListBox productSelectedList;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox txtSLDB;
        private Label label11;
        private TextBox txtSLC;
        private Label label9;
        private Controls.Button.Delete deleteBtn;
        private Controls.Button.Create createBtn;
        private Controls.Button.Add addBtn;
        private Controls.Button.Cancel cancelBtn;
    }
}