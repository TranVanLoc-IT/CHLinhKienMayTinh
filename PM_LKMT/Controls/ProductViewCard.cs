using DTO;
using PM_LKMT.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PM_LKMT.Controls
{
    public partial class ProductViewCard : UserControl
    {
        private ResponseDTO.SanPham _sp;
        public ViewDetails view;
        public ProductViewCard(ResponseDTO.SanPham sp)
        {
            InitializeComponent();
            _sp = sp;
            LoadData(sp);
        }
        private void LoadData(ResponseDTO.SanPham sp)
        {
            productName.Text = sp.TenSanPham;
            brand.Text = sp.TenThuongHieu;
            price.Text = sp.DonGia.ToString() + "VND";

            string filePath = $"../../../images/Product/{sp.MaSanPham}.jpg";

            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    imgBox.Image = Image.FromStream(stream);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            ProductDetails detail = new ProductDetails(_sp);
            view.Size = new Size(605, 312);
            view = new ViewDetails(detail);
            
            view.ShowDialog();
        }
    }
}
