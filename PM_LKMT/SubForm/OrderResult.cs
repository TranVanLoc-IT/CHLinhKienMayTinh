using BLL;
using DTO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private ResponseDTO.KhachHang kh;
        private IEnumerable<ResponseDTO.ChiTietDHResult> sps;
        private ResponseDTO.DonHang donHang;
        public OrderResult(IEnumerable<ResponseDTO.ChiTietDHResult> sps, ResponseDTO.DonHang donHang, 
                           EditDTO.LichSuGD lichSuGD)
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
            foreach (var i in sps)
            {
                // Tạo Label mới cho từng sản phẩm
                Label lb = new Label();
                Label price = new Label();

                // Thiết lập thông tin cho lb
                lb.Font = new Font("Times New Roman", 13, FontStyle.Italic);
                lb.ForeColor = Color.Black;
                lb.AutoSize = true;

                // Thiết lập thông tin cho price
                price.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                price.ForeColor = Color.Red;
                price.AutoSize = true;
                lb.Text = i.TenSanPham + " - SL: " + i.SoLuong;
                price.Text = "Thành tiền: " + _convertMoneyUnitBLL.ConvertToVND(i.ThanhTien);
                this.flowPanel.Controls.Add(lb);
                this.flowPanel.Controls.Add(price);
            }
        }
        private void FillInfo()
        {
            kh = _khBLL.GetByIdOrByName(donHang.TenKH);
            txtMaDH.Text = donHang.MaDonHang;
            txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(donHang.ThanhTien - donHang.GiamGia);
            txtStatus.Text = "Đã thanh toán";
            customerInfoTxt.Text = kh.HoTen + " - " + kh.SDT;
            txtTotalPriceDiscount.Text = _convertMoneyUnitBLL.ConvertToVND(donHang.GiamGia);
            txtMoneyB.Text = _convertMoneyUnitBLL.ConvertToVND(donHang.ThanhTien);
        }

       

    }
}
