using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.UserControlCustom
{
    public partial class WarehouseForm : Form
    {
        private KhoBLL _khoBLL;
        public WarehouseForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dgvkho.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvkho.RowTemplate.Height = 50;
            dgvkho.DataBindingComplete += dgvkho_DataBindingComplete;
            _khoBLL = new KhoBLL();
            LoadData();
        }
        private void LoadData()
        {
            var products = _khoBLL.GetDataTable();

            // Bind dữ liệu sản phẩm vào ComboBox
            cbProducts.DataSource = products;  // cbProducts là ComboBox
            cbProducts.DisplayMember = "TenSanPham"; // Hiển thị tên sản phẩm
            cbProducts.ValueMember = "MaSanPham";    // Lưu mã sản phẩm

            dgvkho.DataSource = products;
            dgvkho.AllowUserToAddRows = false; // Tắt hàng thêm mới

            txtTongSanPham.Text = products.Count.ToString();

        }
        private void WarehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue == null) return;

            // Lấy mã sản phẩm được chọn
            string selectedProductId = cbProducts.SelectedValue.ToString();

            // Lấy dữ liệu sản phẩm từ BLL
            var products = _khoBLL.GetDataTable();
            var product = products.FirstOrDefault(p => p.MaSanPham == selectedProductId);

            if (product != null)
            {
                txtTongSLBan.Text = product.SoLuongDaBan.ToString();
                txtDonGia.Text = product.DonGia.ToString("C"); // Hiển thị đơn giá
                lb1.Text = (product.SoLuongDaBan * product.DonGia).ToString("C");
                txtThoiGianBaoHanh.Text = product.TGBaoHanh.ToString() + " tháng";
                txtCapNhatGanNhat.Text = product.CapNhatGanNhat.ToString("dd/MM/yyyy");
                txtSoLuongTon.Text = product.SoLuongTon.ToString();
            }
        }
        private void CustomizeDGV()
        {
            if (dgvkho.Columns["MoTa"] != null)
                dgvkho.Columns["MoTa"].Visible = false; // Ẩn cột Mô tả
            if (dgvkho.Columns["HinhAnh"] != null)
                dgvkho.Columns["HinhAnh"].Visible = false; // Ẩn cột Hình ảnh
            if (dgvkho.Columns["DaXoa"] != null)
                dgvkho.Columns["DaXoa"].Visible = false; // Ẩn cột Đã xóa

            // Thay đổi tiêu đề cột sang tiếng Việt
            if (dgvkho.Columns["MaSanPham"] != null)
                dgvkho.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm"; // Tiêu đề cột Mã Sản Phẩm
            if (dgvkho.Columns["TenSanPham"] != null)
                dgvkho.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm"; // Tiêu đề cột Tên Sản Phẩm
            if (dgvkho.Columns["DonGia"] != null)
                dgvkho.Columns["DonGia"].HeaderText = "Đơn Giá"; // Tiêu đề cột Đơn Giá
            if (dgvkho.Columns["SoLuongTon"] != null)
                dgvkho.Columns["SoLuongTon"].HeaderText = "Số Lượng Tồn"; // Tiêu đề cột Số Lượng Tồn
            if (dgvkho.Columns["SoLuongDaBan"] != null)
                dgvkho.Columns["SoLuongDaBan"].HeaderText = "Số Lượng Đã Bán"; // Tiêu đề cột Số Lượng Đã Bán
            if (dgvkho.Columns["TGBaoHanh"] != null)
                dgvkho.Columns["TGBaoHanh"].HeaderText = "Thời Gian Bảo Hành"; // Tiêu đề cột Thời Gian Bảo Hành

            // Điều chỉnh kích thước cột cho phù hợp nội dung
            dgvkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvkho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgvkho.Rows[e.RowIndex];

                // Gán dữ liệu vào các TextBox
                txtTongSLBan.Text = row.Cells["SoLuongDaBan"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value != null
                    ? Convert.ToDecimal(row.Cells["DonGia"].Value).ToString("C")
                    : string.Empty;
                txtTongDoanhThu.Text = row.Cells["SoLuongDaBan"].Value != null && row.Cells["DonGia"].Value != null
                    ? (Convert.ToDecimal(row.Cells["SoLuongDaBan"].Value) * Convert.ToDecimal(row.Cells["DonGia"].Value)).ToString("C")
                    : string.Empty;
                txtThoiGianBaoHanh.Text = row.Cells["TGBaoHanh"].Value != null
                    ? row.Cells["TGBaoHanh"].Value.ToString() + " tháng"
                    : string.Empty;
                txtCapNhatGanNhat.Text = row.Cells["CapNhatGanNhat"].Value != null
                    ? Convert.ToDateTime(row.Cells["CapNhatGanNhat"].Value).ToString("dd/MM/yyyy")
                    : string.Empty;
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
            }
        }

        private void dgvkho_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomizeDGV();
        }
    }
}
