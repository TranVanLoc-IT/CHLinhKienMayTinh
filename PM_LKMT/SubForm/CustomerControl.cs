using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PM_LKMT.SubForm
{
    public partial class CustomerControl : UserControl
    {

        private KhachHangBLL _khBLL;
        private ErrorProvider _errorProvider;
        public ResponseDTO.KhachHang kh;
        private IEnumerable<ResponseDTO.KhachHang> khs;
        public CustomerControl()
        {
            InitializeComponent();
            this.kh = new ResponseDTO.KhachHang();
            this.Load += async (s, e) => await Config();
        }
        private async Task Config()
        {
            this._khBLL = new KhachHangBLL();
            this.dataGrid.DataSource = khs = _khBLL.GetAll();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            kh.MaKH = txtId.Text;
            kh.HoTen = txtName.Text;
            kh.SDT = sdt.Text;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = khs.Where(r => r.SDT.StartsWith(txtSearch.Text) || r.HoTen.ToLower().Contains(txtSearch.Text.ToLower()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation()) return;
            EditDTO.KhachHang kh = new EditDTO.KhachHang();
            kh.MaKH = txtId.Text;
            kh.HoTen = txtName.Text;
            kh.NgayThamGia = DateTime.Now;
            kh.SDT = sdt.Text;
            if(string.IsNullOrWhiteSpace(kh.MaKH) || string.IsNullOrWhiteSpace(kh.HoTen))
            {
                MessageBox.Show("Nhập đầy đủ thông tin mã khách hàng và họ tên", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            try
            {
                this._khBLL.Create(kh);
                MessageBox.Show( "Tạo thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo " + ex.Message,"Lỗi",  MessageBoxButtons.OK);

            }
        }

        private bool Validation()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        _errorProvider.SetError(tb, "Không được để trống");
                        return false;
                    }
                }
            }
            _errorProvider.Clear();
            return true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
    }
}
