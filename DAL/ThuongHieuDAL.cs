using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuongHieuDAL
    {
        private THUONGHIEUTableAdapter adapter;

        public ThuongHieuDAL()
        {
            adapter = new THUONGHIEUTableAdapter();
        }

        public IEnumerable<ResponseDTO.ThuongHieu> GetAll()
        {
            return adapter.GetData().Select(r => new ResponseDTO.ThuongHieu()
            {
                MaThuongHieu = r.MaThuongHieu,
                TenThuongHieu = r.TenThuongHieu
            });
        }

        public DataTable GetData()
        {
            return adapter.GetData();
        }

        public int? Them(EditDTO.ThuongHieu thuongHieu)
        {
            return adapter.Insert(thuongHieu.MaThuongHieu, thuongHieu.TenThuongHieu, thuongHieu.NgayTao, thuongHieu.DaXoa);
        }

        public int? Xoa(EditDTO.ThuongHieu thuongHieu)
        {
            return adapter.Delete(thuongHieu.MaThuongHieu, thuongHieu.TenThuongHieu, thuongHieu.NgayTao, thuongHieu.DaXoa);
        }
    }
}
