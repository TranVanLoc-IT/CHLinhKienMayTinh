namespace PM_LKMT.SubForm
{
    partial class PaymentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maGd = new TextBox();
            groupBox1 = new GroupBox();
            btnScan = new Button();
            label5 = new Label();
            cbPt = new ComboBox();
            label4 = new Label();
            txtMoney = new TextBox();
            label3 = new Label();
            cbNh = new ComboBox();
            btnPay = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // maGd
            // 
            maGd.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maGd.Location = new Point(30, 33);
            maGd.Name = "maGd";
            maGd.PlaceholderText = "Nhập mã giao dịch";
            maGd.Size = new Size(453, 34);
            maGd.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnScan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbPt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMoney);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbNh);
            groupBox1.Controls.Add(btnPay);
            groupBox1.Controls.Add(maGd);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 253);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thanh toán";
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.WindowFrame;
            btnScan.ForeColor = SystemColors.ButtonFace;
            btnScan.Location = new Point(539, 20);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(120, 47);
            btnScan.TabIndex = 41;
            btnScan.Text = "Scan QR";
            btnScan.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 91);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 39;
            label5.Text = "Phương thức";
            // 
            // cbPt
            // 
            cbPt.FormattingEnabled = true;
            cbPt.Location = new Point(176, 80);
            cbPt.Name = "cbPt";
            cbPt.Size = new Size(206, 33);
            cbPt.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 191);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 37;
            label4.Text = "Chi trả";
            // 
            // txtMoney
            // 
            txtMoney.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMoney.Location = new Point(178, 181);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(238, 34);
            txtMoney.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 139);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 35;
            label3.Text = "Ngân hàng";
            // 
            // cbNh
            // 
            cbNh.FormattingEnabled = true;
            cbNh.Items.AddRange(new object[] { "Ngân hàng quân đội (MB Bank)", "Ví điện tử Momo", "Ngân hàng ngoại thương (OCB)", "Ngân hàng Vietcombank", "Ngân hàng Vietinbank", "Ngân hàng Bản Việt" });
            cbNh.Location = new Point(178, 129);
            cbNh.Name = "cbNh";
            cbNh.Size = new Size(206, 33);
            cbNh.TabIndex = 34;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.BackColor = Color.Green;
            btnPay.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(539, 159);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(163, 58);
            btnPay.TabIndex = 32;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // PaymentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "PaymentControl";
            Size = new Size(813, 253);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox maGd;
        private GroupBox groupBox1;
        private ComboBox cbNh;
        private Button btnPay;
        private Label label5;
        private ComboBox cbPt;
        private Label label4;
        private TextBox txtMoney;
        private Label label3;
        private Button btnScan;
    }
}
