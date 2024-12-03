using BLL;
using DTO;
using PM_LKMT.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.SubForm
{
    public partial class ViewProduct : Form
    {
        private SanPhamBLL _bll;
        private ThuongHieuBLL _thuonghieu;
        private LoaiSanPhamBLL _lsp;
        private IEnumerable<ResponseDTO.SanPham> data;
        public ViewProduct()
        {
            this._bll = new SanPhamBLL();
            this._thuonghieu = new ThuongHieuBLL();
            this._lsp = new LoaiSanPhamBLL();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            IEnumerable<ResponseDTO.SanPham> hotSale = _bll.HotSale().Distinct();
            IEnumerable<string> hotBrand = _bll.HotBrand().Distinct();
            data = _bll.GetAll().Distinct();
            searchBox.KeyDown += searchBox_enter;

            // xem full màn hình
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            this.panelBanChay.Width = screenWidth;
            this.panelThuongHieuHot.Width = screenWidth;
            this.panelAll.Width = screenWidth;
            // load datasource
            foreach (ResponseDTO.SanPham sp in hotSale)
            {
                ProductViewCard card = new ProductViewCard(sp);
                this.panelBanChay.Controls.Add(card);
            }
            foreach (string br in hotBrand)
            {
                PictureBox card = LoadImage(br);

                this.panelThuongHieuHot.Controls.Add(card);
            }
            foreach (ResponseDTO.SanPham sp in data)
            {
                ProductViewCard card = new ProductViewCard(sp);
                this.panelAll.Controls.Add(card);
            }

        }
        private PictureBox LoadImage(string name)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(189, 189);
            pic.BackgroundImageLayout = ImageLayout.None;
            string filePath = $"../../../images/Product/{name}.jpg";

            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    pic.Image = Image.FromStream(stream);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
            return pic;
        }

        private void searchBox_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.panelAll.Controls.Clear();
                foreach (Control control in panelAll.Controls)
                {
                    if (control is ProductViewCard card)
                    {
                        if (card.productName.Text.ToLower().StartsWith(searchBox.Text.ToLower()) || card.productName.Text.ToLower().Contains(searchBox.Text.ToLower()))
                        {
                            this.panelAll.Controls.Add(card);
                            return;
                        }
                    }
                }
                MessageBox.Show("Không thấy kết quả phù hợp !?", "Thông báo", MessageBoxButtons.OKCancel);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = _bll.GetAll().Distinct();
            this.panelAll.Controls.Clear();
            foreach (ResponseDTO.SanPham sp in data)
            {
                ProductViewCard card = new ProductViewCard(sp);
                this.panelAll.Controls.Add(card);
            }
        }

        private void cbBrandFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panelAll.Controls.Clear();
            foreach (ResponseDTO.SanPham sp in data.Where(r => r.TenThuongHieu.Equals(this.cbBrandFilter.SelectedValue)))
            {
                ProductViewCard card = new ProductViewCard(sp);
                this.panelAll.Controls.Add(card);
            }
        }

        private void cbProductTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.panelAll.Controls.Clear();
            foreach (ResponseDTO.SanPham sp in data.Where(r => r.TenLoaiSP.Equals(this.cbProductTypeFilter.SelectedValue)))
            {
                ProductViewCard card = new ProductViewCard(sp);
                this.panelAll.Controls.Add(card);
            }
        }

        private void cbProductTypeFilter_Click(object sender, EventArgs e)
        {
            this.cbProductTypeFilter.DataSource = _lsp.GetAll().ToList();
            this.cbProductTypeFilter.DisplayMember = "TenLoai";
            this.cbProductTypeFilter.ValueMember = "TenLoai";
        }

        private void cbBrandFilter_Click(object sender, EventArgs e)
        {
            this.cbBrandFilter.DataSource = _thuonghieu.GetAll().ToList();
            this.cbBrandFilter.DisplayMember = "TenThuongHieu";
            this.cbBrandFilter.ValueMember = "TenThuongHieu";
        }
    }
}
