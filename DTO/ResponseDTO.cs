using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResponseDTO
    {
        public class DaXoaOption
        {
            public string Name { get; set; }
            public bool IsDeleted { get; set; }
        }

        public class NhomSanPham
        {
            public string MaNhomSP { get; set; }
            public string TenNhom { get; set; }
            public DateTime NgayTao { get; set; }
        }

        public class ThuongHieu
        {
            public string MaThuongHieu { get; set; }
            public string TenThuongHieu { get; set; }
        }

        public class LoaiSanPham
        {
            public string MaLoaiSP { get; set; }
            public string MaNhomSP { get; set; }
            public string TenLoai { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
        }

        public class LichSuGD
        {
            public string MaGiaoDich { get; set; }
            public string MaDonHang { get; set; }
            public string PhuongThuc { get; set; }
            public byte TrangThai { get; set; }
            public string NganHang { get; set; }
            public decimal SoTien { get; set; }
            public DateTime NgayTao { get; set; }
        }
        public class NhanVien
        {
            public string MaNV { get; set; }
            public string Email { get; set; }
            public string MatKhau { get; set; }
            public string HoTen { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }
            public string ChucVu { get; set; }
            public bool TrangThai { get; set; }
            public DateTime NgayVaoLam { get; set; }
        }

        public class KhachHang
        {
            [DisplayName("Tên khách hàng")]
            public string MaKH { get; set; }

            [DisplayName("Số điện thoại")]
            public string SDT { get; set; }

            [DisplayName("Họ tên")]
            public string HoTen { get; set; }

            [DisplayName("Ngày tham gia")]
            public DateTime NgayThamGia { get; set; }
        }

        public class SanPham
        {
            [DisplayName("Mã sản phẩm")]
            public string MaSanPham { get; set; }

            [DisplayName("Tên sản phầm")]
            public string TenSanPham { get; set; }

            [DisplayName("Tên loại")]
            public string TenLoaiSP { get; set; }

            [DisplayName("Tên thương hiệu")]
            public string TenThuongHieu { get; set; }

            [DisplayName("Đơn giá")]
            public decimal DonGia { get; set; }

            [DisplayName("Thời gian bảo hành")]
            public byte TGBaoHanh { get; set; }

            [DisplayName("Mô tả")]
            public string MoTa { get; set; }

            [DisplayName("Số lượng còn")]
            public int SoLuongTon { get; set; }

            [DisplayName("Đã bán")]
            public int SoLuongDaBan { get; set; }
        }

        public class PhieuNhap
        {
            public string MaPN { get; set; }
            public decimal TongTien { get; set; }
            public DateTime NgayNhap { get; set; }
        }

        public class DonHang
        {
            [DisplayName("Mã đơn hàng")]
            public string MaDonHang { get; set; }

            [DisplayName("Tên nhân viên")]
            public string TenNhanVien { get; set; }

            [DisplayName("Tên khách hàng")]
            public string TenKH { get; set; }

            [DisplayName("Ngày tạo")]
            public DateTime NgayTao { get; set; }

            [DisplayName("Tình trạng")]
            public string TinhTrang { get; set; }

            [DisplayName("Ghi chú")]
            public string GhiChu { get; set; }

            [DisplayName("Số lượng mua")]
            public int TongSL { get; set; }

            [DisplayName("Tổng tiền")]
            public decimal ThanhTien { get; set; }

            [DisplayName("Giảm giá")]
            public decimal GiamGia { get; set; }
		}

        public class HoaDon
        {
            public string MaHoaDon { get; set; }
            public string MaDonHang { get; set; }
            public string NhanVienTao { get; set; }
            public DateTime NgayLap { get; set; }
            public decimal TongTien { get; set; }
        }

        public class ChuongTrinh
        {
            public string MaCT { get; set; }
            public DateTime NgayBD { get; set; }
            public DateTime NgayKT { get; set; }
            public byte GiaTriPhanTram { get; set; }
            public decimal GiaTriHoaDon { get; set; }
            public string DieuKienApDung { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
        }

        public class ChiTietPhieuNhap
        {
            public string MaSP { get; set; }
            public string MaThuongHieu { get; set; }
            public decimal GiaNhap { get; set; }
            public int SoLuong { get; set; }
            public decimal ThanhTien { get; set; }
        }

        public class ChiTietDonHang
        {
            public string MaDonHang { get; set; }
            public string MaSanPham { get; set; }
            public decimal ThanhTien { get; set; }
            public int SoLuong { get; set; }
        }

        public class ChiTietDHResult
        {
            public string TenSanPham { get; set; }
            public decimal ThanhTien { get; set; }
            public int SoLuong { get; set; }
        }

        public class KhuyenMai
        {
            public string MaKhuyenMai { get; set; }
            public string MaCT { get; set; }
            public string MaHD { get; set; }
            public bool DaDung { get; set; }
            public int SoLuong { get; set; }
        }

        public class SanPhamPhieuNhap
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string MaThuongHieu { get; set; }

            public decimal DonGia { get; set; }
            public int SoLuongTon { get; set; }
        }
    }
}
