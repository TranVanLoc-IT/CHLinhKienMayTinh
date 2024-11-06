using DAL;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL _dal;
        public HoaDonBLL()
        {
            _dal = new HoaDonDAL();
        }
        public string Update(HOADONDataTable hd)
        {
            if (hd == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(hd);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.HoaDon hd)
        {

            if (hd == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(hd);
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
        public IEnumerable<ResponseDTO.HoaDon> GetAll()
        {

            return _dal.GetAll();
        }
        public ResponseDTO.HoaDon GetById(string id)
        {
            return _dal.GetById(id);
        }
    }
}
