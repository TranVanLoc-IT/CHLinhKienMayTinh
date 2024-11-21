namespace PM_LKMT.UserControlCustom
{
    partial class WarehouseForm
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
			comboBox1 = new ComboBox();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			textBox2 = new TextBox();
			label4 = new Label();
			textBox3 = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 223);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(800, 227);
			dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F);
			label1.Location = new Point(36, 24);
			label1.Name = "label1";
			label1.Size = new Size(129, 22);
			label1.TabIndex = 1;
			label1.Text = "Chọn sản phẩm";
			// 
			// comboBox1
			// 
			comboBox1.Font = new Font("Times New Roman", 12F);
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(165, 16);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(170, 30);
			comboBox1.TabIndex = 2;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Times New Roman", 12F);
			textBox1.Location = new Point(220, 64);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 30);
			textBox1.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F);
			label2.Location = new Point(36, 72);
			label2.Name = "label2";
			label2.Size = new Size(178, 22);
			label2.TabIndex = 4;
			label2.Text = "Tổng số lượng bán ra";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 12F);
			label3.Location = new Point(36, 125);
			label3.Name = "label3";
			label3.Size = new Size(130, 22);
			label3.TabIndex = 6;
			label3.Text = "Tổng doanh thu";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Times New Roman", 12F);
			textBox2.Location = new Point(165, 118);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 30);
			textBox2.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 12F);
			label4.Location = new Point(36, 171);
			label4.Name = "label4";
			label4.Size = new Size(113, 22);
			label4.TabIndex = 8;
			label4.Text = "Tổng chi tiêu";
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Times New Roman", 12F);
			textBox3.Location = new Point(165, 164);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 30);
			textBox3.TabIndex = 7;
			// 
			// WarehouseForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(comboBox1);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Name = "WarehouseForm";
			Text = "WarehouseForm";
			Load += WarehouseForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label label1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private TextBox textBox2;
		private Label label4;
		private TextBox textBox3;
	}
}