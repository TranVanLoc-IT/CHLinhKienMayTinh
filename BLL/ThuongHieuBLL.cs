using DAL;
using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
