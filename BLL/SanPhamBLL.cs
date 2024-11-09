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
    public class SanPhamBLL
    {
        private SanPhamDAL _dal;
        private IEnumerable<ResponseDTO.SanPham> data;
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
            data = _dal.GetAll();
            return data;
        }
        public IEnumerable<ResponseDTO.SanPham> HotSale()
        {
            if(data == null)
            {
                data = _dal.GetAll();
            }
            return data.OrderByDescending(r => r.SoLuongDaBan).Take(5);
        }
        public string[] HotBrand()
        {
            if (data == null)
            {
                data = _dal.GetAll();
            }
            string[] result = data.OrderByDescending(r => r.SoLuongDaBan).Distinct().Take(3).Select( r => r.TenThuongHieu).ToArray();
            return result;
        }
    }
}
