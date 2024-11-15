namespace PM_LKMT.Controls.Button
{
    partial class Add
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
            button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button
            // 
            button.BackColor = Color.DarkSlateGray;
            button.BackgroundImage = Resource.icons8_cart_48;
            button.BackgroundImageLayout = ImageLayout.None;
            button.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = SystemColors.ButtonFace;
            button.Location = new Point(3, 3);
            button.Name = "button";
            button.Size = new Size(119, 59);
            button.TabIndex = 1;
            button.Text = "Mua";
            button.TextAlign = ContentAlignment.MiddleRight;
            button.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button);
            Name = "Add";
            Size = new Size(124, 64);
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
    }
}
