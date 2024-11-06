using DAL;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace BLL
{
    public class PhieuNhapBLL
    {
        private PhieuNhapDAL _dal;
        public PhieuNhapBLL()
        {
            _dal = new PhieuNhapDAL();
        }
        public string Update(PHIEUNHAPDataTable pn)
        {
            if (pn == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(pn);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.PhieuNhap pn)
        {

            if (pn == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(pn);
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
        public IEnumerable<ResponseDTO.PhieuNhap> GetAll()
        {
            return _dal.GetAll();
        }
        public ResponseDTO.PhieuNhap GetById(string id)
        {
            return _dal.GetById(id);
        }
    }
}
