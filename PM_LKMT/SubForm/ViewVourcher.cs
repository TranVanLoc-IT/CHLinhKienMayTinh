using BLL;
using DAL;
using DTO;
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
    public partial class ViewVourcher : Form
    {
        public static string MaCT;
        public static int SoLuong;
        static int count = 0;
        KhuyenMaiBLL bll;
        public ViewVourcher()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            dvgVourcher.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dvgVourcher.RowTemplate.Height = 50;
            dvgVourcher.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            bll = new KhuyenMaiBLL();
            this.Load += ViewVourcher_Load;
            dvgVourcher.SelectionChanged += DvgVourcher_SelectionChanged;
            cboDaDung.SelectedValueChanged += CboDaDung_SelectedValueChanged;
            btnDelete.Click += BtnDelete_Click;
            btnAdd.Click += BtnAdd_Click;
            btnBack.Click += BtnBack_Click;
            txtHoaDon.Enabled = false;
        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (count <= SoLuong)
            {
                btnAdd.Enabled = true;
                if (string.IsNullOrEmpty(txtMaCT.Text) || string.IsNullOrEmpty(txtMaKM.Text))
                    return;

                // Thêm đối tượng chương trình
                EditDTO.KhuyenMai vour = new EditDTO.KhuyenMai();
                vour.MaCT = txtMaCT.Text;
                vour.MaKhuyenMai = txtMaKM.Text;
                vour.MaHD = null;
                vour.DaDung = false;

                string ret = bll.Create(vour);
                if (DTO.Constant.SUCCESS == ret)
                {
                    MessageBox.Show("Thao tác thành công");
                    loadData(dvgVourcher, bll.GetKhuyenMaisByDaDung(MaCT, false));
                    count++;
                    return;
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại!");
                    return;
                }
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void DvgVourcher_SelectionChanged(object? sender, EventArgs e)
        {
            int idx = dvgVourcher.Rows.Count;
            if (idx > -1)
            {
                txtMaKM.Text = dvgVourcher.CurrentRow.Cells[0].Value.ToString();
                txtMaCT.Text = dvgVourcher.CurrentRow.Cells[1].Value.ToString();
                if (dvgVourcher.CurrentRow.Cells[2].Value != null)
                {
                    txtHoaDon.Text = dvgVourcher.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    txtHoaDon.Text = "";
                }
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKM.Text))
                return;
            string ret = bll.Delete(txtMaKM.Text);
            if (DTO.Constant.SUCCESS == ret)
            {
                loadData(dvgVourcher, bll.GetKhuyenMaisByDaDung(MaCT, false));
                count--;
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác thất bại!");
                return;
            }
        }

        private void CboDaDung_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (cboDaDung.Items.Count > 0 && cboDaDung.SelectedIndex != -1)
            {
                try
                {
                    bool isUsed = (bool)cboDaDung.SelectedValue;
                    if (isUsed)
                    {
                        btnAdd.Enabled = false;
                        btnDelete.Enabled = false;
                        loadData(dvgVourcher, bll.GetKhuyenMaisByDaDung(MaCT, true));
                    }
                    else
                    {
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        loadData(dvgVourcher, bll.GetKhuyenMaisByDaDung(MaCT, false));
                    }
                }
                catch { }
            }
        }

        private void ViewVourcher_Load(object? sender, EventArgs e)
        {
            loadData(dvgVourcher, bll.GetKhuyenMaisByDaDung(MaCT, false));
            cboDaDung.DataSource = new List<ResponseDTO.DaDungOption>
            {
                new ResponseDTO.DaDungOption{Name = "Chưa dùng", IsUsed = false},
                new ResponseDTO.DaDungOption{Name = "Đã dùng", IsUsed = true}
            };
            cboDaDung.DisplayMember = "Name";
            cboDaDung.ValueMember = "IsUsed";
        }
        void loadData(DataGridView dgv, IEnumerable<ResponseDTO.KhuyenMai> khuyenMais)
        {
            txtMaCT.Text = MaCT;
            count = bll.GetQuantityByProgramId(MaCT);

            dgv.DataSource = migrateDataKhuyenMai(khuyenMais);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        IEnumerable<object> migrateDataKhuyenMai(IEnumerable<ResponseDTO.KhuyenMai> khuyenMais)
        {
            var data = khuyenMais
                .Select(item => new
                {
                    item.MaKhuyenMai,
                    item.MaCT,
                    item.MaHD,
                }).ToList();
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaKM.Text = IDAutoGeneratorBLL.Generate("KM", 3);
        }
    }
}
