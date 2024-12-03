using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
