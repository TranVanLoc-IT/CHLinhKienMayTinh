namespace PM_LKMT.SubForm
{
    partial class ViewProduct
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panelBanChay = new Panel();
            label2 = new Label();
            panelNoiBat = new Panel();
            label3 = new Label();
            panelThuongHieuHot = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panelBanChay);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(panelNoiBat);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(panelThuongHieuHot);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 3;
            label1.Text = "Bán chạy";
            // 
            // panelBanChay
            // 
            panelBanChay.AutoScroll = true;
            panelBanChay.BorderStyle = BorderStyle.FixedSingle;
            panelBanChay.Location = new Point(3, 26);
            panelBanChay.Name = "panelBanChay";
            panelBanChay.Size = new Size(797, 164);
            panelBanChay.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 193);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 5;
            label2.Text = "Nổi bật";
            // 
            // panelNoiBat
            // 
            panelNoiBat.AutoScroll = true;
            panelNoiBat.BackgroundImageLayout = ImageLayout.None;
            panelNoiBat.BorderStyle = BorderStyle.Fixed3D;
            panelNoiBat.Location = new Point(3, 219);
            panelNoiBat.Name = "panelNoiBat";
            panelNoiBat.Size = new Size(797, 164);
            panelNoiBat.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 386);
            label3.Name = "label3";
            label3.Size = new Size(165, 23);
            label3.TabIndex = 7;
            label3.Text = "Thương hiệu HOT";
            // 
            // panelThuongHieuHot
            // 
            panelThuongHieuHot.AutoScroll = true;
            panelThuongHieuHot.Location = new Point(3, 412);
            panelThuongHieuHot.Name = "panelThuongHieuHot";
            panelThuongHieuHot.Size = new Size(817, 164);
            panelThuongHieuHot.TabIndex = 6;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewProduct";
            Text = "ViewProduct";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panelBanChay;
        private Label label2;
        private Panel panelNoiBat;
        private Label label3;
        private Panel panelThuongHieuHot;
    }
}