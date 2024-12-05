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
    public class KhachHangDAL
    {
        private KHACHHANGTableAdapter _db;
        public KhachHangDAL()
        {
            _db = new KHACHHANGTableAdapter();
        }
        public void Update(KHACHHANGDataTable kh)
        {
            _db.Update(kh);
        }
        public void Create(EditDTO.KhachHang kh)
        {
            _db.Insert(kh.MaKH, kh.SDT, kh.HoTen, kh.NgayThamGia, kh.DaXoa, kh.ChinhSuaGanNhat, kh.NguoiChinhSuaGanNhat);

        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaKhachHang(id);
        }
        public IEnumerable<ResponseDTO.KhachHang> GetAll()
        {
            return _db.GetData().Select(r => new ResponseDTO.KhachHang()
            {
                MaKH = r.MaKH,
                HoTen = r.HoTen,
                SDT = r.SDT,
                NgayThamGia = r.NgayThamGia
            });
        }
        public ResponseDTO.KhachHang GetById(string id)
        {
            return (ResponseDTO.KhachHang)_db.GetData().Where(r => r.MaKH == id);
        }
        public string CheckCustomer(string phone)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();

            string id = query.KiemTraKH(phone).ToString();
            return id;
        }
    }
}
