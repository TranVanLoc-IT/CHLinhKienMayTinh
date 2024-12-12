using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class KhoDAL
    {
        private SANPHAMTableAdapter _spAdapter;

        public KhoDAL()
        {
            _spAdapter = new SANPHAMTableAdapter();
        }

        // Lấy toàn bộ danh sách sản phẩm (DataTable)
        public SANPHAMDataTable GetData()
        {
            return _spAdapter.GetData();
        }

        // Cập nhật dữ liệu từ DataTable
        public void Update(SANPHAMDataTable sp)
        {
            _spAdapter.Update(sp);
        }

        // Tạo mới sản phẩm
        public void Create(EditDTO.SanPham sp)
        {
            _spAdapter.Insert(
                sp.MaSanPham,
                sp.MaLoaiSP,
                sp.MaThuongHieu,
                sp.TenSanPham,
                sp.DonGia,
                sp.TGBaoHanh,
                sp.Hinh,
                sp.MoTa,
                sp.SoLuongTon,
                sp.SoLuongDaBan,
                sp.NgayTao,
                sp.DaXoa,
                sp.CapNhatGanNhat,
                sp.NguoiChinhSuaGanNhat
            );
        }

        // Xóa sản phẩm dựa trên mã sản phẩm
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaSanPham(id); // Giả sử stored procedure XoaSanPham đã được định nghĩa
        }

        // Lấy danh sách sản phẩm theo số lượng tồn kho
        public IEnumerable<ResponseDTO.SanPham> GetSanPhamsByQuantity(int soLuongTon)
        {
            return _spAdapter.GetData()
                .Where(row => row.SoLuongTon <= soLuongTon)
                .Select(row => new ResponseDTO.SanPham
                {
                    MaSanPham = row.MaSanPham,
                    TenSanPham = row.TenSanPham,
                    SoLuongTon = row.SoLuongTon,
                    DonGia = row.DonGia
                }).ToList();
        }

        // Đếm tổng số sản phẩm trong kho
        public int GetTotalProducts()
        {
            return _spAdapter.GetData().Count();
        }
    }
}
