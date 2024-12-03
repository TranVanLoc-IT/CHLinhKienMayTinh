using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.LKMT;

namespace PM_LKMT.SubForm
{
    public partial class CreateOrder : Form
    {
        private string userName { get; set; }
        private decimal giaBanChon { get; set; }
        private KhachHangBLL _khBLL;
        private DonHangBLL _dhBLL;
        private ChiTietDonHangBLL _ctdhbll;
        private ConvertMoneyUnitBLL _convertMoneyUnitBLL;
        private List<EditDTO.ChiTietDonHang> sps = new List<EditDTO.ChiTietDonHang>();
        private List<ProductCartModel> cart = new List<ProductCartModel>();
        private List<ResponseDTO.DonHang> _donHangs;


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
            this.dataGrid.RowHeaderMouseClick += DataGrid_RowHeaderMouseClick;
            this.createBtn.Click += async (s, e) => await createBtn_Click(s, e);
            this.deleteBtn.Click += deleteBtn_Click;
            this.cancelBtn.Click += async (s, e) => await cancelBtn_Click(s, e);
            cart = await ReadFromJsonFile($"../../../data/cart.json");
            if(cart == null || cart.Count == 0)
            {
                Label lb = new Label();
                lb.Text = "Chưa có sản phẩm nào được chọn !!";
                lb.Font = new Font("Arial", 16, FontStyle.Bold); // Thiết lập font chữ 16, in đậm
                lb.ForeColor = Color.Red; // Thiết lập màu chữ đỏ

                this.flowPanel.Controls.Add(lb);
            }
            else
            {

                foreach (var item in cart)
                {
                    ProductCartLine line = new ProductCartLine();
                    line.txtName.Text = item.TenSanPham;
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
                case "Today":
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
            txtPricePayment.Text = row.Cells[5].Value.ToString();
           

        }

        public static async Task WriteToJsonFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Format đẹp
            string jsonString = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, jsonString);
        }

        private async Task createBtn_Click(object sender, EventArgs e)
        {
            EditDTO.DonHang donHangMoi = new EditDTO.DonHang();
            donHangMoi.MaDonHang = IDAutoGeneratorBLL.Generate("DH", 8);
            this.txtMaDH.Text = donHangMoi.MaDonHang;
            donHangMoi.TinhTrang = "Chưa duyệt";
            donHangMoi.NhanVienTao = LoginBLL.GetCurrentUserId(this.userName);
            donHangMoi.DaXoa = false;
            donHangMoi.NgayTao = TimeHelper.GetCurrentTime().DateTime;
            donHangMoi.GhiChu = txtNote.Text;
            AddProductCart(donHangMoi.MaDonHang);
            try
            {
                _dhBLL.Create(donHangMoi);
                _ctdhbll.CreateRange(sps);
                MessageBox.Show("Tạo đơn hàng thành công !" , "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo đơn hàng " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //refresh

            _donHangs = _dhBLL.GetAllToday().ToList();
            dataGrid.DataSource = _donHangs;
            // them san pham mua
            cart = new List<ProductCartModel>();
            await WriteToJsonFile($"../../../data/cart.json", cart);
        }

        private void AddProductCart(string maDonHang)
        {
            foreach (var item in sps)
            {
                item.MaDonHang = maDonHang;
            }
        }


        private async Task cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                List<StoreOrder> stored = await ReadOrderFromJsonFile($"../../../data/orders.json");
                StoreOrder order = stored.Where(r => r.DonHang.MaDonHang == this.txtMaDH.Text).First();
                if (order == null)
                {
                    MessageBox.Show("Nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                stored.Remove(order);
                flowPanel.Controls.Clear();
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

        private void loadGrid()
        {
            List<ComboBoxItemModel> items;
            _donHangs = _dhBLL.GetAllToday().ToList();
            if(_donHangs == null)
            {
                dataGrid.Rows.Add("Không có dữ liệu");
                return;
            }
            this.dataGrid.DataSource = _donHangs;
            //this.dataGrid.Columns["Tổng tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////this.dataGrid.Columns["Số lượng mua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.dataGrid.Columns["Đơn giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGrid.Show();

        }

        private void button1_Click(object sender, EventArgs e)
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
            foreach (ProductCartLine cart in this.flowPanel.Controls)
            {
                totalQuantity += cart.quantity.Value;
                totalPrice += decimal.Parse(cart.price.Text.Substring(0, cart.price.Text.Length - 4));
            }
            this.txtPricePayment.Text = _convertMoneyUnitBLL.ConvertToVND(totalPrice);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                this.dataGrid.DataSource = _donHangs;
            }
            button1_Click(sender, e);
        }

        private void searchtxt_TextChanged_1(object sender, EventArgs e)
        {
            ResponseDTO.DonHang found = _donHangs.Where(r => r.MaDonHang == searchtxt.Text).FirstOrDefault();
            if (found != null)
            {
                return;
            }
            dataGrid.DataSource = found;
        }
    }
}
