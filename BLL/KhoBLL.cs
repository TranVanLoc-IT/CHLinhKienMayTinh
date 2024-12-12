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
    public class KhoBLL
    {
        private KhoDAL _kho;

        public KhoBLL()
        {
            _kho = new KhoDAL();
        }

        // Lấy toàn bộ DataTable
        public SANPHAMDataTable GetDataTable()
        {
            return _kho.GetData();
        }

        // Cập nhật dữ liệu từ DataTable
        public string Update(SANPHAMDataTable sp)
        {
            if (sp == null) return Constant.NOT_FOUND;
            try
            {
                _kho.Update(sp);
            }
            catch (Exception)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }

        // Tạo mới sản phẩm
        public string Create(EditDTO.SanPham sp)
        {
            if (sp == null) return Constant.NOT_FOUND;
            try
            {
                _kho.Create(sp);
            }
            catch (Exception)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }

        // Xóa sản phẩm dựa trên mã sản phẩm
        public string Delete(string id)
        {
            try
            {
                _kho.Delete(id);
            }
            catch (Exception)
            {
                return Constant.SQL_ERROR;
            }
            return Constant.SUCCESS;
        }

        // Lấy danh sách sản phẩm theo số lượng tồn kho
        public IEnumerable<ResponseDTO.SanPham> GetSanPhamsByQuantity(int soLuongTon)
        {
            return _kho.GetSanPhamsByQuantity(soLuongTon);
        }

        // Đếm tổng số sản phẩm trong kho
        public int GetTotalProducts()
        {
            return _kho.GetTotalProducts();
        }
    }
}
