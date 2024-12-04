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
    public partial class OrderResult : UserControl
    {
        private decimal giaBanChon { get; set; }
        private KhachHangBLL _khBLL;
        private ChiTietDonHangBLL _ctdhBLL;
        private DonHangBLL _dhBLL;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private ErrorProvider _errorProvider;
        private EditDTO.LichSuGD lichSuGD;

        private IEnumerable<ResponseDTO.ChiTietDHResult> sps;
        private EditDTO.DonHang donHang;

        public OrderResult(IEnumerable<ResponseDTO.ChiTietDHResult> sps, EditDTO.DonHang donHang, EditDTO.LichSuGD lichSuGD)
        {
            InitializeComponent();
            this.Load += async (s, e) => await Config();
            this.lichSuGD = lichSuGD;
            this.sps = sps;
            this.donHang = donHang;
        }
        private async Task Config()
        {
            this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
            this._khBLL = new KhachHangBLL();
            this._dhBLL = new DonHangBLL();
            this._ctdhBLL = new ChiTietDonHangBLL();
            this._errorProvider = new ErrorProvider();
            LoadProduct();
            FillInfo();
        }
        private void LoadProduct()
        {
            foreach (var item in sps)
            {
                ProductCartLine line = new ProductCartLine();
                line.txtName.Text = item.TenSanPham;
                line.quantity.Value = item.SoLuong;
                line.price.Text = _convertMoneyUnitBLL.ConvertToVND(item.ThanhTien);

                this.flowPanel.Controls.Add(line);
            }
        }
        private void FillInfo()
        {
            ResponseDTO.KhachHang kh = _khBLL.GetById(donHang.MaKH);
            txtMaDH.Text = donHang.MaDonHang;
            txtPricePayment.Text = donHang.ThanhTien.ToString();
            txtStatus.Text = "Thành công";
            customerInfoTxt.Text = kh.HoTen + " - " + kh.SDT;

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }
    }
}
