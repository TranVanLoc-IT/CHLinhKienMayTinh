using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using PM_LKMT.Controls.Button;

namespace PM_LKMT.SubForm
{
    public partial class FrmTHuongHieu : Form
    {
        ThuongHieuBLL thuongHieuBLL = new ThuongHieuBLL();
        EditDTO.ThuongHieu th = new EditDTO.ThuongHieu();
        bool seleted = false;

        public FrmTHuongHieu()
        {
            InitializeComponent();
        }

        private void FrmTHuongHieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thuongHieuBLL.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maTH = maTHText.Text;
            string tenTH = tenTHText.Text;
            DateTime dateTime = DateTime.Now;
            bool daXoa = false;
            if (string.IsNullOrEmpty(maTH) || string.IsNullOrEmpty(tenTH))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
                return;
            }
            th.MaThuongHieu = maTH;
            th.TenThuongHieu = tenTH;
            th.NgayTao = dateTime;
            th.DaXoa = daXoa;
            if (thuongHieuBLL.Them(th) == 1)
            {
                MessageBox.Show("Thêm thành công!!!");
                ResetDataSet(thuongHieuBLL.GetData());
            }
            else
            {
                MessageBox.Show("Thêm không thành công!!!");
            }
        }

        private void ResetDataSet(DataTable dataTable)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (thuongHieuBLL.Xoa(th) == 1)
            {
                MessageBox.Show("Xóa thành công!!!");
                ResetDataSet(thuongHieuBLL.GetData());
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo hàng được chọn hợp lệ
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị cột theo tên
                th.MaThuongHieu = selectedRow.Cells["MaThuongHieu"].Value?.ToString();
                th.TenThuongHieu = selectedRow.Cells["TenThuongHieu"].Value?.ToString();

                // Chuyển đổi giá trị ngày tạo
                string ngayTaoStr = selectedRow.Cells["NgayTao"].Value?.ToString();
                th.NgayTao = DateTime.ParseExact(ngayTaoStr, "M/d/yyyy h:mm:ss tt",
                    System.Globalization.CultureInfo.InvariantCulture);

                th.DaXoa = bool.Parse(selectedRow.Cells["DaXoa"].Value?.ToString());
                seleted = true;
            }
            else
            {
                seleted = false;
            }
        }

    }
}
