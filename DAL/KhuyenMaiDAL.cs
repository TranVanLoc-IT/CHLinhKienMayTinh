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
    public class KhuyenMaiDAL
    {
        private KHUYENMAITableAdapter _km;
        public KhuyenMaiDAL()
        {
            _km = new KHUYENMAITableAdapter();
        }
        // Phương thức trả về KHUYENMAIDataTable hiện tại
        public KHUYENMAIDataTable GetData()
        {
            return _km.GetData();  // Giả sử phương thức này đã có trong TableAdapter
        }

        public void Update(KHUYENMAIDataTable km)
        {
            _km.Update(km);  // Cập nhật DataTable vào cơ sở dữ liệu
        }

        public void Create(EditDTO.KhuyenMai km)
        {
            _km.Insert(km.MaKhuyenMai, km.MaHD, km.MaCT, km.DaDung);
        }

        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaKhuyenMai(id);
        }
        public IEnumerable<ResponseDTO.KhuyenMai> GetKhuyenMaisByDaDung(string maCT, bool daDung)
        {
            return _km.GetData().Where(row => row.MaCT == maCT && row.DaDung == daDung).Select(row => new ResponseDTO.KhuyenMai
            {
                MaCT = row.MaCT,
                MaHD = row.MaDH,
                MaKhuyenMai = row.MaKhuyenMai,
                DaDung = row.DaDung
            }).ToList();
        }
        public int GetQuantityByProgramId(string maCT)
        {
            return _km.GetData().Where(row => row.MaCT == maCT).Count();
        }
    }
}
