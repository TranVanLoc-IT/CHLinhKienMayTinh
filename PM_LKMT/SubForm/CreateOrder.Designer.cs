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
            button1 = new Button();
            comboTable = new ComboBox();
            label14 = new Label();
            panel4 = new Panel();
            dataGrid = new DataGridView();
            panel2 = new Panel();
            txtDiscount = new TextBox();
            label3 = new Label();
            createBtn = new Button();
            txtNote = new TextBox();
            txtPricePayment = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            flowPanel = new FlowLayoutPanel();
            cancelBtn = new Button();
            deleteBtn = new Button();
            searchtxt = new TextBox();
            cbFilter = new ComboBox();
            txtMaDH = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImage = Resource.see;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Times New Roman", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(901, 1137);
            button1.Name = "button1";
            button1.Size = new Size(85, 55);
            button1.TabIndex = 13;
            button1.Text = "Tìm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // comboTable
            // 
            comboTable.Anchor = AnchorStyles.Bottom;
            comboTable.Font = new Font("Times New Roman", 12F);
            comboTable.FormattingEnabled = true;
            comboTable.Items.AddRange(new object[] { "Đơn hàng", "Sản phẩm" });
            comboTable.Location = new Point(1234, 1140);
            comboTable.Name = "comboTable";
            comboTable.Size = new Size(109, 30);
            comboTable.TabIndex = 7;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(1163, 1152);
            label14.Name = "label14";
            label14.Size = new Size(50, 22);
            label14.TabIndex = 6;
            label14.Text = "Bảng";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGrid);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(comboTable);
            panel4.Controls.Add(label14);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1068, 574);
            panel4.TabIndex = 6;
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
            dataGrid.Location = new Point(0, -558);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1068, 1132);
            dataGrid.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtDiscount);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(createBtn);
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(txtPricePayment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(searchtxt);
            panel2.Controls.Add(cbFilter);
            panel2.Controls.Add(txtMaDH);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 336);
            panel2.TabIndex = 22;
            // 
            // txtDiscount
            // 
            txtDiscount.BorderStyle = BorderStyle.None;
            txtDiscount.Enabled = false;
            txtDiscount.Font = new Font("Times New Roman", 13.8F);
            txtDiscount.Location = new Point(163, 178);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(264, 27);
            txtDiscount.TabIndex = 59;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 58;
            label3.Text = "Giảm";
            // 
            // createBtn
            // 
            createBtn.BackgroundImage = (Image)resources.GetObject("createBtn.BackgroundImage");
            createBtn.BackgroundImageLayout = ImageLayout.Stretch;
            createBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            createBtn.FlatAppearance.MouseOverBackColor = Color.Green;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Location = new Point(209, 261);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(57, 50);
            createBtn.TabIndex = 55;
            createBtn.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(12, 64);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.PlaceholderText = "Ghi chú cho đơn hàng nếu có";
            txtNote.Size = new Size(415, 90);
            txtNote.TabIndex = 54;
            // 
            // txtPricePayment
            // 
            txtPricePayment.BorderStyle = BorderStyle.None;
            txtPricePayment.Font = new Font("Times New Roman", 13.8F);
            txtPricePayment.Location = new Point(143, 228);
            txtPricePayment.Name = "txtPricePayment";
            txtPricePayment.Size = new Size(264, 27);
            txtPricePayment.TabIndex = 47;
            txtPricePayment.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 230);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 46;
            label2.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(flowPanel);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(478, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 232);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các sản phẩm mua";
            // 
            // flowPanel
            // 
            flowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(3, 30);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(572, 199);
            flowPanel.TabIndex = 46;
            // 
            // cancelBtn
            // 
            cancelBtn.BackgroundImage = (Image)resources.GetObject("cancelBtn.BackgroundImage");
            cancelBtn.BackgroundImageLayout = ImageLayout.Stretch;
            cancelBtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            cancelBtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Location = new Point(291, 261);
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
            deleteBtn.Location = new Point(126, 261);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(57, 50);
            deleteBtn.TabIndex = 43;
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            searchtxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchtxt.Font = new Font("Times New Roman", 13.8F);
            searchtxt.Location = new Point(478, 300);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Nhập mã đơn hàng để tìm";
            searchtxt.Size = new Size(381, 34);
            searchtxt.TabIndex = 37;
            searchtxt.TextChanged += searchtxt_TextChanged_1;
            // 
            // cbFilter
            // 
            cbFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbFilter.Font = new Font("Times New Roman", 13.8F);
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(865, 299);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(188, 34);
            cbFilter.TabIndex = 35;
            // 
            // txtMaDH
            // 
            txtMaDH.BorderStyle = BorderStyle.FixedSingle;
            txtMaDH.Enabled = false;
            txtMaDH.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaDH.Location = new Point(143, 23);
            txtMaDH.Name = "txtMaDH";
            txtMaDH.Size = new Size(284, 34);
            txtMaDH.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 18;
            label1.Text = "Mã đơn hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 337);
            panel1.TabIndex = 5;
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 574);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "CreateOrder";
            Text = "CreateOrder";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboTable;
        private Label label14;
        private Panel panel4;
        private DataGridView dataGrid;
        private Panel panel2;
        private TextBox txtNote;
        private TextBox txtPricePayment;
        private Label label2;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowPanel;
        private Button cancelBtn;
        private Button deleteBtn;
        private TextBox searchtxt;
        private TextBox txtMaDH;
        private Label label1;
        private Panel panel1;
        private Button createBtn;
        private ComboBox cbFilter;
        private TextBox txtDiscount;
        private Label label3;
    }
}