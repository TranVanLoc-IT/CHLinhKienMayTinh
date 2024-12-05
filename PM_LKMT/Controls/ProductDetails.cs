using DTO;
using System.Data;
using System.Text.Json;

namespace PM_LKMT.Controls
{
    public partial class ProductDetails : UserControl
    {
        private ResponseDTO.SanPham _sp;
        private List<ProductCartModel> carts =  new List<ProductCartModel>();
        public ProductDetails(ResponseDTO.SanPham sp)
        {
            InitializeComponent();
            _sp = sp;
            this.Load += async (s, e) => await LoadData(sp);
        }
      
        private async Task LoadData(ResponseDTO.SanPham sp)
        {
            this.Name = sp.MaSanPham;
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
            try
            {
                int slcon = int.Parse(txtDQuantityLeft.Text);
                int slmua = 1;
                ++slmua;
                if(slmua > slcon)
                {
					MessageBox.Show("Vượt quá số lượng hàng hiện có!", "Thông báo");
                    return;
				}
				ProductCartModel cart = new ProductCartModel();
				cart.MaSanPham = txtDId.Text;
				cart.TenSanPham = txtDName.Text;
				cart.SoLuong = slmua;
				cart.GiaBan = decimal.Parse(txtDPrice.Text.ToString().Substring(0, txtDPrice.Text.ToString().Length - 4));
				cart.ThanhTien = cart.SoLuong * cart.GiaBan;
                carts = await ReadFromJsonFile($"../../../data/cart.json");
				ProductCartModel prEx = carts.Where(r => r.MaSanPham == cart.MaSanPham).FirstOrDefault()!;
				
                if (prEx == null)
				{
                    // kiem tra cap nhat sl moi
					carts.Add(cart);
				}
				else
				{
					carts.Remove(prEx);
                    ++prEx.SoLuong;
                    prEx.ThanhTien = prEx.SoLuong * cart.GiaBan;
					carts.Add(prEx);
				}
				// Ghi dữ liệu vào file JSON
				await WriteToJsonFile($"../../../data/cart.json", carts);
                MessageBox.Show("Thêm thành công!", "Thông báo");
			}
			catch(Exception ex)
            {
				MessageBox.Show("Có lỗi xảy ra !", "Thông báo");
			}

		}

        public static async Task WriteToJsonFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // Format đẹp
            string jsonString = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync(filePath, jsonString);
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

	}
}
