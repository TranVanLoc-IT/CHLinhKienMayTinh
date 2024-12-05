using DAL;
using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuongHieuBLL
    {
        private ThuongHieuDAL _dal;

        public ThuongHieuBLL()
        {
            _dal = new ThuongHieuDAL();
        }

        public IEnumerable<ResponseDTO.ThuongHieu> GetAll()
        {
            return _dal.GetAll();
        }

        public DataTable GetData()
        {
            return _dal.GetData();
        }

        public int? Them(EditDTO.ThuongHieu thuong)
        {
            return _dal.Them(thuong);
        }

        public int? Xoa(EditDTO.ThuongHieu thuong)
        {
            return _dal.Xoa(thuong);
        }
    }
}
