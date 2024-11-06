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
    public class HoaDonDAL
    {
        private HOADONTableAdapter _db;
        public HoaDonDAL()
        {
            _db = new HOADONTableAdapter();
        }
        public void Update(HOADONDataTable hd)
        {
            _db.Update(hd);
        }
        public void Create(EditDTO.HoaDon hd)
        {
            _db.Insert(hd.MaHoaDon, hd.MaDonHang, hd.NhanVienTao, hd.NgayLap, hd.TongTien, hd.DaXoa);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaHoaDon(id);
        }
        public IEnumerable<ResponseDTO.HoaDon> GetAll()
        {
            return (IEnumerable<ResponseDTO.HoaDon>)_db.GetData();
        }
        public ResponseDTO.HoaDon GetById(string id)
        {
            return (ResponseDTO.HoaDon)_db.GetData().Where(r => r.MaHoaDon == id);
        }
    }
}
