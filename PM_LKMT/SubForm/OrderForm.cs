using BLL;
using DTO;
using System.Data;
using System.Text.Json;
using static DAL.LKMT;

namespace PM_LKMT.SubForm
{
    public partial class OrderForm : Form
    {
        private string userName { get; set; }
        private KhachHangBLL _khBLL;
        private SanPhamBLL _spBLL;
        private DonHangBLL _dhBLL;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private ErrorProvider _errorProvider;
        private List<EditDTO.ChiTietDonHang> sps = new List<EditDTO.ChiTietDonHang>();
        private List<ProductCartModel> cart = new List<ProductCartModel>();
        private List<ResponseDTO.DonHang> _donHangs;
        private List<ResponseDTO.SanPham> _sanPhams;
        public OrderForm(string uname)
        {
            InitializeComponent();
			this.userName = uname;

			this.Load += async (s, e) => await Config();
        }

        private async Task Config()
        {
			this._convertMoneyUnitBLL = new ConvertMoneyUnitBLL();
			this._khBLL = new KhachHangBLL();
			this._dhBLL = new DonHangBLL();
			this._spBLL = new SanPhamBLL();
			this._errorProvider = new ErrorProvider();
			this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;
			this.addBtn.button.Click += addToCartBtn_Click;
            this.createBtn.button1.Click += createBtn_Click;
            this.deleteBtn.button1.Click += deleteBtn_Click;
            this.cancelBtn.button1.Click += cancelBtn_Click;
			cart = await ReadFromJsonFile($"../../../data/cart.json");
            gridProductSelected.DataSource = cart;
        }
        private void DataGrid_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            var row = this.dataGrid.Rows[e.RowIndex];
            if (comboTable.Items[comboTable.SelectedIndex]!.ToString() == "Đơn hàng")
            {
                txtMaHD.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                txtSLC.Text = row.Cells[8].Value.ToString();
                txtTH.Text = row.Cells[3].Value.ToString();
                txtProductName.Text = row.Cells[0].Value.ToString() + '-' + row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString() + "VND";
                txtQuantity.Text = "";
                if (img.Image != null)
                {
                    img.Image.Dispose();
                    img.Image = null;
                }
                string filePath = $"../../../images/Product/{row.Cells[0].Value.ToString()}.jpg";

                if (File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        img.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    MessageBox.Show("File not found: " + filePath);
                }


            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!Validation()) return;
            EditDTO.DonHang donHangMoi = new EditDTO.DonHang();
            donHangMoi.MaDonHang = IDAutoGeneratorBLL.Generate("DH", 8);
            donHangMoi.TinhTrang = true;
            donHangMoi.NhanVienTao = LoginBLL.GetCurrentUserId(this.userName);
            donHangMoi.DaXoa = false;
            donHangMoi.NgayTao = TimeHelper.GetCurrentTime().DateTime;
            donHangMoi.ThanhTien = decimal.Parse(txtTotalPrice.Text);
            donHangMoi.TongSL = int.Parse(txtTotalQuantity.Text);
            donHangMoi.GhiChu = txtNote.Text;
            donHangMoi.MaKH = _khBLL.CheckCustomer(txtSDT.Text);

            foreach (var item in sps)
            {
                item.MaDonHang = donHangMoi.MaDonHang;
            }
            string message = _dhBLL.Create(donHangMoi, sps.ToArray());
            _donHangs.Add(new ResponseDTO.DonHang()
            {
                MaDonHang = donHangMoi.MaDonHang,
                TinhTrang = donHangMoi.TinhTrang,
                TenNhanVien = userName,
                NgayTao = donHangMoi.NgayTao,
                ThanhTien = donHangMoi.ThanhTien,
                TongSL = donHangMoi.TongSL,
                GhiChu = donHangMoi.GhiChu,
                TenKH = _khBLL.GetById(donHangMoi.MaKH).HoTen,
			});
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb)
                {
                    // required
                    if (tb.Name != "txtNote")
                    {
                        if (!string.IsNullOrWhiteSpace(tb.Text))
                        {
                            tb.Text = string.Empty;
                        }
                    }
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string message = _dhBLL.Delete(txtMaHD.Text);
            _donHangs.Remove(_donHangs.Where(r => r.MaDonHang == txtMaHD.Text).First());

			MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ComboBoxItemModel> items;
            if (comboTable.Items[comboTable.SelectedIndex]!.ToString() == "Đơn hàng")
            {
                _donHangs = _dhBLL.GetAll().ToList();
                searchTxt.PlaceholderText = "Nhập mã đơn hàng";

                if (_sanPhams != null)
                {
                    _sanPhams.Clear();
                }
                this.dataGrid.DataSource = _donHangs;

            }
            else
            {
                _sanPhams = _spBLL.GetAll().ToList();
                searchTxt.PlaceholderText = "Nhập mã hoặc tên sản phẩm";

                if (_donHangs != null)
                {
                    _donHangs.Clear();
                }
                this.dataGrid.DataSource = _sanPhams;
            }
            this.dataGrid.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboTable.Items[comboTable.SelectedIndex]!.ToString() == "Đơn hàng")
            {
                List<ResponseDTO.DonHang> dhs = _donHangs;
                ResponseDTO.DonHang dh = dhs.Where(r => r.MaDonHang == this.searchTxt.Text).FirstOrDefault()!;

                if (dh == null)
                {
                    return;
                }
                dhs = new List<ResponseDTO.DonHang>() { dh };
                this.dataGrid.DataSource = dhs;
            }
            else
            {
                List<ResponseDTO.SanPham> sps = (List<ResponseDTO.SanPham>)this.dataGrid.DataSource;
                ResponseDTO.SanPham sp = sps.Where(r => r.MaSanPham == this.searchTxt.Text || r.TenSanPham.ToLower().Contains(searchTxt.Text.ToLower())).FirstOrDefault()!;
                if (sp == null)
                {
                    return;
                }
                sps = new List<ResponseDTO.SanPham>() { sp };
                this.dataGrid.DataSource = sps;
            }
            this.dataGrid.Show();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text == "")
            {
                MessageBox.Show("Nhập số lượng mua", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			int slcon = int.Parse(txtSLC.Text);
			int slmua = int.Parse(txtQuantity.Text);
			if (slmua > slcon)
			{
				MessageBox.Show("Vượt quá số lượng hàng hiện có!", "Thông báo");
				return;
			}
			ProductCartModel giohang = new ProductCartModel() { MaSanPham = this.ProductName.Split('-')[0], TenSanPham = this.ProductName.Split('-')[1], ThanhTien = decimal.Parse(this.txtTotalPrice.Text), SoLuong = int.Parse(this.txtTotalQuantity.Text), GiaBan = decimal.Parse(txtPrice.Text) };
            ProductCartModel prEx = cart.Where(r => r.MaSanPham == giohang.MaSanPham).FirstOrDefault()!;

            if (prEx == null)
            {
                cart.Add(giohang);
            }
            else
            {
                cart.Remove(prEx);
                prEx.SoLuong = giohang.SoLuong;
                cart.Add(prEx);
            }
            this.gridProductSelected.DataSource = cart;
            this.gridProductSelected.Show();
            UpdateTotalQuantityAndPrice();
        }

        private void UpdateTotalQuantityAndPrice()
        {
            int totalQuantity = 0;
            decimal totalPrice = 0;
            foreach(ProductCartModel cart in cart)
            {
                totalQuantity += cart.SoLuong;
                totalPrice += cart.ThanhTien;
            }
            this.txtTotalQuantity.Text = totalQuantity.ToString();
            this.txtTotalPrice.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if(searchTxt.Text == "")
            {
                this.dataGrid.DataSource = _donHangs != null ? _donHangs : _sanPhams;
            }
            button1_Click(sender, e);
        }
    }
}
