namespace PM_LKMT.SubForm
{
    partial class HandleOrderProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleOrderProcessForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            orderStepBtn = new Button();
            paymentStepBtn = new Button();
            completeStepBtn = new Button();
            nextBtn = new Button();
            panel1 = new Panel();
            frame = new Panel();
            panel3 = new Panel();
            dataGrid = new DataGridView();
            panel2 = new Panel();
            refreshBtn = new Button();
            button10 = new Button();
            txtKM = new TextBox();
            txtPricePayment = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            cancelBtn = new Button();
            deleteBtn = new Button();
            searchtxt = new TextBox();
            cbFilter = new ComboBox();
            txtTotalPriceDiscount = new TextBox();
            label6 = new Label();
            txtPriceBefore = new TextBox();
            label5 = new Label();
            txtMaDH = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            sdt = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            frame.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(orderStepBtn);
            flowLayoutPanel1.Controls.Add(paymentStepBtn);
            flowLayoutPanel1.Controls.Add(completeStepBtn);
            flowLayoutPanel1.Controls.Add(nextBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1016, 56);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // orderStepBtn
            // 
            orderStepBtn.BackColor = Color.Orange;
            orderStepBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            orderStepBtn.ForeColor = SystemColors.ButtonFace;
            orderStepBtn.Location = new Point(0, 0);
            orderStepBtn.Margin = new Padding(0);
            orderStepBtn.Name = "orderStepBtn";
            orderStepBtn.Size = new Size(150, 53);
            orderStepBtn.TabIndex = 0;
            orderStepBtn.Text = "Thông tin đơn hàng";
            orderStepBtn.UseVisualStyleBackColor = false;
            // 
            // paymentStepBtn
            // 
            paymentStepBtn.Enabled = false;
            paymentStepBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            paymentStepBtn.Location = new Point(150, 0);
            paymentStepBtn.Margin = new Padding(0);
            paymentStepBtn.Name = "paymentStepBtn";
            paymentStepBtn.Size = new Size(150, 53);
            paymentStepBtn.TabIndex = 2;
            paymentStepBtn.Text = "Thanh toán";
            paymentStepBtn.UseVisualStyleBackColor = true;
            // 
            // completeStepBtn
            // 
            completeStepBtn.Enabled = false;
            completeStepBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            completeStepBtn.Location = new Point(300, 0);
            completeStepBtn.Margin = new Padding(0);
            completeStepBtn.Name = "completeStepBtn";
            completeStepBtn.Size = new Size(150, 53);
            completeStepBtn.TabIndex = 3;
            completeStepBtn.Text = "Hoàn tất";
            completeStepBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.BackgroundImage = Resource.right;
            nextBtn.BackgroundImageLayout = ImageLayout.Stretch;
            nextBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            nextBtn.FlatAppearance.MouseOverBackColor = Color.Green;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Location = new Point(453, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(57, 50);
            nextBtn.TabIndex = 40;
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(frame);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 589);
            panel1.TabIndex = 0;
            // 
            // frame
            // 
            frame.Controls.Add(panel3);
            frame.Controls.Add(panel2);
            frame.Dock = DockStyle.Fill;
            frame.Location = new Point(0, 56);
            frame.Name = "frame";
            frame.Size = new Size(1016, 533);
            frame.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGrid);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 196);
            panel3.TabIndex = 25;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.Dock = DockStyle.Bottom;
            dataGrid.Location = new Point(0, -462);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1016, 658);
            dataGrid.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(sdt);
            panel2.Controls.Add(refreshBtn);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(txtKM);
            panel2.Controls.Add(txtPricePayment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(searchtxt);
            panel2.Controls.Add(cbFilter);
            panel2.Controls.Add(txtTotalPriceDiscount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPriceBefore);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtMaDH);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 334);
            panel2.TabIndex = 24;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshBtn.BackgroundImage = (Image)resources.GetObject("refreshBtn.BackgroundImage");
            refreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            refreshBtn.FlatAppearance.MouseOverBackColor = Color.Aqua;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Location = new Point(935, 281);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(57, 50);
            refreshBtn.TabIndex = 55;
            refreshBtn.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackColor = Color.Peru;
            button10.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(922, 7);
            button10.Name = "button10";
            button10.Size = new Size(94, 51);
            button10.TabIndex = 53;
            button10.Text = "Áp dụng ngay";
            button10.UseVisualStyleBackColor = false;
            // 
            // txtKM
            // 
            txtKM.BorderStyle = BorderStyle.None;
            txtKM.Font = new Font("Times New Roman", 13.8F);
            txtKM.Location = new Point(631, 7);
            txtKM.Multiline = true;
            txtKM.Name = "txtKM";
            txtKM.PlaceholderText = "Khuyến mãi khi đủ điều kiện";
            txtKM.Size = new Size(285, 51);
            txtKM.TabIndex = 52;
            // 
            // txtPricePayment
            // 
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Enabled = false;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.Location = new Point(15, 271);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(316, 27);
            txtPricePayment.TabIndex = 47;
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 245);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 46;
            label2.Text = "Tổng tiền phải chi trả";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(452, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 197);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các sản phẩm mua";
            // 
            // flowPanel
            // 
            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(546, 164);
            flowPanel.TabIndex = 46;
            // 
            // cancelBtn
            // 
            cancelBtn.BackgroundImage = (Image)resources.GetObject("cancelBtn.BackgroundImage");
            cancelBtn.BackgroundImageLayout = ImageLayout.Stretch;
            cancelBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Location = new Point(478, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(57, 50);
            cancelBtn.TabIndex = 44;
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.BackgroundImage = (Image)resources.GetObject("deleteBtn.BackgroundImage");
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(545, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(57, 50);
            deleteBtn.TabIndex = 43;
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            searchtxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchtxt.Font = new Font("Times New Roman", 13.8F);
            searchtxt.Location = new Point(455, 297);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Nhập mã đơn hàng để tìm";
            searchtxt.Size = new Size(312, 34);
            searchtxt.TabIndex = 37;
            // 
            // cbFilter
            // 
            cbFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbFilter.Font = new Font("Times New Roman", 13.8F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(773, 297);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(144, 34);
            cbFilter.TabIndex = 35;
            // 
            // txtTotalPriceDiscount
            // 
            txtTotalPriceDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalPriceDiscount.BorderStyle = BorderStyle.None;
            txtTotalPriceDiscount.Font = new Font("Times New Roman", 13.8F);
            txtTotalPriceDiscount.Location = new Point(192, 200);
            txtTotalPriceDiscount.Name = "txtTotalPriceDiscount";
            txtTotalPriceDiscount.Size = new Size(188, 27);
            txtTotalPriceDiscount.TabIndex = 31;
            txtTotalPriceDiscount.Text = "0";
            txtTotalPriceDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 30;
            label6.Text = "Giảm";
            // 
            // txtPriceBefore
            // 
            txtPriceBefore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceBefore.BorderStyle = BorderStyle.None;
            txtPriceBefore.Font = new Font("Times New Roman", 13.8F);
            txtPriceBefore.Location = new Point(192, 156);
            txtPriceBefore.Name = "txtPriceBefore";
            txtPriceBefore.Size = new Size(188, 27);
            txtPriceBefore.TabIndex = 29;
            txtPriceBefore.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(12, 169);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 28;
            label5.Text = "Thành tiền";
            // 
            // txtMaDH
            // 
            txtMaDH.BorderStyle = BorderStyle.FixedSingle;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaDH.Location = new Point(192, 24);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(234, 34);
            txtMaDH.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 18;
            label1.Text = "Mã đơn hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 85;
            label3.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(192, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 27);
            txtName.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(15, 124);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 83;
            label4.Text = "Số điện thoại";
            // 
            // sdt
            // 
            sdt.BorderStyle = BorderStyle.None;
            sdt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            sdt.Location = new Point(192, 114);
            sdt.Name = "sdt";
            sdt.Size = new Size(234, 27);
            sdt.TabIndex = 82;
            // 
            // HandleOrderProcessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 589);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HandleOrderProcessForm";
            Text = "OrderForm";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            frame.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button orderStepBtn;
        private Button paymentStepBtn;
        private Button completeStepBtn;
        private Panel panel1;
        private Panel frame;
        private Panel panel3;
        private Panel panel2;
        private Button nextBtn;
        private Button button10;
        private TextBox txtKM;
        private TextBox txtPricePayment;
        private Label label2;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private Button cancelBtn;
        private Button deleteBtn;
        private TextBox searchtxt;
        private ComboBox cbFilter;
        private TextBox txtTotalPriceDiscount;
        private Label label6;
        private TextBox txtPriceBefore;
        private Label label5;
        private TextBox txtMaDH;
        private Label label1;
        private DataGridView dataGrid;
        private Button refreshBtn;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox sdt;
    }
}