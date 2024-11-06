using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;
namespace BLL
{
    public class ChuongTrinhBLL
    {
        private ChuongTrinhDAL _dal;
        public ChuongTrinhBLL()
        {
            _dal = new ChuongTrinhDAL();
        }
        public string Update(CHUONGTRINHDataTable ct)
        {
            if (ct == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(ct);
            }
            catch(Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.ChuongTrinh ct)
        {

            if (ct == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(ct);
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
        public IEnumerable<ResponseDTO.ChuongTrinh> GetAll()
        {

            return _dal.GetAll();
        }
    }
}
