using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class SanPhamDAL
    {
        private SANPHAMTableAdapter _db;
        private LKMT _context;
        public SanPhamDAL()
        {
            _db = new SANPHAMTableAdapter();
            _context = new LKMT();
        }
        public void Update(SANPHAMDataTable sp)
        {
            _db.Update(sp);
        }
        public void UpdateQuantity(string id, int slmua)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.CapNhatSLSP(slmua, id);
        }
        public void Create(EditDTO.SanPham sp)
        {
            _db.Insert(sp.MaSanPham, sp.MaLoaiSP, sp.MaThuongHieu, sp.TenSanPham, sp.DonGia, sp.TGBaoHanh, sp.Hinh, sp.MoTa, sp.SoLuongTon, sp.SoLuongDaBan, sp.NgayTao, sp.DaXoa, sp.CapNhatGanNhat, sp.NguoiChinhSuaGanNhat);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaSanPham(id);
        }
        public IEnumerable<ResponseDTO.SanPham> GetAll()
        {
            return _db.GetData().Where(r => !r.DaXoa).Select(r => new ResponseDTO.SanPham()
            {
                MaSanPham = r.MaSanPham,
                TenLoaiSP = _context.LOAISANPHAM.Where(e => e.MaLoaiSP == r.MaLoaiSP).Select(r => r.TenLoai).FirstOrDefault() ?? "Không có",
                TenThuongHieu = _context.THUONGHIEU.Where(e => e.MaThuongHieu == r.MaThuongHieu).Select(r => r.TenThuongHieu).FirstOrDefault() ?? "Không có",
                MoTa = r.MoTa,
                TenSanPham = r.TenSanPham,
                DonGia = r.DonGia,
                SoLuongTon = r.SoLuongTon,
                SoLuongDaBan = r.SoLuongDaBan
            });
        }
    }
}
