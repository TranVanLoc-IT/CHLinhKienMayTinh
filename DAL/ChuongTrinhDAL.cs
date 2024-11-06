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
    public class ChuongTrinhDAL
    {
        private CHUONGTRINHTableAdapter _db;
        public ChuongTrinhDAL()
        {
            _db = new CHUONGTRINHTableAdapter();
        }
        public void Update(CHUONGTRINHDataTable ct)
        {
            _db.Update(ct);
        }
        public void Create(EditDTO.ChuongTrinh ct)
        {
            _db.Insert(ct.MaCT, ct.NgayBD, ct.NgayKT, ct.GiaTriPhanTram, ct.GiaTriHoaDon, ct.DieuKienApDung, ct.NgayTao, ct.DaXoa);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaChuongTrinh(id);
        }
        public IEnumerable<ResponseDTO.ChuongTrinh> GetAll()
        {
            return (IEnumerable<ResponseDTO.ChuongTrinh>)_db.GetData();
        }
    }
}
