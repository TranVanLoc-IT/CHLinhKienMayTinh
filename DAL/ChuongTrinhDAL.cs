using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class ChuongTrinhDAL
    {
        private CHUONGTRINHTableAdapter _db;
        private KHUYENMAITableAdapter _km;
        private ConvertMoneyUnitDAL _convert;

        public ChuongTrinhDAL()
        {
            _db = new CHUONGTRINHTableAdapter();
            _km = new KHUYENMAITableAdapter();
            _convert = new ConvertMoneyUnitDAL();
        }

        // Phương thức trả về CHUONGTRINHDataTable hiện tại
        public CHUONGTRINHDataTable GetData()
        {
            return _db.GetData();  // Giả sử phương thức này đã có trong TableAdapter
        }

        public void Update(CHUONGTRINHDataTable ct)
        {
            _db.Update(ct);  // Cập nhật DataTable vào cơ sở dữ liệu
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

        public IEnumerable<ResponseDTO.ChuongTrinh> GetAllActivating()
        {
            DateTime today = DateTime.Now;
            var allKm = _km.GetData().Where(r => !r.DaDung).Select(r => r.MaCT).Distinct();
            return _db.GetData().Where(row => !row.DaXoa && today >= row.NgayBD && today <= row.NgayKT && allKm.Contains(row.MaCT)).Select(row => new ResponseDTO.ChuongTrinh
            {
                MaCT = row.MaCT,
                NgayBD = row.NgayBD.Date,
                NgayKT = row.NgayKT.Date,
                NgayTao = row.NgayTao.Date,
                GiaTriPhanTram = row.GiaTriPhanTram,
                GiaTriHoaDon = row.GiaTriHoaDon,
                DieuKienApDung = row.DieuKienApDung
            }).ToList();
        }

        public IEnumerable<ResponseDTO.ChuongTrinh> GetAll()
        {

            return _db.GetData().Where(row => !row.DaXoa).Select(row => new ResponseDTO.ChuongTrinh
            {
                MaCT = row.MaCT,
                NgayBD = row.NgayBD.Date,
                NgayKT = row.NgayKT.Date,
                NgayTao = row.NgayTao.Date,
                GiaTriPhanTram = row.GiaTriPhanTram,
                GiaTriHoaDon = row.GiaTriHoaDon,
                DieuKienApDung = row.DieuKienApDung
            }).ToList();
        }

        public string GetNameApplied(string madh)
        {
            string mact = _km.GetData().Where(r => r.MaDH == madh).Select(r => r.MaCT).First();
            return GetAll().Where(r => r.MaCT == mact).Select(r => $"{r.DieuKienApDung} - Giảm {r.GiaTriPhanTram} cho hóa đơn {_convert.ConvertToVND(r.GiaTriHoaDon)} trở lên").First();
        }
        public IEnumerable<ResponseDTO.ChuongTrinh> GetChuongTrinhsByDaXoa(bool daXoa)
        {
            return (IEnumerable<ResponseDTO.ChuongTrinh>)_db.GetData().Where(row => row.DaXoa == daXoa).Select(row => new ResponseDTO.ChuongTrinh
            {
                MaCT = row.MaCT,
                NgayBD = row.NgayBD.Date,
                NgayKT = row.NgayKT.Date,
                NgayTao = row.NgayTao.Date,
                GiaTriPhanTram = row.GiaTriPhanTram,
                GiaTriHoaDon = row.GiaTriHoaDon,
                DieuKienApDung = row.DieuKienApDung,
            }).ToList();
        }
        public bool CheckEmptyKMCard(string MaCT)
        {
            if (_km.GetData().Where(r => r.MaCT == MaCT && !r.DaDung).Count() > 0)
            {
                return true;
            }
            return false;
        }
        public void UseEmptyKMCard(string MaCT, string madh)
        {
            string makmEmpty = _km.GetData().Where(r => r.MaCT == MaCT && !r.DaDung).First().MaKhuyenMai;
            QueriesTableAdapter adapter = new QueriesTableAdapter();
            adapter.updatekm(madh, makmEmpty);
        }
    }
}
