namespace PM_LKMT.SubForm
{
    partial class OrderResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderResult));
            label1 = new Label();
            panel1 = new Panel();
            customerInfoTxt = new TextBox();
            label4 = new Label();
            txtStatus = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            txtPricePayment = new TextBox();
            btnPrint = new Button();
            label2 = new Label();
            btnComplete = new Button();
            txtTotalPriceDiscount = new TextBox();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            label6 = new Label();
            label3 = new Label();
            txtPriceBefore = new TextBox();
            txtMaDH = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(192, 23);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông tin đơn hàng đã xử lý";
            // 
            // panel1
            // 
            panel1.Controls.Add(customerInfoTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtPricePayment);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnComplete);
            panel1.Controls.Add(txtTotalPriceDiscount);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPriceBefore);
            panel1.Controls.Add(txtMaDH);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 326);
            panel1.TabIndex = 1;
            // 
            // customerInfoTxt
            // 
            customerInfoTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customerInfoTxt.BorderStyle = BorderStyle.None;
            customerInfoTxt.Font = new Font("Times New Roman", 13.8F);
            customerInfoTxt.Location = new Point(15, 283);
            customerInfoTxt.Name = "customerInfoTxt";
            customerInfoTxt.Size = new Size(298, 27);
            customerInfoTxt.TabIndex = 67;
            customerInfoTxt.Text = "khach-sdt";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 66;
            label4.Text = "Khách hàng";
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Font = new Font("Times New Roman", 13.8F);
            txtStatus.Location = new Point(442, 216);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(166, 27);
            txtStatus.TabIndex = 65;
            txtStatus.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(433, 188);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 64;
            label7.Text = "Trạng thái";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 48);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ghi chú cho đơn hàng nếu có";
            textBox2.Size = new Size(311, 49);
            textBox2.TabIndex = 63;
            // 
            // txtPricePayment
            // 
            txtPricePayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.Location = new Point(15, 214);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(394, 27);
            txtPricePayment.TabIndex = 62;
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.Location = new Point(583, 259);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(64, 51);
            btnPrint.TabIndex = 2;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 61;
            label2.Text = "Tổng tiền phải chi trả";
            // 
            // btnComplete
            // 
            btnComplete.BackgroundImage = (Image)resources.GetObject("btnComplete.BackgroundImage");
            btnComplete.BackgroundImageLayout = ImageLayout.Stretch;
            btnComplete.Location = new Point(667, 259);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(64, 51);
            btnComplete.TabIndex = 1;
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // txtTotalPriceDiscount
            // 
            txtTotalPriceDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalPriceDiscount.BorderStyle = BorderStyle.None;
            txtTotalPriceDiscount.Font = new Font("Times New Roman", 13.8F);
            txtTotalPriceDiscount.Location = new Point(143, 146);
            txtTotalPriceDiscount.Name = "txtTotalPriceDiscount";
            txtTotalPriceDiscount.Size = new Size(217, 27);
            txtTotalPriceDiscount.TabIndex = 60;
            txtTotalPriceDiscount.Text = "0";
            txtTotalPriceDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(433, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm đã mua";
            // 
            // flowPanel
            // 
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(373, 149);
            flowPanel.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 148);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 59;
            label6.Text = "Giảm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 55;
            label3.Text = "Mã đơn hàng";
            // 
            // txtPriceBefore
            // 
            txtPriceBefore.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPriceBefore.BorderStyle = BorderStyle.None;
            txtPriceBefore.Font = new Font("Times New Roman", 13.8F);
            txtPriceBefore.Location = new Point(143, 103);
            txtPriceBefore.Name = "txtPriceBefore";
            txtPriceBefore.Size = new Size(240, 27);
            txtPriceBefore.TabIndex = 58;
            txtPriceBefore.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMaDH
            // 
            txtMaDH.BorderStyle = BorderStyle.None;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaDH.Location = new Point(143, 7);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(284, 27);
            txtMaDH.TabIndex = 56;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 112);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 57;
            label5.Text = "Thành tiền";
            // 
            // OrderResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "OrderResult";
            Size = new Size(750, 423);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnComplete;
        private Button btnPrint;
        private TextBox customerInfoTxt;
        private Label label4;
        private TextBox txtStatus;
        private Label label7;
        private TextBox textBox2;
        private TextBox txtPricePayment;
        private Label label2;
        private TextBox txtTotalPriceDiscount;
        private Label label6;
        private Label label3;
        private TextBox txtPriceBefore;
        private TextBox txtMaDH;
        private Label label5;
        private FlowLayoutPanel flowPanel;
    }
}
