using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.LKMT;

namespace PM_LKMT.SubForm
{
    public partial class ViewProgramVoucher : Form
    {
        ChuongTrinhBLL bLL;
        public ViewProgramVoucher()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dgvProgramVour.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dgvProgramVour.RowTemplate.Height = 50;
            bLL = new ChuongTrinhBLL();
            this.Load += ViewProgramVoucher_Load;
            dgvProgramVour.SelectionChanged += DgvProgramVour_SelectionChanged;
            btnAdd.Click += BtnAdd_Click;
            btnDelete.Click += BtnDelete_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnKhoiPhuc.Click += BtnKhoiPhuc_Click;
            cboDaXoa.SelectedValueChanged += CboDaXoa_SelectedValueChanged;
        }

        private void BtnKhoiPhuc_Click(object? sender, EventArgs e)
        {
            var ct = bLL.GetChuongTrinhsByDaXoa(true);

            var program = ct.FirstOrDefault(p => p.MaCT == txtProgramId.Text);

            if (program != null)
            {
                var chuongTrinhDataTable = bLL.GetDataTable();

                foreach (DataRow row in chuongTrinhDataTable.Rows)
                {
                    if (row["MaCT"].ToString() == program.MaCT)
                    {
                        if (row.RowState == DataRowState.Unchanged)
                        {
                            row["NgayBD"] = program.NgayBD;
                            row["NgayKT"] = program.NgayKT;
                            row["GiaTriPhanTram"] = program.GiaTriPhanTram;
                            row["GiaTriHoaDon"] = program.GiaTriHoaDon;
                            row["DieuKienApDung"] = program.DieuKienApDung;
                            row["DaXoa"] = false;
                        }
                    }
                    else
                    {
                        row.AcceptChanges();
                    }
                }

                string result = bLL.Update(chuongTrinhDataTable);

                if (result == Constant.SUCCESS)
                {
                    loadData(dgvProgramVour, bLL.GetAll());
                    btnKhoiPhuc.Enabled = false;
                    cboDaXoa.SelectedIndex = 0;
                    MessageBox.Show("Khôi phục thành công");
                }
                else
                {
                    MessageBox.Show("Khôi phục thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chương trình với mã đã nhập!");
            }
        }

        private void CboDaXoa_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (cboDaXoa.Items.Count > 0 && cboDaXoa.SelectedIndex != -1)
            {
                try
                {
                    bool isDeleted = (bool)cboDaXoa.SelectedValue;
                    if (isDeleted)
                    {
                        btnAdd.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnKhoiPhuc.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnKhoiPhuc.Enabled = false;
                    }
                    loadData(dgvProgramVour, bLL.GetChuongTrinhsByDaXoa(isDeleted));

                }
                catch { }
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            // Kiểm tra các trường đầu vào
            if (string.IsNullOrEmpty(txtProgramId.Text) ||
                string.IsNullOrEmpty(txtDateStart.Text) ||
                string.IsNullOrEmpty(txtDateEnd.Text) ||
                string.IsNullOrEmpty(txtPercentValue.Text) ||
                string.IsNullOrEmpty(txtPercentInvoice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            DateTime? dateStart = ParseDate(txtDateStart.Text);
            DateTime? dateEnd = ParseDate(txtDateEnd.Text);

            if (dateStart == null || dateEnd == null)
            {
                MessageBox.Show("Ngày bắt đầu hoặc kết thúc không hợp lệ.");
                return;
            }

            var ct = bLL.GetAll();

            var program = ct.FirstOrDefault(p => p.MaCT == txtProgramId.Text);

            if (program != null)
            {
                program.NgayBD = dateStart.Value;
                program.NgayKT = dateEnd.Value;
                program.GiaTriPhanTram = byte.Parse(txtPercentValue.Text);
                program.GiaTriHoaDon = decimal.Parse(txtPercentInvoice.Text);
                program.DieuKienApDung = txtConditionApply.Text;

                var chuongTrinhDataTable = bLL.GetDataTable();

                foreach (DataRow row in chuongTrinhDataTable.Rows)
                {
                    if (row["MaCT"].ToString() == program.MaCT)
                    {
                        if (row.RowState == DataRowState.Unchanged)
                        {
                            row["NgayBD"] = program.NgayBD;
                            row["NgayKT"] = program.NgayKT;
                            row["GiaTriPhanTram"] = program.GiaTriPhanTram;
                            row["GiaTriHoaDon"] = program.GiaTriHoaDon;
                            row["DieuKienApDung"] = program.DieuKienApDung;
                        }
                    }
                    else
                    {
                        row.AcceptChanges();
                    }
                }

                string result = bLL.Update(chuongTrinhDataTable);

                if (result == Constant.SUCCESS)
                {
                    loadData(dgvProgramVour, bLL.GetAll());
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chương trình với mã đã nhập!");
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProgramId.Text))
                return;
            string ret = bLL.Delete(txtProgramId.Text);
            if (DTO.Constant.SUCCESS == ret)
            {
                loadData(dgvProgramVour, bLL.GetAll());
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác thất bại!");
                return;
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProgramId.Text) || string.IsNullOrEmpty(txtDateStart.Text) || string.IsNullOrEmpty(txtDateEnd.Text) || string.IsNullOrEmpty(txtPercentValue.Text) || string.IsNullOrEmpty(txtPercentInvoice.Text))
                return;

            string dateStart = txtDateStart.Text;
            string dateEnd = txtDateEnd.Text;

            // Thêm đối tượng chương trình
            EditDTO.ChuongTrinh program = new EditDTO.ChuongTrinh();
            program.MaCT = txtProgramId.Text;
            program.NgayTao = DateTime.Now.Date;
            program.NgayBD = ParseDate(dateStart);
            program.NgayKT = ParseDate(dateEnd);
            program.GiaTriPhanTram = byte.Parse(txtPercentValue.Text);
            program.GiaTriHoaDon = decimal.Parse(txtPercentInvoice.Text);
            program.DieuKienApDung = txtConditionApply.Text;

            string ret = bLL.Create(program);
            if (DTO.Constant.SUCCESS == ret)
                loadData(dgvProgramVour, bLL.GetAll());
            return;
        }

        private void DgvProgramVour_SelectionChanged(object? sender, EventArgs e)
        {
            int idx = dgvProgramVour.Rows.Count;
            if (idx > -1)
            {
                txtProgramId.Text = dgvProgramVour.CurrentRow.Cells[0].Value.ToString();
                txtDateStart.Text = dgvProgramVour.CurrentRow.Cells[1].Value.ToString();
                txtDateEnd.Text = dgvProgramVour.CurrentRow.Cells[2].Value.ToString();
                txtPercentValue.Text = dgvProgramVour.CurrentRow.Cells[3].Value.ToString();
                txtPercentInvoice.Text = dgvProgramVour.CurrentRow.Cells[4].Value.ToString();
                txtConditionApply.Text = dgvProgramVour.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void ViewProgramVoucher_Load(object? sender, EventArgs e)
        {
            loadData(dgvProgramVour, bLL.GetAll());
            cboDaXoa.DataSource = new List<ResponseDTO.DaXoaOption>
            {
                new ResponseDTO.DaXoaOption { Name = "Chưa xóa", IsDeleted = false },
                new ResponseDTO.DaXoaOption { Name = "Đã xóa", IsDeleted = true }
            };
            cboDaXoa.DisplayMember = "Name";
            cboDaXoa.ValueMember = "IsDeleted";
        }

        void loadData(DataGridView dgv, IEnumerable<ResponseDTO.ChuongTrinh> chuongTrinhs)
        {
            dgv.DataSource = migrateDataChuongTrinh(chuongTrinhs);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        IEnumerable<object> migrateDataChuongTrinh(IEnumerable<ResponseDTO.ChuongTrinh> chuongTrinhs)
        {
            var data = chuongTrinhs
                .Select(item => new
                {
                    item.MaCT,
                    NgayBD = item.NgayBD.ToString("dd/MM/yyyy"),
                    NgayKT = item.NgayKT.ToString("dd/MM/yyyy"),
                    item.GiaTriPhanTram,
                    GiaTriHoaDon = item.GiaTriHoaDon.ToString("#,###"),
                    item.DieuKienApDung,
                    NgayTao = item.NgayTao.ToString("dd/MM/yyyy")
                }).ToList();
            return data;
        }
        DateTime ParseDate(string dateStr)
        {
            // Thử các định dạng ngày khác nhau nếu cần
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return parsedDate;
            }
            return DateTime.MinValue;
        }
    }

}
