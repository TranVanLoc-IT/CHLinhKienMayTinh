using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDonHangBLL
    {
        private CTDonHangDAL _dal;
        public ChiTietDonHangBLL()
        {
            _dal = new CTDonHangDAL();
        }
        public IEnumerable<ResponseDTO.ChiTietDonHang> GetAll(string idDH)
        {

            return _dal.GetAll(idDH);
        }
        public void CreateRange(string madh, List<ProductCartModel> cart)
        {

            _dal.CreateRange(madh, cart);
        }
    }
}
