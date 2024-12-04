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

        private static byte _currentStep = 1;
        private decimal giaBanChon { get; set; }
        private Panel panel;
        private KhachHangBLL _khBLL;
        private ChiTietDonHangBLL _ctdhBLL;
        private SanPhamBLL _spBLL;
        private DonHangBLL _dhBLL;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private ErrorProvider _errorProvider;
        private IEnumerable<ResponseDTO.ChiTietDHResult> bought = new List<ResponseDTO.ChiTietDHResult>();
        private List<ProductCartModel> cart = new List<ProductCartModel>();
        private List<ResponseDTO.DonHang> _donHangs;
        private OrderResult resultControl;
        private PaymentControl paymentControl;
        private EditDTO.DonHang donHangmoi;
        private List<EditDTO.ChiTietDonHang> chitietDonHangMoi;
        private EditDTO.LichSuGD lichSuGD;



        public HandleOrderProcessForm(string uname)
        {
            InitializeComponent();
            this.userName = uname;
            this.panel = frame;
            this.Load += async (s, e) => await Config();
        }

        private async Task Config()
        {
            this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
            this._khBLL = new KhachHangBLL();
            this._dhBLL = new DonHangBLL();
            this._spBLL = new SanPhamBLL();
            this._ctdhBLL = new ChiTietDonHangBLL();
            this._errorProvider = new ErrorProvider();
            this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;
            this.nextBtn.Click += async (s, e) => await nextBtn_Click(s, e);
            this.deleteBtn.Click += deleteBtn_Click;
            this.cancelBtn.Click += async (s, e) => await cancelBtn_Click(s, e);
            frame.ControlRemoved += Frame_ControlRemoved;

            // load hoa don chua xu ly
            refreshBtn.PerformClick();

        }

        private void Frame_ControlRemoved(object? sender, ControlEventArgs e)
        {
            
        }

        private void DataGrid_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGrid.Rows[e.RowIndex];
            txtMaDH.Text = row.Cells[0].Value.ToString();
            txtPricePayment.Text = row.Cells[5].Value.ToString();
            bought = _dhBLL.GetAllCTDHResult(txtMaDH.Text);
            foreach (var item in bought)
            {
                ProductCartLine line = new ProductCartLine();
                line.txtName.Text = item.TenSanPham;
                line.quantity.Value = item.SoLuong;
                line.price.Text = _convertMoneyUnitBLL.ConvertToVND(item.ThanhTien);

                this.flowPanel.Controls.Add(line);
            }
        }

        private async Task nextBtn_Click(object sender, EventArgs e)
        {
            if (!ConfirmNextStep()) return;
            frame.Controls.Clear();
            _currentStep++;
            switch (_currentStep)
            {
                case 1:
                    frame = panel;
                    break;
                case 2:
                    orderStepBtn.BackColor = Color.Green;
                    paymentStepBtn.BackColor = Color.Orange;
                    paymentStepBtn.Enabled = true;
                    paymentControl = new PaymentControl(userName, donHangmoi);
                    frame.Controls.Add(paymentControl);
                    break;
                case 3:
                    orderStepBtn.Enabled = false;
                    paymentStepBtn.Enabled = false;
                    resultControl = new OrderResult(bought, donHangmoi, lichSuGD);
                    frame.Controls.Add(resultControl);

                    break;
            }
        }

        private async Task HandleOrder()
        {
            List<StoreOrder> stored = await ReadOrderFromJsonFile($"../../../data/orders.json");
            stored.Remove(stored.Where(r => r.DonHang.MaDonHang == txtMaDH.Text).First());
            await WriteToJsonFile($"../../../data/orders.json", stored);
        }
        public static async Task WriteToJsonFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Format đẹp
            string jsonString = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, jsonString);
        }
        public static async Task<List<StoreOrder>> ReadOrderFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            string jsonString = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<StoreOrder>>(jsonString);
        }

        private bool Validation()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    // required
                    if (tb.Name != "txtNote")
                    {
                        if (string.IsNullOrWhiteSpace(tb.Text))
                        {
                            _errorProvider.SetError(tb, "Không được để trống");
                            return false;
                        }
                    }
                }
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = _dhBLL.Delete(txtMaDH.Text);
            _donHangs.Remove(_donHangs.Where(r => r.MaDonHang == txtMaDH.Text).First());

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void loadgrid()
        {
            IEnumerable<ResponseDTO.DonHang> dhs = _dhBLL.GetAllUnconfirmed();
            this.dataGrid.DataSource = dhs;
            this.dataGrid.Show();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                this.dataGrid.DataSource = _donHangs;
            }
            loadgrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // get value KM 
            decimal totalPrice = decimal.Parse(this.txtPricePayment.Text);
            this.txtTotalPriceDiscount.Text = "0";
            this.txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice - 0);
        }

        private bool ConfirmNextStep()
        {
            var result = MessageBox.Show("Xác nhận chuyển bước, mọi thay đổi sẽ được lưu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
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
                        lichSuGD = paymentControl.lichSuGD;
                        if(lichSuGD == null)
                        {
                            return false;
                        }
                        _currentStep++;
                        break;
                }
                return true;
            }
            return false;
        }
     
    }
}
