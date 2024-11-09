using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.Controls
{
    public partial class ProductDetails : UserControl
    {
        private ResponseDTO.SanPham _sp;
        public ProductDetails(ResponseDTO.SanPham sp)
        {
            InitializeComponent();
            _sp = sp;
            LoadData(sp);
        }
        private void LoadData(ResponseDTO.SanPham sp)
        {
            txtDId.Text = sp.MaSanPham;
            txtDName.Text = sp.TenSanPham;
            txtDBrand.Text = sp.TenThuongHieu;
            txtDPrice.Text = sp.DonGia.ToString() + "VND";
            txtDQuantityLeft.Text = sp.SoLuongTon.ToString();

            string filePath = $"../../../images/Product/{sp.MaSanPham}.jpg";

            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    productImg.Image = Image.FromStream(stream);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }
    }
}
