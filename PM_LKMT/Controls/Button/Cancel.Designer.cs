namespace PM_LKMT.Controls.Button
{
    partial class Cancel
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
            button1.BackColor = Color.DarkRed;
            button1.BackgroundImage = Resource.cancel;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 59);
            button1.TabIndex = 2;
            button1.Text = "Hủy";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "Cancel";
            Size = new Size(128, 67);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
