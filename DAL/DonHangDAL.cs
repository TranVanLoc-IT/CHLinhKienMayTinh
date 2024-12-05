using DAL.LKMTTableAdapters;
using DTO;
using static DAL.LKMT;

namespace DAL
{
    public class DonHangDAL
    {
        private DONHANGTableAdapter _db;
        private CHITIETDONHANGTableAdapter _ctdh;
        private SANPHAMTableAdapter _sp;
        private NHANVIENTableAdapter _nv;
        private KHACHHANGTableAdapter _kh;
        public DonHangDAL()
        {
            _db = new DONHANGTableAdapter();
            _nv = new NHANVIENTableAdapter();
            _kh = new KHACHHANGTableAdapter();
            _sp = new SANPHAMTableAdapter();
            _ctdh = new CHITIETDONHANGTableAdapter();
        }
        public void Update(DONHANGDataTable dh)
        {
            _db.Update(dh);
        }
        public void UpdateStatus(string madh)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.UpdateOrderStatus(madh);
        }
        public void Create(EditDTO.DonHang dh)
        {
            _db.Insert(dh.MaDonHang, dh.NhanVienTao, dh.MaKH, dh.NgayTao, DateTime.Now, dh.TinhTrang, dh.GhiChu, dh.ThanhTien, dh.TienGiam, dh.DaXoa);
            
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaDonHang(id);
        }
        public IEnumerable<ResponseDTO.DonHang> GetAllToday()
        {
            return _db.GetData().Where(r => !r.DaXoa && r.NgayTao.Date == DateTime.Now.Date).Select(r => new ResponseDTO.DonHang()
            {
                MaDonHang = r.MaDonHang,
                NgayTao = r.NgayTao,
                TenNhanVien = _nv.GetData().Where(k => k.MaNV == r.NhanVienTao).Select(k => k.HoTen).First(),
                ThanhTien = r.ThanhTien,
                TenKH = _kh.GetData().Where(k => k.MaKH == r.MaKH).Select(k => k.HoTen).First(),
                TinhTrang = r.TinhTrang,
                GhiChu = r.GhiChu,
                GiamGia = r.TienGiam
            });
        }
        public IEnumerable<ResponseDTO.ChiTietDHResult> GetAllCTDHResult(string madh)
        {

            return _ctdh.GetData().Where(r => r.MaDonHang == madh).Select(r => new ResponseDTO.ChiTietDHResult()
            {
                TenSanPham = _sp.GetData().Where(o => o.MaSanPham == r.MaSanPham).Select(r => r.TenSanPham).First(),
                SoLuong = r.SoLuong,
                ThanhTien = r.ThanhTien
            });
        }
        public IEnumerable<ResponseDTO.DonHang> GetAllUnconfirmed()
        {
            var all = GetAllToday().Where(r => r.TinhTrang.Equals("Chưa thanh toán"));
            return all;
        }
    }
}
