namespace PM_LKMT.SubForm
{
    partial class CustomerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            sdt = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            dateJoin = new TextBox();
            button8 = new Button();
            button1 = new Button();
            txtSearch = new TextBox();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtId.Location = new Point(210, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 2;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(34, 121);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại";
            // 
            // sdt
            // 
            sdt.BorderStyle = BorderStyle.None;
            sdt.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            sdt.Location = new Point(211, 111);
            sdt.Name = "sdt";
            sdt.Size = new Size(211, 27);
            sdt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(34, 74);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 6;
            label3.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtName.Location = new Point(211, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 27);
            txtName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(448, 24);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 8;
            label4.Text = "Ngày tham gia";
            // 
            // dateJoin
            // 
            dateJoin.BorderStyle = BorderStyle.None;
            dateJoin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dateJoin.Location = new Point(620, 17);
            dateJoin.Name = "dateJoin";
            dateJoin.Size = new Size(170, 27);
            dateJoin.TabIndex = 7;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Enabled = false;
            button8.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button8.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button8.Location = new Point(454, 69);
            button8.Name = "button8";
            button8.Size = new Size(57, 50);
            button8.TabIndex = 47;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Enabled = false;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.Location = new Point(517, 69);
            button1.Name = "button1";
            button1.Size = new Size(57, 50);
            button1.TabIndex = 48;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(39, 161);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập SDT hoặc tên khách hàng";
            txtSearch.Size = new Size(328, 34);
            txtSearch.TabIndex = 49;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            dataGrid.Location = new Point(0, 201);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(793, 152);
            dataGrid.TabIndex = 50;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dataGrid);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(label4);
            Controls.Add(dateJoin);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(sdt);
            Controls.Add(label1);
            Controls.Add(txtId);
            Name = "CustomerControl";
            Size = new Size(793, 353);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox sdt;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox dateJoin;
        private Button button8;
        private Button button1;
        private TextBox txtSearch;
        private DataGridView dataGrid;
    }
}
