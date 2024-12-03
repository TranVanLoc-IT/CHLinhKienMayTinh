using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        private LOAISANPHAMTableAdapter _adapter;
        public LoaiSanPhamDAL()
        {
            _adapter = new LOAISANPHAMTableAdapter();
        }
        public IEnumerable<ResponseDTO.LoaiSanPham> GetAll()
        {
            return _adapter.GetData().Select(r => new ResponseDTO.LoaiSanPham()
            {
                MaLoaiSP = r.MaLoaiSP,
                TenLoai = r.TenLoai
            });
        }
    }
}
