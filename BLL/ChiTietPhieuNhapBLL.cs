using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        private CTPhieuNhapDAL _dal;
        public ChiTietPhieuNhapBLL()
        {
            _dal = new CTPhieuNhapDAL();
        }
        public IEnumerable<ResponseDTO.ChiTietPhieuNhap> GetAll(string idPN)
        {

            return _dal.GetAll(idPN);
        }
    }
}
