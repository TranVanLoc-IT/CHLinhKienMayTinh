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
        public string Create(EditDTO.PhieuNhap pn, List<EditDTO.ChiTietPhieuNhap> pns)
        {

            if (pn == null) return Constant.NOT_FOUND;
            try
            {
                _dal.Create(pn, pns);
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
        public List<ResponseDTO.PhieuNhap> GetAll()
        {
            return _dal.GetAll();
        }
        public ResponseDTO.PhieuNhap GetById(string id)
        {
            return _dal.GetById(id);
        }

        public List<ResponseDTO.SanPhamPhieuNhap> GetAllSP()
        {
            return _dal.GetAllSP();
        }

        public List<ResponseDTO.SanPhamPhieuNhap> searchSP(string txtSearch)
        {
            List<ResponseDTO.SanPhamPhieuNhap> danhSachSP = _dal.GetAllSP();

            var ketQuaTimKiem = danhSachSP
                .Where(nv => nv.TenSP.IndexOf(txtSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return ketQuaTimKiem;

        }

        public string GeneratorMaPN()
        {
            // Giả sử maPN là "PN0005"
            string maPN = _dal.GetAll().Last().MaPN;

            // Tách phần "PN" và số sau "PN"
            string prefix = maPN.Substring(0, 2); // Lấy "PN"
            string numberPart = maPN.Substring(2); // Lấy phần số "0005"

            // Chuyển phần số thành số nguyên, cộng 1
            int number = int.Parse(numberPart);
            number++;

            // Tạo lại chuỗi với phần số mới
            maPN = prefix + number.ToString().PadLeft(4, '0'); // Đảm bảo số luôn có 4 chữ số

            return maPN;
        }
    }
}
