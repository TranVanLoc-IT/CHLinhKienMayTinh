using BLL;

namespace PM_LKMT
{
    public partial class LoginForm : Form
    {
        private LoginBLL _login = new LoginBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            ErrorProvider err = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(userName))
            {
                err.SetError(txtUserName, "Không để trống tên đăng nhập");
                return;
            }
            if (string.IsNullOrWhiteSpace(userName))
            {
                err.SetError(txtPassword, "Không để trống mật khẩu");
                return;
            }
            string welcome = _login.Login(userName.ToUpper(), password);
            if (string.IsNullOrWhiteSpace(welcome))
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MainForm main = new MainForm(welcome);
            this.Visible = false;
            main.ShowDialog();
        }
    }
}
