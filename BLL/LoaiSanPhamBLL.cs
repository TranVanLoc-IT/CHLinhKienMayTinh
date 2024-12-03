using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        private LoaiSanPhamDAL _dal;

        public LoaiSanPhamBLL()
        {
            _dal = new LoaiSanPhamDAL();
        }

        public IEnumerable<ResponseDTO.LoaiSanPham> GetAll()
        {
            return _dal.GetAll();
        }
    }
}
