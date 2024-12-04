namespace PM_LKMT.SubForm
{
    partial class CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            panel1 = new Panel();
            panel2 = new Panel();
            dataGrid = new DataGridView();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            cbFilter = new ComboBox();
            searchtxt = new TextBox();
            panelInfo = new Panel();
            label5 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            sdt = new TextBox();
            txtDiscount = new TextBox();
            label3 = new Label();
            txtNote = new TextBox();
            createBtn = new Button();
            txtPricePayment = new TextBox();
            label2 = new Label();
            cancelBtn = new Button();
            txtMaDH = new TextBox();
            deleteBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupBox1.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 574);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dataGrid);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cbFilter);
            panel2.Controls.Add(searchtxt);
            panel2.Controls.Add(panelInfo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 574);
            panel2.TabIndex = 22;
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
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.Location = new Point(443, 300);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(625, 274);
            dataGrid.TabIndex = 64;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(443, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 232);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các sản phẩm mua";
            // 
            // flowPanel
            // 
            flowPanel.BackColor = Color.WhiteSmoke;
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(592, 199);
            flowPanel.TabIndex = 46;
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Times New Roman", 13.8F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(830, 260);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(188, 34);
            cbFilter.TabIndex = 61;
            cbFilter.Text = "Lọc bảng";
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Times New Roman", 13.8F);
            searchtxt.Location = new Point(443, 260);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Nhập mã đơn hàng để tìm";
            searchtxt.Size = new Size(381, 34);
            searchtxt.TabIndex = 62;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(label5);
            panelInfo.Controls.Add(txtName);
            panelInfo.Controls.Add(label6);
            panelInfo.Controls.Add(sdt);
            panelInfo.Controls.Add(txtDiscount);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(txtNote);
            panelInfo.Controls.Add(createBtn);
            panelInfo.Controls.Add(txtPricePayment);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(cancelBtn);
            panelInfo.Controls.Add(txtMaDH);
            panelInfo.Controls.Add(deleteBtn);
            panelInfo.Controls.Add(label1);
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(437, 574);
            panelInfo.TabIndex = 60;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(20, 170);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 81;
            label5.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(197, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 27);
            txtName.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(20, 217);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 79;
            label6.Text = "Số điện thoại";
            // 
            // sdt
            // 
            sdt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sdt.BorderStyle = BorderStyle.None;
            sdt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            sdt.Location = new Point(197, 207);
            sdt.Name = "sdt";
            sdt.Size = new Size(231, 27);
            sdt.TabIndex = 2;
            sdt.TextChanged += sdt_TextChanged;
            sdt.KeyDown += sdt_KeyDown;
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDiscount.BorderStyle = BorderStyle.None;
            txtDiscount.Enabled = false;
            txtDiscount.Font = new Font("Times New Roman", 13.8F);
            txtDiscount.Location = new Point(197, 261);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(231, 27);
            txtDiscount.TabIndex = 66;
            txtDiscount.Text = "0 VND";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(19, 263);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 65;
            label3.Text = "Giảm";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(19, 356);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Ghi chú cho đơn hàng nếu có";
            txtNote.Size = new Size(415, 75);
            txtNote.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createBtn.BackgroundImage = (Image)resources.GetObject("createBtn.BackgroundImage");
            createBtn.BackgroundImageLayout = ImageLayout.Stretch;
            createBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            createBtn.FlatAppearance.MouseOverBackColor = Color.Green;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Location = new Point(176, 458);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(57, 50);
            createBtn.TabIndex = 4;
            createBtn.UseVisualStyleBackColor = true;
            // 
            // txtPricePayment
            // 
            txtPricePayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.Location = new Point(196, 311);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(232, 27);
            txtPricePayment.TabIndex = 63;
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(15, 313);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 62;
            label2.Text = "Tổng tiền";
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cancelBtn.BackgroundImage = (Image)resources.GetObject("cancelBtn.BackgroundImage");
            cancelBtn.BackgroundImageLayout = ImageLayout.Stretch;
            cancelBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Location = new Point(253, 458);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(57, 50);
            cancelBtn.TabIndex = 44;
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // txtMaDH
            // 
            txtMaDH.BorderStyle = BorderStyle.FixedSingle;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaDH.Location = new Point(19, 63);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(409, 34);
            txtMaDH.TabIndex = 61;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            deleteBtn.BackgroundImage = (Image)resources.GetObject("deleteBtn.BackgroundImage");
            deleteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            deleteBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Location = new Point(96, 458);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(57, 50);
            deleteBtn.TabIndex = 43;
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 60;
            label1.Text = "Mã đơn hàng";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 574);
            Controls.Add(panel1);
            Name = "CreateOrder";
            Text = "Tạo đơn hàng mới";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panelInfo;
        private TextBox txtDiscount;
        private Label label3;
        private TextBox txtNote;
        private Button createBtn;
        private TextBox txtPricePayment;
        private Label label2;
        private Button cancelBtn;
        private TextBox txtMaDH;
        private Button deleteBtn;
        private Label label1;
        private DataGridView dataGrid;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private ComboBox cbFilter;
        private TextBox searchtxt;
        private Label label5;
        private TextBox txtName;
        private Label label6;
        private TextBox sdt;
    }
}