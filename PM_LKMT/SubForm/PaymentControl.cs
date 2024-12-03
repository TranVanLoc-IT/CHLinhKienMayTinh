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

namespace PM_LKMT.SubForm
{
    public partial class PaymentControl : UserControl
    {
        private string userName { get; set; }

        private LichSuGDBLL _bll;
        private ChiTietDonHangBLL _ctdhBLL;
        private DonHangBLL _dhBLL;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private ErrorProvider _errorProvider;
        private EditDTO.DonHang _donHang;
        public EditDTO.LichSuGD lichSuGD;


        public PaymentControl(string uname, EditDTO.DonHang donHang)
        {
            InitializeComponent();
            this._bll = new LichSuGDBLL();
            this._donHang = donHang;
            this.userName = uname;
            Config();
        }
        private void Config()
        {
            this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
            this._dhBLL = new DonHangBLL();
            this._ctdhBLL = new ChiTietDonHangBLL();
            this._errorProvider = new ErrorProvider();
            SetCbData();

        }
        private void SetCbData()
        {
            List<ComboBoxItemModel> ptCombo = new List<ComboBoxItemModel>()
            {
                new ComboBoxItemModel()
                {
                    Text = "Chuyển khoản",
                    Value = "Banking"
                },
                  new ComboBoxItemModel()
                {
                    Text = "Tiến mặt",
                    Value = "Cost"
                }
            };
            cbPt.DataSource = ptCombo;
            cbPt.DisplayMember = "Text";
            cbPt.ValueMember = "Value";
        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(maGd.Text))
            {
                _errorProvider.SetError(maGd, "Không được để trống");
                return false;
            }
            if (cbNh.SelectedIndex == 0)
            {
                _errorProvider.SetError(cbNh, "Chọn ngân hàng");
                return false;
            }
            if (cbPt.SelectedIndex == 0)
            {
                _errorProvider.SetError(cbPt, "Chọn phương thức");
                return false;
            }
            _errorProvider.Clear();
            return true;
        }

        private async Task cancelBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(Validate())return;
            lichSuGD.MaDonHang = _donHang.MaDonHang;
            lichSuGD.MaGiaoDich = maGd.Text;
            lichSuGD.NgayTao = DateTime.Now;
            lichSuGD.SoTien = _donHang.ThanhTien;
            lichSuGD.PhuongThuc = cbPt.SelectedValue!.ToString()!;
            lichSuGD.NganHang = cbNh.SelectedValue!.ToString()!;

            try
            {
                _bll.Create(lichSuGD);
                MessageBox.Show("Thành công", "Thanh toán thành công", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thanh toán lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
