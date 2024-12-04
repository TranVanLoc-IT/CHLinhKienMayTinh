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
    public class PhieuNhapDAL
    {
        private PHIEUNHAPTableAdapter _db;
        private CTPhieuNhapDAL _ctpnDAL;
        public PhieuNhapDAL()
        {
            _db = new PHIEUNHAPTableAdapter();
            _ctpnDAL = new CTPhieuNhapDAL();
        }
        public void Update(PHIEUNHAPDataTable pn)
        {
            _db.Update(pn);
        }
        public void Create(EditDTO.PhieuNhap pn, EditDTO.ChiTietPhieuNhap[] pns)
        {
            _db.Insert(pn.MaPN, pn.TangTien, pn.NgayNhap, pn.DaXoa);
            _ctpnDAL.Create(pns);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaPhieuNhap(id);
        }
        public IEnumerable<ResponseDTO.PhieuNhap> GetAll()
        {
            return (IEnumerable<ResponseDTO.PhieuNhap>)_db.GetData();
        }
        public ResponseDTO.PhieuNhap GetById(string id)
        {
            return (ResponseDTO.PhieuNhap)_db.GetData().Where(r => r.MaPN == id);
        }
    }
}
