using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class DonHangDAL
    {
        private DONHANGTableAdapter _db;
        private NHANVIENTableAdapter _nv;
        private KHACHHANGTableAdapter _kh;
        public DonHangDAL()
        {
            _db = new DONHANGTableAdapter();
            _nv = new NHANVIENTableAdapter();
            _kh = new KHACHHANGTableAdapter();
        }
        public void Update(DONHANGDataTable dh)
        {
            _db.Update(dh);
        }
        public void Create(EditDTO.DonHang dh, EditDTO.ChiTietDonHang[] dhs)
        {
            _db.Insert(dh.MaDonHang, dh.NhanVienTao, dh.MaKH, dh.NgayTao, dh.TinhTrang, dh.GhiChu, dh.TongSL, dh.ThanhTien, dh.DaXoa);
            
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaDonHang(id);
        }
        public IEnumerable<ResponseDTO.DonHang> GetAll()
        {
            return _db.GetData().Where(r => !r.DaXoa).Select(r => new ResponseDTO.DonHang()
            {
                MaDonHang = r.MaDonHang,
                NgayTao = r.NgayTao,
                TenNhanVien = _nv.GetData().Where(k => k.MaNV == r.NhanVienTao).Select(k => k.HoTen).First(),
                ThanhTien = r.ThanhTien,
                TenKH = _kh.GetData().Where(k => k.MaKH ==  r.MaKH).Select( k => k.HoTen).First(),
                TinhTrang = r.TinhTrang,
                TongSL = r.TongSL,
                GhiChu = r.GhiChu
            });
        }
       
    }
}
