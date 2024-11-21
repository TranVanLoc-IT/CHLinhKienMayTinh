using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductCartModel
    {
        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

		[DisplayName("Tên sản phẩm")]
		public string TenSanPham { get; set; }

		[DisplayName("Thành tiền")]
        public decimal ThanhTien { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

		[DisplayName("Giá bán")]
		public decimal GiaBan { get; set; }
	}
}
