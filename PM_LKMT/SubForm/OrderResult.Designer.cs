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
            txtMaDH = new TextBox();
            label3 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            txtTotalPriceDiscount = new TextBox();
            label2 = new Label();
            btnPrint = new Button();
            txtPricePayment = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            customerInfoTxt = new TextBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(192, 23);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 0;
            label1.Text = "Thông tin đơn hàng đã xử lý";
            // 
            // txtMaDH
            // 
            txtMaDH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtMaDH.BorderStyle = BorderStyle.None;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaDH.Location = new Point(166, 7);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(261, 27);
            txtMaDH.TabIndex = 56;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 55;
            label3.Text = "Mã đơn hàng";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 124);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 59;
            label6.Text = "Giảm";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(433, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm đã mua";
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(373, 149);
            flowPanel.TabIndex = 0;
            // 
            // txtTotalPriceDiscount
            // 
            txtTotalPriceDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalPriceDiscount.BorderStyle = BorderStyle.None;
            txtTotalPriceDiscount.Enabled = false;
            txtTotalPriceDiscount.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPriceDiscount.Location = new Point(166, 122);
            txtTotalPriceDiscount.Name = "txtTotalPriceDiscount";
            txtTotalPriceDiscount.Size = new Size(261, 27);
            txtTotalPriceDiscount.TabIndex = 60;
            txtTotalPriceDiscount.Text = "0";
            txtTotalPriceDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 61;
            label2.Text = "Tổng tiền phải chi trả";
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.Location = new Point(651, 259);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(64, 51);
            btnPrint.TabIndex = 2;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtPricePayment
            // 
            txtPricePayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Enabled = false;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPricePayment.Location = new Point(15, 190);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(394, 27);
            txtPricePayment.TabIndex = 62;
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(15, 52);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ghi chú cho đơn hàng nếu có";
            textBox2.Size = new Size(412, 49);
            textBox2.TabIndex = 63;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(433, 188);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 64;
            label7.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(442, 216);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(273, 27);
            txtStatus.TabIndex = 65;
            txtStatus.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 224);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 66;
            label4.Text = "Khách hàng";
            // 
            // customerInfoTxt
            // 
            customerInfoTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            customerInfoTxt.BorderStyle = BorderStyle.None;
            customerInfoTxt.Enabled = false;
            customerInfoTxt.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            customerInfoTxt.Location = new Point(15, 259);
            customerInfoTxt.Name = "customerInfoTxt";
            customerInfoTxt.Size = new Size(298, 27);
            customerInfoTxt.TabIndex = 67;
            customerInfoTxt.Text = "khach-sdt";
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
            panel1.Controls.Add(txtTotalPriceDiscount);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaDH);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 326);
            panel1.TabIndex = 1;
            // 
            // OrderResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "OrderResult";
            Size = new Size(750, 423);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaDH;
        private Label label3;
        private Label label6;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private TextBox txtTotalPriceDiscount;
        private Label label2;
        private Button btnPrint;
        private TextBox txtPricePayment;
        private TextBox textBox2;
        private Label label7;
        private TextBox txtStatus;
        private Label label4;
        private TextBox customerInfoTxt;
        private Panel panel1;
    }
}
