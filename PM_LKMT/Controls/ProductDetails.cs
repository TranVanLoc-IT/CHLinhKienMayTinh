using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            this.Load += async (s, e) => await LoadData(sp);
        }
      
        private async Task LoadData(ResponseDTO.SanPham sp)
        {

            btnAddToCart.button.Click += async (s, e) => await Button_Click(s, e);

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

        private async Task Button_Click(object? sender, EventArgs e)
        {
            ProductCart cart = new ProductCart();
            cart.MaSP = txtDId.Text;
            cart.TenSP = txtDName.Text;
            cart.SoLuong = 1;
            cart.GiaBan = decimal.Parse(txtDPrice.Text.ToString());

            // Ghi dữ liệu vào file JSON
            await WriteToJsonFile($"../../../data/cart.json", cart);
        }

        public static async Task WriteToJsonFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Format đẹp
            string jsonString = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, jsonString);
        }
    }
}
