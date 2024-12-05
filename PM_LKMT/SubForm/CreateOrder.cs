using BLL;
using DTO;
using System.Data;
using System.Text.Json;

namespace PM_LKMT.SubForm
{
    public partial class CreateOrder : Form
    {
        private string userName { get; set; }
        private decimal giaBanChon { get; set; }
        private string makh = string.Empty;
        private static byte _currentStep;
        private Panel frame;
        private KhachHangBLL _khBLL;
        private DonHangBLL _dhBLL;
        private ChiTietDonHangBLL _ctdhbll;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private List<ProductCartModel> cart = new List<ProductCartModel>();
        private List<ResponseDTO.DonHang> _donHangs;

        private ErrorProvider _errorProvider;


        public CreateOrder(string uname)
        {
            InitializeComponent();
            this.userName = uname;
            this.Load += async (s, e) => await Config();
        }

        private async Task Config()
        {
            this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
            this._khBLL = new KhachHangBLL();
            this._ctdhbll = new ChiTietDonHangBLL();
            this._dhBLL = new DonHangBLL();
            _errorProvider = new ErrorProvider();
            this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;
            this.createBtn.Click += async (s, e) => await createBtn_Click(s, e);
            this.cancelBtn.Click += async (s, e) => await cancelBtn_Click(s, e);
            cart = await ReadFromJsonFile($"../../../data/cart.json");
            if (cart.Count > 0)
            {
                status.Text = "Chưa thanh toán";
                foreach (var item in cart)
                {
                    ProductCartLine line = new ProductCartLine();
                    line.txtName.Text = item.TenSanPham;
                    line._giaBan = item.ThanhTien / item.SoLuong;
                    line.quantity.Value = item.SoLuong;
                    line.quantity.ValueChanged += Quantity_ValueChanged;
                    line.price.Text = _convertMoneyUnitBLL.ConvertToVND(item.ThanhTien);

                    this.flowPanel.Controls.Add(line);
                }
            }
            List<ComboBoxItemModel> cbItms = new List<ComboBoxItemModel>()
            {
                 new ComboBoxItemModel()
                {
                    Text = "Hôm nay",
                    Value = "Today"
                },
                new ComboBoxItemModel()
                {
                    Text = "Hôm qua",
                    Value = "Yesterday"
                },
                 new ComboBoxItemModel()
                {
                    Text = "Đã thanh toán",
                    Value = "Paid"
                },new ComboBoxItemModel()
                {
                    Text = "Chưa thanh toán",
                    Value = "Pay"
                }
            };
            cbFilter.DataSource = cbItms;
            cbFilter.DisplayMember = "Text";
            cbFilter.ValueMember = "Value";
            cbFilter.SelectedIndexChanged += CbFilter_SelectedIndexChanged;

            UpdateTotalQuantityAndPrice();
            loadGrid();

        }

        private void CbFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {

            switch (cbFilter.SelectedValue)
            {
                case "Paid":
                    dataGrid.DataSource = _donHangs.Where(r => r.TinhTrang.Equals("Ðã thanh toán")).ToList();
                    break;
                case "Pay":
                    dataGrid.DataSource = _donHangs.Where(r => r.TinhTrang.Equals("Chưa thanh toán")).ToList();
                    break;
                case "Today":
                    loadGrid();
                    dataGrid.DataSource = _donHangs;
                    break;
                case "Yesterday":
                    var yesterday = DateTime.Today.AddDays(-1); // Ngày hôm qua, lúc 00:00
                    var startOfYesterday = yesterday; // Bắt đầu ngày hôm qua
                    var endOfYesterday = yesterday.AddDays(1).AddTicks(-1); // Cuối ngày hôm qua, lúc 23:59:59.999

                    dataGrid.DataSource = _donHangs
                        .Where(r => r.NgayTao >= startOfYesterday && r.NgayTao <= endOfYesterday)
                        .ToList();

                    break;
            }
        }

        private void Quantity_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotalQuantityAndPrice();
        }

        private void DataGrid_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGrid.Rows[e.RowIndex];
            txtMaDH.Text = row.Cells[0].Value.ToString();
            txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(decimal.Parse(row.Cells[6].Value.ToString()));
            status.Text = row.Cells[4].Value.ToString();
            ResponseDTO.KhachHang kh = _khBLL.GetAll().Where(r => r.HoTen.Equals(row.Cells[2].Value.ToString())).First();
            txtName.Text = kh.HoTen;
            sdt.Text = kh.SDT;
            this.flowPanel.Controls.Clear();
            foreach (var i in _dhBLL.GetAllCTDHResult(txtMaDH.Text))
            {
                ProductCartLine line = new ProductCartLine();
                line.txtName.Text = i.TenSanPham;
                line.quantity.Value = i.SoLuong;
                line.quantity.Enabled = false;
                line.quantity.ValueChanged += Quantity_ValueChanged;
                line.price.Text = _convertMoneyUnitBLL.ConvertToVND(i.ThanhTien);

                this.flowPanel.Controls.Add(line);
            }

        }

        public static async Task WriteToJsonFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Format đẹp
            string jsonString = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, jsonString);
        }

        private async Task createBtn_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            if (flowPanel.Controls.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào để tạo ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (makh == string.Empty)
                {
                    CreateNewCus();
                }
                EditDTO.DonHang donHangMoi = new EditDTO.DonHang();
                donHangMoi.MaDonHang = IDAutoGeneratorBLL.Generate("DH", 8);
                this.txtMaDH.Text = donHangMoi.MaDonHang;
                donHangMoi.TinhTrang = "Chưa thanh toán";
                donHangMoi.NhanVienTao = LoginBLL.GetCurrentUserId(this.userName);
                donHangMoi.DaXoa = false;
                donHangMoi.MaKH = makh;
                donHangMoi.NgayTao = TimeHelper.GetCurrentTime().DateTime;
                donHangMoi.ThanhTien = decimal.Parse(txtPricePayment.Text.Substring(0, txtPricePayment.Text.Length - 4));
                donHangMoi.GhiChu = txtNote.Text;
                _dhBLL.Create(donHangMoi);
                _ctdhbll.CreateRange(donHangMoi.MaDonHang, cart);

                MessageBox.Show("Tạo đơn hàng thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo đơn hàng " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //refresh
            _donHangs = _dhBLL.GetAllToday().ToList();
            dataGrid.DataSource = _donHangs;
            Clear();
            // lam moi gio hang
            cart = new List<ProductCartModel>();
            await WriteToJsonFile($"../../../data/cart.json", cart);
            loadGrid();
        }

        private void Clear()
        {
            flowPanel.Controls.Clear();
            txtMaDH.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtName.Text = string.Empty;
            sdt.Text = string.Empty;
            searchtxt.Text = string.Empty;
            txtPricePayment.Text = "0 VND";
            status.Text = "";
        }
        private async Task cancelBtn_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0)
            {

                var opt = MessageBox.Show("Đơn hiện tại đang xử lý, Xác nhận hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opt == DialogResult.OK)
                {
                    cart = new List<ProductCartModel>();
                    await WriteToJsonFile($"../../../data/cart.json", cart);
                    Clear();
                }
            }

        }

        // Đọc dữ liệu từ file JSON
        public static async Task<List<ProductCartModel>> ReadFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            string jsonString = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<ProductCartModel>>(jsonString);
        }

        // Đọc dữ liệu từ file JSON
        public static async Task<List<StoreOrder>> ReadOrderFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            string jsonString = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<StoreOrder>>(jsonString);
        }

        private void loadGrid()
        {
            List<ComboBoxItemModel> items;
            _donHangs = _dhBLL.GetAllToday().ToList();
            if (_donHangs == null || _donHangs.Count == 0)
            {
                return;
            }
            this.dataGrid.DataSource = _donHangs;
            this.dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGrid.Show();

        }

        private void reloadGrid()
        {
            List<ResponseDTO.DonHang> dhs = _donHangs;
            ResponseDTO.DonHang dh = dhs.Where(r => r.MaDonHang == this.searchtxt.Text).FirstOrDefault()!;

            if (dh == null)
            {
                return;
            }
            dhs = new List<ResponseDTO.DonHang>() { dh };
            this.dataGrid.DataSource = dhs;
            this.dataGrid.Show();
        }

        private void UpdateTotalQuantityAndPrice()
        {
            decimal totalQuantity = 0;
            decimal totalPrice = 0;
            foreach (Control c in this.flowPanel.Controls)
            {
                if (c is ProductCartLine cart)
                {

                    totalQuantity += cart.quantity.Value;
                    totalPrice += decimal.Parse(cart.price.Text.Substring(0, cart.price.Text.Length - 4));
                }
            }
            this.txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                this.dataGrid.DataSource = _donHangs;
                return;
            }
            reloadGrid();
        }

        private void CreateNewCus()
        {
            if (!Validation()) return;
            EditDTO.KhachHang kh = new EditDTO.KhachHang();
            kh.MaKH = IDAutoGeneratorBLL.Generate("KH", 7);
            kh.HoTen = txtName.Text;
            kh.NgayThamGia = DateTime.Now;
            kh.NguoiChinhSuaGanNhat = LoginBLL.GetCurrentUserId(this.userName);
            kh.SDT = sdt.Text;
            makh = kh.MaKH;
            if (string.IsNullOrWhiteSpace(kh.HoTen))
            {
                MessageBox.Show("Nhập đầy đủ thông tin mã khách hàng và họ tên", "Lỗi", MessageBoxButtons.OK);
                return;
            }

        }

        private bool Validation()
        {
            foreach (Control c in this.panelInfo.Controls)
            {
                if (c is TextBox tb)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text) && tb.Name != "txtNote" && tb.Name != "txtMaDH")
                    {
                        _errorProvider.SetError(tb, "Không được để trống");
                        return false;
                    }
                }
            }
            _errorProvider.Clear();
            return true;
        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {
            if (sdt.Text.Length >= 10)
            {
                ResponseDTO.KhachHang kh = _khBLL.GetAll().Where(r => r.SDT.Trim().Equals(sdt.Text) || r.HoTen.ToLower() == txtName.Text.ToLower()).FirstOrDefault();
                if (kh != null)
                {
                    makh = kh.MaKH;
                    txtName.Text = kh.HoTen;
                    sdt.Text = kh.SDT;
                }
                else
                {
                    MessageBox.Show("Chưa có thông tin khách hàng ! Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void searchtxt_TextChanged_2(object sender, EventArgs e)
        {
            loadGrid();
            ResponseDTO.DonHang found = _donHangs.Where(r => r.MaDonHang == searchtxt.Text).FirstOrDefault();
            if (found != null)
            {
                return;
            }
            dataGrid.DataSource = found;
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirm = MessageBox.Show("Xác nhận xóa !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.OK)
            {
                ResponseDTO.DonHang found = _donHangs.Where(r => r.MaDonHang == txtMaDH.Text).FirstOrDefault();
                if (found != null)
                {
                    _dhBLL.Delete(found.MaDonHang);
                    loadGrid();
                    dataGrid.DataSource = _donHangs;
                    Clear();
                    MessageBox.Show("Xóa thành công đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
