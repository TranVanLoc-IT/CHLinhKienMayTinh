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
    public class KhuyenMaiBLL
    {
        KhuyenMaiDAL _km;
        public KhuyenMaiBLL()
        {
            _km = new KhuyenMaiDAL();
        }
        // Phương thức lấy DataTable hiện tại
        public List<ResponseDTO.KhuyenMai> GetDataTable()
        {
            return _km.GetData(); // Lấy dữ liệu từ DAL
        }

        public string Update(KHUYENMAIDataTable km)
        {
            if (km == null) return Constant.NOT_FOUND;
            try
            {
                _km.Update(km);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }

        public string Create(EditDTO.KhuyenMai km)
        {
            if (km == null) return Constant.NOT_FOUND;
            try
            {
                _km.Create(km);
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
                _km.Delete(id);
            }
            catch (Exception ex)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }
        public IEnumerable<ResponseDTO.KhuyenMai> GetKhuyenMaisByDaDung(string maCT, bool daDung)
        {
            return _km.GetKhuyenMaisByDaDung(maCT, daDung);
        }
        public int GetQuantityByProgramId(string maCT)
        {
            return _km.GetQuantityByProgramId(maCT);
        }
    }
}
