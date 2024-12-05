using DAL;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL _dal;
        public KhachHangBLL()
        {
            _dal = new KhachHangDAL();
        }
        public string Update(KHACHHANGDataTable kh)
        {
            if (kh == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(kh);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.KhachHang kh)
        {

            if (kh == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(kh);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Delete(string id)
        {
            try
            {
                _dal.Delete(id);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public IEnumerable<ResponseDTO.KhachHang> GetAll()
        {

            return _dal.GetAll();
        }
        public ResponseDTO.KhachHang GetByIdOrByName(string id)
        {

            return _dal.GetByIdOrByName(id);
        }

        public string CheckCustomer(string phone)
        {

            return _dal.CheckCustomer(phone);
        }
    }
}
