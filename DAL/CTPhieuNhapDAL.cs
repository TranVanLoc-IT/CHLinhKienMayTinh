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
        public QueriesTableAdapter _query;
        public CTPhieuNhapDAL()
        {
            _db = new CHITIETPHIEUNHAPTableAdapter();
            _query = new QueriesTableAdapter();
        }
        public List<ResponseDTO.ChiTietPhieuNhap> GetAll(string idPN)
        {
            return _db.GetData().Where(r => r.MaPN == idPN).Select(p => new ResponseDTO.ChiTietPhieuNhap { MaSP = p.MaSanPham, MaThuongHieu = p.MaThuongHieu, GiaNhap = p.GiaNhap, SoLuong = p.SoLuong, ThanhTien = p.ThanhTien}).ToList<ResponseDTO.ChiTietPhieuNhap>();
        }
        public void Create(List<EditDTO.ChiTietPhieuNhap> dhs)
        {
            foreach (var dh in dhs)
            {
                _db.Insert(dh.MaPN, dh.MaSanPham, dh.MaThuongHieu,dh.GiaNhap, dh.SoLuong, dh.ThanhTien);
                _query.CapNhatSLTonSPKhiNhap(dh.SoLuong, dh.MaSanPham);
            }
        }
    }
}
