using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTPhieuNhapDAL
    {
        private CHITIETPHIEUNHAPTableAdapter _db;
        private SanPhamDAL _spDAL;
        public CTPhieuNhapDAL()
        {
            _db = new CHITIETPHIEUNHAPTableAdapter();
            _spDAL = new SanPhamDAL();
        }
        public IEnumerable<ResponseDTO.ChiTietPhieuNhap> GetAll(string idPN)
        {
            return (IEnumerable<ResponseDTO.ChiTietPhieuNhap>)_db.GetData().Where(r => r.MaPN == idPN);
        }
        public void Create(EditDTO.ChiTietPhieuNhap[] dhs)
        {
            foreach (var dh in dhs)
            {
                _db.Insert(dh.MaPN, dh.MaSanPham, dh.GiaNhap, dh.SoLuong, dh.ThanhTien);
                _spDAL.UpdateQuantity(dh.MaSanPham, dh.SoLuong);
            }
        }
    }
}
