using BLL;
using DTO;
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
            // Lưu trạng thái ban đầu
            main = new Panel
            {
                Dock = panel2.Dock,
                Size = panel2.Size,
                BackColor = panel2.BackColor
            };

            foreach (Control control in panel2.Controls)
            {
                if(control.Controls.Count > 0)
                {
                    main.Controls.Add(CloneControl(control)); // Sao chép thay vì di chuyển
                }
                else
                {
                    main.Controls.Add(control);
                }
            }


            this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;

            loadgrid();
            SetCbData();

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
            decimal vatPrice = 0;
            ResponseDTO.KhachHang kh = _khBLL.GetAll().Where(r => r.HoTen.Equals(row.Cells[2].Value.ToString())).First();
            donHangmoi = _dhBLL.GetAllUnconfirmed().Where(r => r.MaDonHang == row.Cells[0].Value.ToString()).First();
            txtMaDH.Text = row.Cells[0].Value.ToString();
            txtName.Text = kh.HoTen;
            sdt.Text = kh.SDT;
            bought = _dhBLL.GetAllCTDHResult(txtMaDH.Text);

            this.flowPanel.Controls.Clear();
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
            foreach (var i in bought)
            {
                lb.Text = i.TenSanPham + " - SL: " + i.SoLuong;
                price.Text = "Thành tiền: " + _convertMoneyUnitBLL.ConvertToVND(i.ThanhTien);
                vatPrice += (decimal)(i.ThanhTien * 0.05m);
                this.flowPanel.Controls.Add(lb);
                this.flowPanel.Controls.Add(price);
            }
            txtPriceBefore.Text = _convertMoneyUnitBLL.ConvertToVND(vatPrice);

            decimal totalPrice = decimal.Parse(this.txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4));
            var cts = _ct.GetAll().Where(r => r.GiaTriHoaDon <= totalPrice).OrderBy(r => r.GiaTriPhanTram).FirstOrDefault();
            if (cts != null)
            {
                maCt = cts.MaCT;
                useKM.Enabled = true;
                txtKM.Text = cts.MaCT + "-" + cts.GiaTriPhanTram + " " + cts.DieuKienApDung;
                _discount = totalPrice * cts.GiaTriPhanTram;
                txtTotalPriceDiscount.Text = "-" + _convertMoneyUnitBLL.ConvertToVND(_discount);
            }

            txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(decimal.Parse(row.Cells[6].Value.ToString()) + vatPrice - _discount);
            recieveMoney.Text = txtPricePayment.Text;
        }

        private void ToCompleteForm()
        {
            panel2.Controls.Clear();
            _currentStep = 2;
            orderStepBtn.Enabled = false;
            orderStepBtn.BackColor = Color.ForestGreen;
            completeStepBtn.BackColor = Color.Orange;
            completeStepBtn.ForeColor = Color.White;
            cplBtn.Enabled = true;
            resultControl = new OrderResult(bought, donHangmoi, lichSuGD);
            resultControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(resultControl);
        }

        private bool Validation()
        {

            if (cbNh.SelectedText == "Chọn")
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
        private bool ConfirmNextStep()
        {
            var result = MessageBox.Show("Xác nhận chuyển bước, mọi thay đổi sẽ được lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                switch (_currentStep)
                {
                    case 1:
                        if (string.IsNullOrWhiteSpace(txtMaDH.Text))
                        {
                            _errorProvider.SetError(txtMaDH, "Thiếu mã đơn hàng");
                            return false;
                        }
                        _currentStep++;
                        break;
                    case 2:
                        _currentStep = 1;
                        break;
                }
                return true;
            }
            return false;
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
                    Value = "Banking"
                },
                  new ComboBoxItemModel()
                {
                    Text = "Tiền mặt",
                    Value = "Cost"
                }
            };
            cbPt.DataSource = ptCombo;
            cbPt.DisplayMember = "Text";
            cbPt.ValueMember = "Value";
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            if (cbPt.SelectedValue.ToString() == "Banking")
            {
                if (string.IsNullOrWhiteSpace(maGd.Text))
                {
                    _errorProvider.SetError(maGd, "Không được để trống");
                    return;
                }
                lichSuGD.MaGiaoDich = txtMaDH.Text;
            }
            else
            {
                lichSuGD.MaGiaoDich = IDAutoGeneratorBLL.Generate("GD", 10);
            }
            lichSuGD.NgayTao = DateTime.Now;
            lichSuGD.MaDonHang = txtMaDH.Text;
            lichSuGD.SoTien = decimal.Parse(txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4)); // errror
            lichSuGD.PhuongThuc = cbPt.SelectedText!.ToString()!;
            lichSuGD.NganHang = cbNh.SelectedText!.ToString()!;

            try
            {
                lsgd.Create(lichSuGD);
                MessageBox.Show("Thành công", "Thanh toán thành công", MessageBoxButtons.OK);
                ToCompleteForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thanh toán lỗi", MessageBoxButtons.OK);
            }
        }

        private void cbPt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPt.SelectedValue.ToString() == "Banking")
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
            _ct.UseEmptyKMCard(maCt, txtMaDH.Text);
            this.txtTotalPriceDiscount.Text = _convertMoneyUnitBLL.ConvertToVND(_discount);
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
            txtPriceBefore.Text = "0 VND";
            txtPricePayment.Text = "0 VND";
            txtTotalPriceDiscount.Text = "0 VND";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Xóa tất cả control hiện tại
            foreach (Control control in main.Controls)
            {
                panel2.Controls.Add(control); // Thêm lại các control từ main
            }
            panel2.Dock = main.Dock; // Khôi phục thuộc tính Dock
            panel2.Size = main.Size; // Khôi phục kích thước
            panel2.BackColor = main.BackColor; // Khôi phục màu nền

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
