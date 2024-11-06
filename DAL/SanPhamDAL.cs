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
        private CTDonHangDAL _ctdhDAL;
        public SanPhamDAL()
        {
            _db = new SANPHAMTableAdapter();
            _ctdhDAL = new CTDonHangDAL();
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
        public void Create(EditDTO.SanPham sp, EditDTO.ChiTietDonHang[] dhs)
        {
            _db.Insert(sp.MaSanPham, sp.MaLoaiSP, sp.MaThuongHieu, sp.TenSanPham, sp.DonGia, sp.TGBaoHanh, sp.Hinh, sp.MoTa, sp.SoLuongTon, sp.SoLuongDaBan, sp.NgayTao, sp.DaXoa, sp.CapNhatGanNhat, sp.NguoiChinhSuaGanNhat);
            _ctdhDAL.Create(dhs);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaSanPham(id);
        }
        public IEnumerable<ResponseDTO.SanPham> GetAll()
        {
            return (IEnumerable<ResponseDTO.SanPham>)_db.GetData();
        }
        public ResponseDTO.SanPham GetById(string id)
        {
            return (ResponseDTO.SanPham)_db.GetData().Where(r => r.MaSanPham == id);
        }
    }
}
