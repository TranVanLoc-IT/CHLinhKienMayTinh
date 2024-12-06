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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleOrderProcessForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            orderStepBtn = new Button();
            completeStepBtn = new Button();
            cplBtn = new Button();
            panel1 = new Panel();
            frame = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            leftMoney = new TextBox();
            recieveMoney = new TextBox();
            label7 = new Label();
            cbPt = new ComboBox();
            cbNh = new ComboBox();
            maGd = new TextBox();
            txtTotalPriceDiscount = new TextBox();
            label6 = new Label();
            dataGrid = new DataGridView();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            sdt = new TextBox();
            refreshBtn = new Button();
            useKM = new Button();
            btnPay = new Button();
            txtKM = new TextBox();
            txtPricePayment = new TextBox();
            label2 = new Label();
            txtPriceBefore = new TextBox();
            label5 = new Label();
            txtMaDH = new TextBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            frame.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(orderStepBtn);
            flowLayoutPanel1.Controls.Add(completeStepBtn);
            flowLayoutPanel1.Controls.Add(cplBtn);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1016, 57);
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
            orderStepBtn.Text = "Xử lý đơn hàng";
            orderStepBtn.UseVisualStyleBackColor = false;
            // 
            // completeStepBtn
            // 
            completeStepBtn.Enabled = false;
            completeStepBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            completeStepBtn.Location = new Point(150, 0);
            completeStepBtn.Margin = new Padding(0);
            completeStepBtn.Name = "completeStepBtn";
            completeStepBtn.Size = new Size(150, 53);
            completeStepBtn.TabIndex = 3;
            completeStepBtn.Text = "Hoàn tất";
            completeStepBtn.UseVisualStyleBackColor = true;
            // 
            // cplBtn
            // 
            cplBtn.BackgroundImage = (Image)resources.GetObject("cplBtn.BackgroundImage");
            cplBtn.BackgroundImageLayout = ImageLayout.Center;
            cplBtn.Enabled = false;
            cplBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            cplBtn.FlatAppearance.MouseOverBackColor = Color.Green;
            cplBtn.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic);
            cplBtn.Location = new Point(300, 0);
            cplBtn.Margin = new Padding(0);
            cplBtn.Name = "cplBtn";
            cplBtn.Size = new Size(71, 53);
            cplBtn.TabIndex = 4;
            cplBtn.UseVisualStyleBackColor = true;
            cplBtn.Click += button2_Click;
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
            frame.Controls.Add(panel2);
            frame.Dock = DockStyle.Fill;
            frame.Location = new Point(0, 57);
            frame.Name = "frame";
            frame.Size = new Size(1016, 532);
            frame.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(txtTotalPriceDiscount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGrid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(sdt);
            panel2.Controls.Add(refreshBtn);
            panel2.Controls.Add(useKM);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(txtKM);
            panel2.Controls.Add(txtPricePayment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtPriceBefore);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtMaDH);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 532);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 532);
            panel3.TabIndex = 94;
            panel3.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(416, 314);
            button1.Name = "button1";
            button1.Size = new Size(57, 50);
            button1.TabIndex = 93;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Font = new Font("Times New Roman", 13.8F);
            groupBox1.Location = new Point(18, 430);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 90);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các sản phẩm mua";
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(449, 57);
            flowPanel.TabIndex = 46;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(leftMoney);
            groupBox2.Controls.Add(recieveMoney);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbPt);
            groupBox2.Controls.Add(cbNh);
            groupBox2.Controls.Add(maGd);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox2.Location = new Point(509, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 177);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thanh toán";
            // 
            // leftMoney
            // 
            leftMoney.Enabled = false;
            leftMoney.Font = new Font("Times New Roman", 13.8F);
            leftMoney.Location = new Point(296, 126);
            leftMoney.Name = "leftMoney";
            leftMoney.PlaceholderText = "Tiền trả lại";
            leftMoney.Size = new Size(248, 34);
            leftMoney.TabIndex = 41;
            leftMoney.TextAlign = HorizontalAlignment.Right;
            // 
            // recieveMoney
            // 
            recieveMoney.Font = new Font("Times New Roman", 13.8F);
            recieveMoney.Location = new Point(30, 126);
            recieveMoney.Name = "recieveMoney";
            recieveMoney.PlaceholderText = "Tiền nhận";
            recieveMoney.Size = new Size(248, 34);
            recieveMoney.TabIndex = 40;
            recieveMoney.TextAlign = HorizontalAlignment.Right;
            recieveMoney.KeyDown += recieveMoney_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 91);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 39;
            label7.Text = "Phương thức";
            // 
            // cbPt
            // 
            cbPt.FormattingEnabled = true;
            cbPt.Location = new Point(176, 80);
            cbPt.Name = "cbPt";
            cbPt.Size = new Size(206, 33);
            cbPt.TabIndex = 38;
            cbPt.SelectedIndexChanged += cbPt_SelectedIndexChanged_1;
            // 
            // cbNh
            // 
            cbNh.Enabled = false;
            cbNh.FormattingEnabled = true;
            cbNh.Items.AddRange(new object[] { "Chọn", "Ngân hàng quân đội (MB Bank)", "Ví điện tử Momo", "Ngân hàng ngoại thương (OCB)", "Ngân hàng Vietcombank", "Ngân hàng Vietinbank", "Ngân hàng Bản Việt" });
            cbNh.Location = new Point(388, 80);
            cbNh.Name = "cbNh";
            cbNh.Size = new Size(250, 33);
            cbNh.TabIndex = 34;
            cbNh.Text = "Chọn ngân hàng";
            // 
            // maGd
            // 
            maGd.Font = new Font("Times New Roman", 13.8F);
            maGd.Location = new Point(30, 33);
            maGd.Name = "maGd";
            maGd.PlaceholderText = "Nhập mã giao dịch";
            maGd.Size = new Size(354, 34);
            maGd.TabIndex = 27;
            // 
            // txtTotalPriceDiscount
            // 
            txtTotalPriceDiscount.BorderStyle = BorderStyle.None;
            txtTotalPriceDiscount.Enabled = false;
            txtTotalPriceDiscount.Font = new Font("Times New Roman", 13.8F);
            txtTotalPriceDiscount.ForeColor = Color.Green;
            txtTotalPriceDiscount.Location = new Point(192, 269);
            txtTotalPriceDiscount.Name = "txtTotalPriceDiscount";
            txtTotalPriceDiscount.Size = new Size(281, 27);
            txtTotalPriceDiscount.TabIndex = 89;
            txtTotalPriceDiscount.Text = "0 VND";
            txtTotalPriceDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(15, 276);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 88;
            label6.Text = "Giảm";
            // 
            // dataGrid
            // 
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.Location = new Point(509, 259);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(507, 258);
            dataGrid.TabIndex = 87;
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
            txtName.Enabled = false;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(223, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
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
            sdt.Enabled = false;
            sdt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            sdt.Location = new Point(223, 114);
            sdt.Name = "sdt";
            sdt.Size = new Size(250, 27);
            sdt.TabIndex = 82;
            sdt.TextAlign = HorizontalAlignment.Right;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshBtn.BackgroundImage = (Image)resources.GetObject("refreshBtn.BackgroundImage");
            refreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            refreshBtn.FlatAppearance.MouseOverBackColor = Color.Aqua;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Location = new Point(959, 203);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(57, 50);
            refreshBtn.TabIndex = 55;
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // useKM
            // 
            useKM.BackColor = Color.Peru;
            useKM.Enabled = false;
            useKM.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            useKM.ForeColor = SystemColors.ButtonHighlight;
            useKM.Location = new Point(379, 202);
            useKM.Name = "useKM";
            useKM.Size = new Size(94, 51);
            useKM.TabIndex = 53;
            useKM.Text = "Áp dụng ngay";
            useKM.UseVisualStyleBackColor = false;
            useKM.Click += button10_Click_1;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Green;
            btnPay.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(18, 370);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(455, 55);
            btnPay.TabIndex = 32;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // txtKM
            // 
            txtKM.BorderStyle = BorderStyle.None;
            txtKM.Enabled = false;
            txtKM.Font = new Font("Times New Roman", 13.8F);
            txtKM.Location = new Point(21, 202);
            txtKM.Multiline = true;
            txtKM.Name = "txtKM";
            txtKM.PlaceholderText = "Khuyến mãi khi đủ điều kiện";
            txtKM.Size = new Size(352, 51);
            txtKM.TabIndex = 52;
            // 
            // txtPricePayment
            // 
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Enabled = false;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.ForeColor = Color.Red;
            txtPricePayment.Location = new Point(18, 337);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(392, 27);
            txtPricePayment.TabIndex = 47;
            txtPricePayment.Text = "0 VND";
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            txtPricePayment.TextChanged += txtPricePayment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(15, 311);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 46;
            label2.Text = "Số tiền thanh toán";
            // 
            // txtPriceBefore
            // 
            txtPriceBefore.BorderStyle = BorderStyle.None;
            txtPriceBefore.Enabled = false;
            txtPriceBefore.Font = new Font("Times New Roman", 13.8F);
            txtPriceBefore.Location = new Point(223, 161);
            txtPriceBefore.Name = "txtPriceBefore";
            txtPriceBefore.Size = new Size(250, 27);
            txtPriceBefore.TabIndex = 29;
            txtPriceBefore.Text = "0 VND";
            txtPriceBefore.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 169);
            label5.Name = "label5";
            label5.Size = new Size(204, 25);
            label5.TabIndex = 28;
            label5.Text = "Tổng tiền gồm VAT";
            // 
            // txtMaDH
            // 
            txtMaDH.BorderStyle = BorderStyle.FixedSingle;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtMaDH.Location = new Point(223, 17);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(250, 34);
            txtMaDH.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 18;
            label1.Text = "Mã đơn hàng";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button orderStepBtn;
        private Button completeStepBtn;
        private Panel panel1;
        private Panel frame;
        private Panel panel2;
        private TextBox txtTotalPriceDiscount;
        private Label label6;
        private DataGridView dataGrid;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox sdt;
        private Button btnPay;
        private TextBox txtPricePayment;
        private Label label2;
        private TextBox txtPriceBefore;
        private Label label5;
        private TextBox txtMaDH;
        private Label label1;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private GroupBox groupBox2;
        private TextBox leftMoney;
        private TextBox recieveMoney;
        private Label label7;
        private ComboBox cbPt;
        private ComboBox cbNh;
        private TextBox maGd;
        private Button refreshBtn;
        private Button button1;
        private Button cplBtn;
        private Panel panel3;
        private Button useKM;
        private TextBox txtKM;
    }
}