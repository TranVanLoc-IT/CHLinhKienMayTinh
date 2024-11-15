namespace PM_LKMT.Controls.Button
{
    partial class Create
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
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.BackgroundImage = Resource.add;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(119, 59);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "Create";
            Size = new Size(118, 61);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Button button1;
    }
}
