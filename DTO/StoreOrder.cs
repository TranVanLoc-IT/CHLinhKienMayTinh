using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class StoreOrder
	{

		public EditDTO.DonHang DonHang { get; set; }
		public List<EditDTO.ChiTietDonHang> Sps { get; set; }
		public string TenKH { get; set; }

	}
}
