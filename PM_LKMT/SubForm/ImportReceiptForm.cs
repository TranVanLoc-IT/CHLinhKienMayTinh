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

namespace PM_LKMT.SubForm
{
    public partial class ImportReceiptForm : Form
    {
        PhieuNhapBLL phieuNhapBLL = new PhieuNhapBLL();
        ChiTietPhieuNhapBLL chiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
        public ImportReceiptForm()
        {
            InitializeComponent();
            this.Load += ImportReceiptForm_Load;
            this.dgvPN.CellFormatting += DgvPN_CellFormatting;
            this.dgvPN.SelectionChanged += DgvPN_SelectionChanged;
            this.dgvCTPN.CellFormatting += DgvCTPN_CellFormatting;
        }

        private void DgvCTPN_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columnsToFormat = new List<string> { "GiaNhap", "ThanhTien" };

            if (columnsToFormat.Contains(dgvCTPN.Columns[e.ColumnIndex].Name) && e.Value != null)
            {
                e.Value = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void DgvPN_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPN.SelectedRows.Count > 0)
            {
                string idPN = dgvPN.CurrentRow.Cells[0].Value.ToString();
                loadCTPN(idPN);
                txtTotalPrice.Text = chiTietPhieuNhapBLL.GetTotal(idPN).ToString("C0", new System.Globalization.CultureInfo("vi-VN"));

            }
        }

        private void DgvPN_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPN.Columns[e.ColumnIndex].Name == "TongTien" && e.Value != null)
            {
                e.Value = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void ImportReceiptForm_Load(object? sender, EventArgs e)
        {
            loadPN();
        }

        public void loadPN()
        {
            dgvPN.DataSource = phieuNhapBLL.GetAll();
            dgvPN.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPN.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPN.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
            dgvPN.Columns["TongTien"].HeaderText = "Tổng tiền";
            dgvPN.Columns["NgayNhap"].HeaderText = "Ngày nhập";
        }

        public void loadCTPN(string idPN)
        {
            ChiTietPhieuNhapBLL ctpnBLL = new ChiTietPhieuNhapBLL();
            dgvCTPN.DataSource = ctpnBLL.GetAll(idPN);
            dgvCTPN.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvCTPN.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvCTPN.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCTPN.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvCTPN.Columns["GiaNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTPN.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCTPN.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
