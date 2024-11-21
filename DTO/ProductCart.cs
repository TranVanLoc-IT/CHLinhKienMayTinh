using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductCart
    {
		[DisplayName("Mã sản phẩm")]
		public string MaSP { get; set; }

		[DisplayName("Tên sản phẩm")]
		public string TenSP { get; set; }

		[DisplayName("Số lượng")]
		public int SoLuong { get; set; }

		[DisplayName("Giá bán")]
		public decimal GiaBan { get; set; }
    }
}
