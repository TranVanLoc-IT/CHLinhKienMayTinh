namespace PM_LKMT
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            côngTyLinhKiệnECOMToolStripMenuItem = new ToolStripMenuItem();
            staffInfo = new ToolStripMenuItem();
            func = new ToolStripMenuItem();
            viewProductPage = new ToolStripMenuItem();
            orderPage = new ToolStripMenuItem();
            warehousePage = new ToolStripMenuItem();
            paymentPage = new ToolStripMenuItem();
            manageBillPage = new ToolStripMenuItem();
            exportBillPage = new ToolStripMenuItem();
            manageCustomerPage = new ToolStripMenuItem();
            manageProductPage = new ToolStripMenuItem();
            manageImportPage = new ToolStripMenuItem();
            manageSalePage = new ToolStripMenuItem();
            logout = new ToolStripMenuItem();
            timeWork = new ToolStripTextBox();
            main = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.CornflowerBlue;
            menuStrip1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { côngTyLinhKiệnECOMToolStripMenuItem, staffInfo, func, logout, timeWork });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1441, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // côngTyLinhKiệnECOMToolStripMenuItem
            // 
            côngTyLinhKiệnECOMToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            côngTyLinhKiệnECOMToolStripMenuItem.ForeColor = Color.Azure;
            côngTyLinhKiệnECOMToolStripMenuItem.Image = Resource.logoapp;
            côngTyLinhKiệnECOMToolStripMenuItem.Name = "côngTyLinhKiệnECOMToolStripMenuItem";
            côngTyLinhKiệnECOMToolStripMenuItem.Size = new Size(238, 36);
            côngTyLinhKiệnECOMToolStripMenuItem.Text = "Công ty ECOM";
            // 
            // staffInfo
            // 
            staffInfo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            staffInfo.ForeColor = Color.Azure;
            staffInfo.Name = "staffInfo";
            staffInfo.Size = new Size(272, 36);
            staffInfo.Text = "Xin chào: nhân viên";
            // 
            // func
            // 
            func.DropDownItems.AddRange(new ToolStripItem[] { viewProductPage, orderPage, warehousePage, paymentPage, manageBillPage, exportBillPage, manageCustomerPage, manageProductPage, manageImportPage, manageSalePage });
            func.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            func.ForeColor = Color.Azure;
            func.Name = "func";
            func.Size = new Size(162, 36);
            func.Text = "Chức năng";
            // 
            // viewProductPage
            // 
            viewProductPage.BackColor = SystemColors.Control;
            viewProductPage.BackgroundImage = Resource.see;
            viewProductPage.BackgroundImageLayout = ImageLayout.None;
            viewProductPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            viewProductPage.ImageAlign = ContentAlignment.MiddleLeft;
            viewProductPage.Margin = new Padding(2);
            viewProductPage.Name = "viewProductPage";
            viewProductPage.Size = new Size(356, 40);
            viewProductPage.Text = "Xem sản phẩm";
            viewProductPage.TextAlign = ContentAlignment.MiddleRight;
            viewProductPage.Click += viewProductPage_Click;
            // 
            // orderPage
            // 
            orderPage.BackColor = SystemColors.Control;
            orderPage.BackgroundImage = Resource.box;
            orderPage.BackgroundImageLayout = ImageLayout.None;
            orderPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            orderPage.Margin = new Padding(2);
            orderPage.Name = "orderPage";
            orderPage.Size = new Size(356, 40);
            orderPage.Text = "Đơn hàng";
            orderPage.Click += orderPage_Click;
            // 
            // warehousePage
            // 
            warehousePage.BackColor = SystemColors.Control;
            warehousePage.BackgroundImage = Resource.warehouse;
            warehousePage.BackgroundImageLayout = ImageLayout.None;
            warehousePage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            warehousePage.Margin = new Padding(2);
            warehousePage.Name = "warehousePage";
            warehousePage.Size = new Size(356, 40);
            warehousePage.Text = "Kho hàng";
            // 
            // paymentPage
            // 
            paymentPage.BackColor = SystemColors.Control;
            paymentPage.BackgroundImage = Resource.icons8_payment_48;
            paymentPage.BackgroundImageLayout = ImageLayout.None;
            paymentPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            paymentPage.Margin = new Padding(2);
            paymentPage.Name = "paymentPage";
            paymentPage.Size = new Size(356, 40);
            paymentPage.Text = "Thanh toán";
            // 
            // manageBillPage
            // 
            manageBillPage.BackColor = SystemColors.Control;
            manageBillPage.BackgroundImage = Resource.icons8_bill_50;
            manageBillPage.BackgroundImageLayout = ImageLayout.None;
            manageBillPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageBillPage.Margin = new Padding(2);
            manageBillPage.Name = "manageBillPage";
            manageBillPage.Size = new Size(356, 40);
            manageBillPage.Text = "Quản lí hóa đơn";
            // 
            // exportBillPage
            // 
            exportBillPage.BackColor = SystemColors.Control;
            exportBillPage.BackgroundImage = Resource.printer;
            exportBillPage.BackgroundImageLayout = ImageLayout.None;
            exportBillPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exportBillPage.Margin = new Padding(2);
            exportBillPage.Name = "exportBillPage";
            exportBillPage.Size = new Size(356, 40);
            exportBillPage.Text = "Xuất hóa đơn";
            // 
            // manageCustomerPage
            // 
            manageCustomerPage.BackColor = SystemColors.Control;
            manageCustomerPage.BackgroundImage = Resource.icons8_customer_48;
            manageCustomerPage.BackgroundImageLayout = ImageLayout.None;
            manageCustomerPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageCustomerPage.Margin = new Padding(2);
            manageCustomerPage.Name = "manageCustomerPage";
            manageCustomerPage.Size = new Size(356, 40);
            manageCustomerPage.Text = "Khách hàng";
            // 
            // manageProductPage
            // 
            manageProductPage.BackColor = SystemColors.Control;
            manageProductPage.BackgroundImage = Resource.icons8_computer_48;
            manageProductPage.BackgroundImageLayout = ImageLayout.None;
            manageProductPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageProductPage.Margin = new Padding(2);
            manageProductPage.Name = "manageProductPage";
            manageProductPage.Size = new Size(356, 40);
            manageProductPage.Text = "Quản lí linh kiện";
            // 
            // manageImportPage
            // 
            manageImportPage.BackColor = SystemColors.Control;
            manageImportPage.BackgroundImage = Resource.icons8_paper_48;
            manageImportPage.BackgroundImageLayout = ImageLayout.None;
            manageImportPage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageImportPage.Margin = new Padding(2);
            manageImportPage.Name = "manageImportPage";
            manageImportPage.Size = new Size(356, 40);
            manageImportPage.Text = "Quản lí phiếu nhập";
            // 
            // manageSalePage
            // 
            manageSalePage.BackColor = SystemColors.Control;
            manageSalePage.BackgroundImage = Resource.icons8_discount_48;
            manageSalePage.BackgroundImageLayout = ImageLayout.None;
            manageSalePage.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageSalePage.Margin = new Padding(2);
            manageSalePage.Name = "manageSalePage";
            manageSalePage.Size = new Size(356, 40);
            manageSalePage.Text = "Quản lí khuyến mãi";
            manageSalePage.Click += manageSalePage_Click;
            // 
            // logout
            // 
            logout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout.ForeColor = Color.Azure;
            logout.Name = "logout";
            logout.Size = new Size(154, 36);
            logout.Text = "Đăng xuất";
            logout.Click += logout_Click;
            // 
            // timeWork
            // 
            timeWork.BackColor = Color.SeaShell;
            timeWork.Enabled = false;
            timeWork.ForeColor = Color.White;
            timeWork.Name = "timeWork";
            timeWork.Size = new Size(199, 36);
            timeWork.Text = "21/20/2024 12:00:12";
            timeWork.ToolTipText = "Thời gian làm việc";
            // 
            // main
            // 
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 40);
            main.Margin = new Padding(4, 4, 4, 4);
            main.Name = "main";
            main.Size = new Size(1441, 538);
            main.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1441, 578);
            Controls.Add(main);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem côngTyLinhKiệnECOMToolStripMenuItem;
        private ToolStripMenuItem staffInfo;
        private ToolStripMenuItem func;
        private ToolStripMenuItem logout;
        private ToolStripTextBox timeWork;
        private ToolStripMenuItem viewProductPage;
        private ToolStripMenuItem orderPage;
        private ToolStripMenuItem warehousePage;
        private ToolStripMenuItem paymentPage;
        private ToolStripMenuItem manageBillPage;
        private ToolStripMenuItem exportBillPage;
        private ToolStripMenuItem manageCustomerPage;
        private ToolStripMenuItem manageProductPage;
        private ToolStripMenuItem manageImportPage;
        private ToolStripMenuItem manageSalePage;
        private Panel main;
        private System.Windows.Forms.Timer timer1;
    }
}