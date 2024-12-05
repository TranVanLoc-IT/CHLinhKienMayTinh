namespace PM_LKMT.SubForm
{
    partial class FrmTHuongHieu
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            maTHText = new TextBox();
            tenTHText = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(56, 60);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 1;
            label1.Text = "Mã thương hiệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(494, 59);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên thương hiệu";
            // 
            // maTHText
            // 
            maTHText.Location = new Point(194, 58);
            maTHText.Name = "maTHText";
            maTHText.Size = new Size(198, 27);
            maTHText.TabIndex = 3;
            // 
            // tenTHText
            // 
            tenTHText.Location = new Point(635, 56);
            tenTHText.Name = "tenTHText";
            tenTHText.Size = new Size(215, 27);
            tenTHText.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.BackgroundImage = Resource.update2;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(557, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 59);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.BackgroundImage = Resource.delete;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(388, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 59);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.BackgroundImage = Resource.add;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(214, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 59);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmTHuongHieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 525);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tenTHText);
            Controls.Add(maTHText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmTHuongHieu";
            Text = "FrmTHuongHieu";
            Load += FrmTHuongHieu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox maTHText;
        private TextBox tenTHText;
        public Button btnUpdate;
        public Button btnDelete;
        public Button btnAdd;
    }
}