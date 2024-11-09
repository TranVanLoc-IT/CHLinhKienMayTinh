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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            gridProductSelected = new DataGridView();
            txtNote = new RichTextBox();
            label12 = new Label();
            cancelBtn = new Controls.Button.Cancel();
            deleteBtn = new Controls.Button.Delete();
            createBtn = new Controls.Button.Create();
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
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            txtTH = new TextBox();
            label11 = new Label();
            txtSLC = new TextBox();
            label9 = new Label();
            img = new PictureBox();
            panel2 = new Panel();
            addBtn = new Controls.Button.Add();
            txtQuantity = new TextBox();
            label10 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtProductName = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            searchTxt = new TextBox();
            comboTable = new ComboBox();
            label14 = new Label();
            dataGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductSelected).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(gridProductSelected);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(createBtn);
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
            panel1.Size = new Size(448, 589);
            panel1.TabIndex = 0;
            // 
            // gridProductSelected
            // 
            gridProductSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridProductSelected.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridProductSelected.BackgroundColor = SystemColors.ActiveCaption;
            gridProductSelected.BorderStyle = BorderStyle.Fixed3D;
            gridProductSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductSelected.GridColor = SystemColors.HotTrack;
            gridProductSelected.Location = new Point(183, 216);
            gridProductSelected.Name = "gridProductSelected";
            gridProductSelected.RowHeadersWidth = 51;
            gridProductSelected.Size = new Size(259, 142);
            gridProductSelected.TabIndex = 17;
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.ForeColor = Color.Red;
            txtNote.Location = new Point(124, 364);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(304, 87);
            txtNote.TabIndex = 16;
            txtNote.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(41, 379);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 15;
            label12.Text = "Ghi chú";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(304, 504);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(124, 62);
            cancelBtn.TabIndex = 14;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(178, 504);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(120, 61);
            deleteBtn.TabIndex = 13;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(50, 507);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(122, 59);
            createBtn.TabIndex = 13;
            createBtn.Click += createBtn_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(283, 460);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(159, 25);
            txtTotalPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(183, 463);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(125, 457);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.Size = new Size(47, 27);
            txtTotalQuantity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 463);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(img);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(448, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 290);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTH);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtSLC);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(262, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 136);
            panel3.TabIndex = 2;
            // 
            // txtTH
            // 
            txtTH.Location = new Point(8, 99);
            txtTH.Name = "txtTH";
            txtTH.Size = new Size(143, 30);
            txtTH.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(8, 71);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 12;
            label11.Text = "Thương hiệu";
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
            // img
            // 
            img.Dock = DockStyle.Left;
            img.Location = new Point(3, 26);
            img.Name = "img";
            img.Size = new Size(253, 136);
            img.TabIndex = 1;
            img.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 125);
            panel2.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(337, 54);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(130, 66);
            addBtn.TabIndex = 12;
            addBtn.Click += addToCartBtn_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(157, 90);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(69, 30);
            txtQuantity.TabIndex = 11;
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
            // txtPrice
            // 
            txtPrice.Location = new Point(93, 54);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 30);
            txtPrice.TabIndex = 7;
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
            // txtProductName
            // 
            txtProductName.Location = new Point(145, 15);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(319, 30);
            txtProductName.TabIndex = 5;
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
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(searchTxt);
            panel4.Controls.Add(comboTable);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(dataGrid);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(448, 290);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 299);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImage = Resource.see;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(22, 248);
            button1.Name = "button1";
            button1.Size = new Size(85, 36);
            button1.TabIndex = 13;
            button1.Text = "Tìm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // searchTxt
            // 
            searchTxt.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxt.Location = new Point(112, 254);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Tìm kiếm bằng mã hoặc tên";
            searchTxt.Size = new Size(176, 28);
            searchTxt.TabIndex = 12;
            searchTxt.TextChanged += searchTxt_TextChanged;
            // 
            // comboTable
            // 
            comboTable.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTable.FormattingEnabled = true;
            comboTable.Items.AddRange(new object[] { "Đơn hàng", "Sản phẩm" });
            comboTable.Location = new Point(370, 254);
            comboTable.Name = "comboTable";
            comboTable.Size = new Size(109, 28);
            comboTable.TabIndex = 7;
            comboTable.SelectedIndexChanged += comboTable_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(299, 254);
            label14.Name = "label14";
            label14.Size = new Size(56, 25);
            label14.TabIndex = 6;
            label14.Text = "Bảng";
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.Dock = DockStyle.Top;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(479, 232);
            dataGrid.TabIndex = 0;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 589);
            Controls.Add(panel4);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductSelected).EndInit();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMaHD;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtSDT;
        private Label label2;
        private PictureBox img;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtTotalPrice;
        private Label label6;
        private TextBox txtTotalQuantity;
        private Label label5;
        private TextBox txtQuantity;
        private Label label10;
        private TextBox txtPrice;
        private Label label7;
        private TextBox txtProductName;
        private Label label8;
        private TextBox txtTH;
        private Label label11;
        private TextBox txtSLC;
        private Label label9;
        private Controls.Button.Delete deleteBtn;
        private Controls.Button.Create createBtn;
        private Controls.Button.Add addBtn;
        private Controls.Button.Cancel cancelBtn;
        private RichTextBox txtNote;
        private Label label12;
        private Panel panel4;
        private DataGridView dataGrid;
        private ComboBox comboTable;
        private Label label14;
        private DataGridView gridProductSelected;
        private TextBox searchTxt;
        private Button button1;
    }
}