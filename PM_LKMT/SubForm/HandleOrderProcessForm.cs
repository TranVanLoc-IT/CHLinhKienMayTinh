using BLL;
using DTO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using static DAL.LKMT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PM_LKMT.SubForm
{
    public partial class HandleOrderProcessForm : Form
    {
        private string userName { get; set; }
        private string maCt { get; set; }
        private int _currentStep = 1;
        private decimal _discount = 0;
        private string ct = string.Empty;
        private ErrorProvider _errorProvider;
        private Panel main;
        private IEnumerable<ResponseDTO.ChiTietDHResult> bought = new List<ResponseDTO.ChiTietDHResult>();
        private List<ProductCartModel> cart = new List<ProductCartModel>();
        private ResponseDTO.DonHang donHangmoi = new ResponseDTO.DonHang();
        private EditDTO.LichSuGD lichSuGD = new EditDTO.LichSuGD();
        private OrderResult resultControl;
        private ChuongTrinhBLL _ct;

        private LichSuGDBLL lsgd;
        private SanPhamBLL _spBLL;
        private DonHangBLL _dhBLL;
        private KhachHangBLL _khBLL;
        private ChiTietDonHangBLL _ctdhBLL;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;



        public HandleOrderProcessForm(string uname)
        {
            InitializeComponent();
            this.userName = uname;
            this.Text = "Xử lý thanh toán";
            Config();
        }

        private void Config()
        {
            this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
            this._khBLL = new KhachHangBLL();
            this._dhBLL = new DonHangBLL();
            this._spBLL = new SanPhamBLL();
            this._ct = new ChuongTrinhBLL();
            this.lsgd = new LichSuGDBLL();
            this._ctdhBLL = new ChiTietDonHangBLL();
            this._errorProvider = new ErrorProvider();
            txtPricePayment.TextChanged += TxtPricePayment_TextChanged;
            // Lưu trạng thái ban đầu
            main = new Panel
            {
                Dock = panel2.Dock,
                Size = panel2.Size,
                BackColor = panel2.BackColor
            };

            foreach (Control control in panel2.Controls)
            {
                main.Controls.Add(CloneControl(control)); // Sao chép thay vì di chuyển
            }


            this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;

            loadgrid();
            SetCbData();
            cbNh.SelectedIndex = cbPt.SelectedIndex = 0;

        }

        private void TxtPricePayment_TextChanged(object? sender, EventArgs e)
        {
            recieveMoney.Text = txtPricePayment.Text;
        }

        private Control CloneControl(Control source)
        {
            Control clone = (Control)Activator.CreateInstance(source.GetType());

            // Sao chép các thuộc tính cơ bản
            clone.Text = source.Text;
            clone.Size = source.Size;
            clone.Location = source.Location;
            clone.BackColor = source.BackColor;
            clone.ForeColor = source.ForeColor;
            clone.Font = source.Font;

            // Nếu control có các control con (ví dụ GroupBox, Panel)
            if (source.Controls.Count > 0)
            {
                foreach (Control child in source.Controls)
                {
                    clone.Controls.Add(CloneControl(child)); // Đệ quy sao chép control con
                }
            }

            return clone;
        }

        private void DataGrid_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGrid.Rows[e.RowIndex];
            ResponseDTO.KhachHang kh = _khBLL.GetAll().Where(r => r.HoTen.Equals(row.Cells[2].Value.ToString())).First();
            donHangmoi = _dhBLL.GetAllUnconfirmed().Where(r => r.MaDonHang == row.Cells[0].Value.ToString()).First();
            txtMaDH.Text = row.Cells[0].Value.ToString();
            txtName.Text = kh.HoTen;
            sdt.Text = kh.SDT;
            bought = _dhBLL.GetAllCTDHResult(txtMaDH.Text);

            this.flowPanel.Controls.Clear();
           
            foreach (var i in bought)
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

            decimal totalPrice = decimal.Parse(row.Cells[6].Value.ToString());
            txtPriceBefore.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice);
            txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice);

            var cts = _ct.GetAllActivating().Where(r => r.GiaTriHoaDon <= totalPrice).OrderBy(r => r.GiaTriPhanTram).FirstOrDefault();
            if (cts != null)
            {
                maCt = cts.MaCT;
                useKM.Enabled = true;
                txtKM.Text = ct = cts.DieuKienApDung + " - Giảm: " + cts.GiaTriPhanTram + $"% cho đơn hàng {_convertMoneyUnitBLL.ConvertToVND(cts.GiaTriHoaDon)} trở lên";
                _discount = totalPrice * (cts.GiaTriPhanTram / 100m);
            }
           
        }

        private void ToCompleteForm()
        {
            panel3.Visible = true;
            _currentStep = 2;
            btnPrint.Enabled = true;
            btnPrint.Click += btnPrint_Click;
            orderStepBtn.Enabled = false;
            orderStepBtn.BackColor = Color.ForestGreen;
            completeStepBtn.BackColor = Color.Orange;
            completeStepBtn.ForeColor = Color.White;
            cplBtn.Enabled = true;
            resultControl = new OrderResult(bought, donHangmoi, lichSuGD);
            resultControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(resultControl);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument_PrintPage();
        }


        private void PrintDocument_PrintPage()
        {

            // Đường dẫn và tên file theo cấu hình
            string folderPath = "../../../data/donhang/"; // Thay bằng đường dẫn cố định của bạn
            string fileName = $"DH_{lichSuGD.NgayTao.Date:yyyyMMdd}_{donHangmoi.MaDonHang}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);
            ResponseDTO.KhachHang kh = _khBLL.GetByIdOrByName(donHangmoi.TenKH);
            // Đảm bảo thư mục tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Tạo tài liệu PDF
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                page.Width = XUnit.FromMillimeter(190);  // Chiều rộng giấy hóa đơn (80mm)
                page.Height = XUnit.FromMillimeter(130 + bought.Count() * 15); // Chiều cao giấy hóa đơn (150mm)

                using (XGraphics gfx = XGraphics.FromPdfPage(page))
                {
                    Font font = new Font("Arial", 10);
                    XFont xFont = new XFont("Arial", 10, XFontStyleEx.Regular);
                    XFont xFontBold = new XFont("Arial", 12, XFontStyleEx.Bold);
                    int startX = 50;
                    int startY = 50;
                    int offset = 20;

                    // Vẽ tiêu đề hóa đơn, căn giữa
                    string title = "HÓA ĐƠN BÁN HÀNG";
                    gfx.DrawString(title, xFontBold, XBrushes.Black, new XPoint(page.Width / 2, startY), XStringFormats.Center);
                    offset += 40;

                    // Thông tin đơn hàng
                    gfx.DrawString($"Mã đơn hàng: {donHangmoi.MaDonHang}             Ngày tạo: {donHangmoi.NgayTao:dd/MM/yyyy hh:mm:ss tt}", xFontBold, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;
                    gfx.DrawString($"Nhân viên thực hiện: {userName}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;
                    gfx.DrawString($"Trạng thái: Đã thanh toán", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;

                    // Thông tin khách hàng
                    gfx.DrawString($"Khách hàng: {kh.HoTen}             SĐT: {kh.SDT}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 40;

                    // Danh sách sản phẩm
                    gfx.DrawString("Danh sách sản phẩm:", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;

                    foreach (var sp in bought)
                    {
                        gfx.DrawString($"{sp.TenSanPham}             SL: {sp.SoLuong}             Giá: {_convertMoneyUnitBLL.ConvertToVND(sp.ThanhTien)}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                        offset += 20;
                    }

                    offset += 20;

                    // Tổng tiền, giảm giá và trạng thái
                    gfx.DrawString($"Tổng tiền (Gồm VAT): {_convertMoneyUnitBLL.ConvertToVND(donHangmoi.ThanhTien)}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;
                    if (donHangmoi.GiamGia > 0)
                    {
                        gfx.DrawString($"Giảm giá: {_convertMoneyUnitBLL.ConvertToVND(donHangmoi.GiamGia)}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                        offset += 20;
                        gfx.DrawString($"({ct})", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    }
                    else
                    {
                        gfx.DrawString($"Giảm giá: {_convertMoneyUnitBLL.ConvertToVND(donHangmoi.GiamGia)}", xFont, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    }
                    offset += 20;

                    gfx.DrawString($"Thành tiền: {_convertMoneyUnitBLL.ConvertToVND(donHangmoi.ThanhTien - donHangmoi.GiamGia)}", xFontBold, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                    offset += 20;
                    gfx.DrawString($"Ghi chú: {donHangmoi.GhiChu}", xFontBold, XBrushes.Black, new XRect(startX, startY + offset, page.Width, page.Height), XStringFormats.TopLeft);
                }

                // Lưu tài liệu
                document.Save(fullPath);
            }

            MessageBox.Show($"Hóa đơn đã được tạo");
        }


        private bool Validation()
        {

            if (cbNh.SelectedIndex == 0 && cbPt.SelectedIndex != 1)
            {
                _errorProvider.SetError(cbNh, "Chọn ngân hàng");
                return false;
            }
            if (txtMaDH.Text == "")
            {
                _errorProvider.SetError(txtMaDH, "Chọn đơn hàng");
                return false;
            }
            _errorProvider.Clear();
            return true;
        }

        private void loadgrid()
        {
            IEnumerable<ResponseDTO.DonHang> dhs = _dhBLL.GetAllUnconfirmed();
            this.dataGrid.DataSource = dhs.ToList();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void SetCbData()
        {
            List<ComboBoxItemModel> ptCombo = new List<ComboBoxItemModel>()
            {
                new ComboBoxItemModel()
                {
                    Text = "Chuyển khoản",
                    Value = "Chuyển khoản"
                },
                  new ComboBoxItemModel()
                {
                    Text = "Tiền mặt",
                    Value = "Tiền mặt"
                }
            };
            cbPt.DataSource = ptCombo;
            cbPt.DisplayMember = "Text";
            cbPt.ValueMember = "Value";
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            if (cbPt.SelectedValue.ToString() == "Chuyển khoản")
            {
                if (string.IsNullOrWhiteSpace(maGd.Text))
                {
                    _errorProvider.SetError(maGd, "Không được để trống");
                    return;
                }
                lichSuGD.MaGiaoDich = maGd.Text;
            }
            else
            {
                lichSuGD.MaGiaoDich = IDAutoGeneratorBLL.Generate("GD", 10);
            }
            lichSuGD.NgayTao = DateTime.Now;
            lichSuGD.MaDonHang = txtMaDH.Text;
            lichSuGD.SoTien = decimal.Parse(txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4)); // errror
            lichSuGD.PhuongThuc = cbPt.SelectedValue.ToString();
            if (cbPt.SelectedIndex == 0)
            {
                lichSuGD.NganHang = cbNh.SelectedItem.ToString();

            }
            else
            {
                lichSuGD.NganHang = null;

            }


            try
            {
                lsgd.Create(lichSuGD); 
                _ct.UseEmptyKMCard(maCt, txtMaDH.Text);
                _dhBLL.UpdateOrderDiscount(txtMaDH.Text.ToString(), _discount);
                MessageBox.Show("Thành công", "Thanh toán thành công", MessageBoxButtons.OK);
                button1.PerformClick();
                refreshBtn.PerformClick();
                ToCompleteForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thanh toán lỗi", MessageBoxButtons.OK);
            }
        }

        private void cbPt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPt.SelectedValue.ToString() == "Chuyển khoản")
            {
                cbNh.Enabled = true;
                maGd.Enabled = true;
                recieveMoney.Enabled = false;
                leftMoney.Enabled = false;
            }
            else
            {
                cbNh.Enabled = false;
                maGd.Enabled = false;
                recieveMoney.Enabled = true;
                recieveMoney.Text = txtPricePayment.Text;
                leftMoney.Enabled = true;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            useKM.Enabled = false;
            donHangmoi.GiamGia = _discount;
            this.txtTotalPriceDiscount.Text = _convertMoneyUnitBLL.ConvertToVND(_discount);
            txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(decimal.Parse(txtPricePayment.Text.Substring(0, recieveMoney.Text.Length - 4)) - _discount);
        }

        private void txtPricePayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Clear();
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox tb)
                {
                    c.Text = string.Empty;
                }
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox tb)
                {
                    c.Text = string.Empty;
                }
            }
            cbNh.SelectedIndex = 1;
            cbNh.Enabled = false;
            txtPriceBefore.Text = "0 VND";
            txtPricePayment.Text = "0 VND";
            txtTotalPriceDiscount.Text = "0 VND";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

            orderStepBtn.BackColor = Color.Orange;
            cplBtn.Enabled= false;
            completeStepBtn.Enabled = false;
            completeStepBtn.BackColor = Color.White;
            completeStepBtn.ForeColor = Color.Black;
        }

        private void recieveMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal money = decimal.Parse(this.recieveMoney.Text.Substring(0, recieveMoney.Text.Length - 4));
                decimal total = decimal.Parse(this.txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4));
                if (money < total)
                {
                    this.recieveMoney.Text = _convertMoneyUnitBLL.ConvertToVND(total);
                    this.leftMoney.Text = "";
                }
                else
                {
                    leftMoney.Text = _convertMoneyUnitBLL.ConvertToVND(money - decimal.Parse(this.txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4)));
                }
            }
        }
    }
}
