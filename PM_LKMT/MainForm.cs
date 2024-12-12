using DTO;
using PM_LKMT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT
{
    public partial class MainForm : Form
    {
        private string role { get; set; }
        private string uname { get; set; }
        private Form currentForm { get; set; }
        public MainForm(string welcome)
        {
            InitializeComponent();
            staffInfo.Text = welcome;
            role = welcome.Split(" - ")[0];
            uname = welcome.Split(" - ")[1];
            OpenFuncByRole();
            this.WindowState = FormWindowState.Maximized;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            this.manageImportPage.Click += ManageImportPage_Click;

        }

        private void OpenFuncByRole()
        {
            if (role.StartsWith("Thu ngân"))
            {
                manageImportPage.Visible = false;
                manageSalePage.Visible = false;
                manageProductPage.Visible = false;
                orderPage.Visible = false;
                warehousePage.Visible = false;
            }
            else if (role.StartsWith("Nhân viên"))
            {
                paymentPage.Visible = false;
                manageSalePage.Visible = false;
                manageProductPage.Visible = false;
                manageSalePage.Visible = false;
            }
            else
            {
                orderPage.Visible = false;
                warehousePage.Visible = false;
                paymentPage.Visible = false;
                warehousePage.Visible = false;
                viewProductPage.Visible = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void orderPage_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            CreateOrder currentForm = new CreateOrder(uname);
            currentForm.TopLevel = false;       // 
            currentForm.FormBorderStyle = FormBorderStyle.None; // 
            currentForm.Dock = DockStyle.Fill;  //  
            this.main.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void viewProductPage_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            ViewProduct currentForm = new ViewProduct();
            currentForm.TopLevel = false;       // 
            currentForm.FormBorderStyle = FormBorderStyle.None; // 
            currentForm.Dock = DockStyle.Fill;  //  
            this.main.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void ManageImportPage_Click(object? sender, EventArgs e)
        {
            this.main.Controls.Clear();
            ImportReceiptForm currentForm = new ImportReceiptForm();
            currentForm.TopLevel = false;       // 
            currentForm.FormBorderStyle = FormBorderStyle.None; // 
            currentForm.Dock = DockStyle.Fill;  //  
            this.main.Controls.Add(currentForm);
            currentForm.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeWork.Text = TimeHelper.GetCurrentTime().ToString();
        }

        private void paymentPage_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            HandleOrderProcessForm currentForm = new HandleOrderProcessForm(uname);
            currentForm.TopLevel = false;       // 
            currentForm.FormBorderStyle = FormBorderStyle.None; // 
            currentForm.Dock = DockStyle.Fill;  //  
            this.main.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void manageSalePage_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            ViewProgramVoucher currentForm = new ViewProgramVoucher();
            currentForm.TopLevel = false;       // 
            currentForm.FormBorderStyle = FormBorderStyle.None; // 
            currentForm.Dock = DockStyle.Fill;  //  
            this.main.Controls.Add(currentForm);
            currentForm.Show();
        }
    }
}
