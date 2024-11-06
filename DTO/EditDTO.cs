using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EditDTO
    {
        public class NhomSanPham
        {
            public string MaNhomSP { get; set; }
            public string TenNhom { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
        }

        public class ThuongHieu
        {
            public string MaThuongHieu { get; set; }
            public string TenThuongHieu { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
        }

        public class LoaiSanPham
        {
            public string MaLoaiSP { get; set; }
            public string MaNhomSP { get; set; }
            public string TenLoai { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
            public NhomSanPham NhomSanPham { get; set; }
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
            public DateTime ChinhSuaGanNhat { get; set; }
            public string NguoiChinhSuaGanNhat { get; set; }
        }

        public class KhachHang
        {
            public string MaKH { get; set; }
            public string SDT { get; set; }
            public string HoTen { get; set; }
            public DateTime NgayThamGia { get; set; }
            public bool DaXoa { get; set; }
            public DateTime ChinhSuaGanNhat { get; set; }
            public string NguoiChinhSuaGanNhat { get; set; }
        }

        public class SanPham
        {
            public string MaSanPham { get; set; }
            public string MaLoaiSP { get; set; }
            public string MaThuongHieu { get; set; }
            public string TenSanPham { get; set; }
            public decimal DonGia { get; set; }
            public byte TGBaoHanh { get; set; }
            public byte[] Hinh { get; set; }
            public string MoTa { get; set; }
            public int SoLuongTon { get; set; }
            public int SoLuongDaBan { get; set; }
            public DateTime NgayTao { get; set; }
            public bool DaXoa { get; set; }
            public DateTime CapNhatGanNhat { get; set; }
            public string NguoiChinhSuaGanNhat { get; set; }
        }

        public class PhieuNhap
        {
            public string MaPN { get; set; }
            public string MaSP { get; set; }
            public decimal TangTien { get; set; }
            public DateTime NgayNhap { get; set; }
            public bool DaXoa { get; set; }
        }

        public class DonHang
        {
            public string MaDonHang { get; set; }
            public string NhanVienTao { get; set; }
            public string MaKH { get; set; }
            public DateTime NgayTao { get; set; }
            public bool TinhTrang { get; set; }
            public string GhiChu { get; set; }
            public int TongSL { get; set; }
            public decimal ThanhTien { get; set; }
            public bool DaXoa { get; set; }
        }

        public class HoaDon
        {
            public string MaHoaDon { get; set; }
            public string MaDonHang { get; set; }
            public string NhanVienTao { get; set; }
            public DateTime NgayLap { get; set; }
            public decimal TongTien { get; set; }
            public bool DaXoa { get; set; }
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
            public string MaPN { get; set; }
            public string MaSanPham { get; set; }
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

        public class KhuyenMai
        {
            public string MaKhuyenMai { get; set; }
            public string MaCT { get; set; }
            public bool DaDung { get; set; }
        }

    }
}
