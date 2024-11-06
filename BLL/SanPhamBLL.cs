using DAL;
using DTO;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL _dal;
        public SanPhamBLL()
        {
            _dal = new SanPhamDAL();
        }
        public string Update(SANPHAMDataTable sp)
        {
            if (sp == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Update(sp);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public string Create(EditDTO.SanPham sp)
        {

            if (sp == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(sp);
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
        public IEnumerable<ResponseDTO.SanPham> GetAll()
        {

            return _dal.GetAll();
        }
        public ResponseDTO.SanPham GetById(string id)
        {
            return _dal.GetById(id);
        }
    }
}
