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
        public DonHangDAL()
        {
            _db = new DONHANGTableAdapter();
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
                NhanVienTao = r.NhanVienTao,
                ThanhTien = r.ThanhTien,
                MaKH = r.MaKH,
                TinhTrang = r.TinhTrang,
                TongSL = r.TongSL,
                GhiChu = r.GhiChu
            });
        }
       
    }
}
