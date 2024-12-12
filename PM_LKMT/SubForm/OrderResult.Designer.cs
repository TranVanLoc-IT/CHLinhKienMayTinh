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
            txtMaDH = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            txtTotalPriceDiscount = new TextBox();
            label2 = new Label();
            txtPricePayment = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            customerInfoTxt = new TextBox();
            panel1 = new Panel();
            txtMoneyB = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaDH
            // 
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtMaDH.Location = new Point(12, 23);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(415, 34);
            txtMaDH.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(9, 268);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 59;
            label6.Text = "Giảm:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox1.Location = new Point(461, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 373);
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
            flowPanel.Size = new Size(345, 340);
            flowPanel.TabIndex = 0;
            // 
            // txtTotalPriceDiscount
            // 
            txtTotalPriceDiscount.BorderStyle = BorderStyle.None;
            txtTotalPriceDiscount.Enabled = false;
            txtTotalPriceDiscount.Font = new Font("Times New Roman", 13.8F);
            txtTotalPriceDiscount.Location = new Point(163, 266);
            txtTotalPriceDiscount.Name = "txtTotalPriceDiscount";
            txtTotalPriceDiscount.Size = new Size(261, 27);
            txtTotalPriceDiscount.TabIndex = 60;
            txtTotalPriceDiscount.Text = "0 VND";
            txtTotalPriceDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 308);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 61;
            label2.Text = "Thành tiền phải chi trả:";
            // 
            // txtPricePayment
            // 
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Enabled = false;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.Location = new Point(12, 349);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(394, 27);
            txtPricePayment.TabIndex = 62;
            txtPricePayment.Text = "0 VND";
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Times New Roman", 13.8F);
            textBox2.Location = new Point(12, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ghi chú cho đơn hàng nếu có";
            textBox2.Size = new Size(412, 97);
            textBox2.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(461, 383);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 64;
            label7.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Times New Roman", 13.8F);
            txtStatus.Location = new Point(470, 416);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(273, 27);
            txtStatus.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 383);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 66;
            label4.Text = "Khách hàng";
            // 
            // customerInfoTxt
            // 
            customerInfoTxt.BorderStyle = BorderStyle.None;
            customerInfoTxt.Enabled = false;
            customerInfoTxt.Font = new Font("Times New Roman", 13.8F);
            customerInfoTxt.Location = new Point(12, 418);
            customerInfoTxt.Name = "customerInfoTxt";
            customerInfoTxt.Size = new Size(298, 27);
            customerInfoTxt.TabIndex = 67;
            customerInfoTxt.Text = "khach-sdt";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMoneyB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(customerInfoTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtPricePayment);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTotalPriceDiscount);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMaDH);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 458);
            panel1.TabIndex = 1;
            // 
            // txtMoneyB
            // 
            txtMoneyB.BorderStyle = BorderStyle.None;
            txtMoneyB.Enabled = false;
            txtMoneyB.Font = new Font("Times New Roman", 13.8F);
            txtMoneyB.Location = new Point(163, 216);
            txtMoneyB.Name = "txtMoneyB";
            txtMoneyB.Size = new Size(261, 27);
            txtMoneyB.TabIndex = 70;
            txtMoneyB.Text = "0 VND";
            txtMoneyB.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 218);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 69;
            label1.Text = "Tổng tiền:";
            // 
            // OrderResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "OrderResult";
            Size = new Size(750, 458);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtMaDH;
        private Label label6;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private TextBox txtTotalPriceDiscount;
        private Label label2;
        private TextBox txtPricePayment;
        private TextBox textBox2;
        private Label label7;
        private TextBox txtStatus;
        private Label label4;
        private TextBox customerInfoTxt;
        private Panel panel1;
        private TextBox txtMoneyB;
        private Label label1;
    }
}
