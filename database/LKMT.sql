CREATE DATABASE LKMT;
GO
USE LKMT;
GO
CREATE TABLE NHOMSANPHAM (
    MaNhomSP CHAR(3) PRIMARY KEY,
    TenNhom NVARCHAR(100),
    NgayTao DATETIME,
    DaXoa BIT
);
GO
CREATE TABLE THUONGHIEU (
    MaThuongHieu CHAR(2) PRIMARY KEY,
    TenThuongHieu NVARCHAR(100),
    NgayTao DATETIME,
    DaXoa BIT
);
GO
CREATE TABLE LOAISANPHAM (
    MaLoaiSP CHAR(4) PRIMARY KEY,
    MaNhomSP CHAR(3),
    TenLoai NVARCHAR(100),
    NgayTao DATETIME,
    DaXoa BIT,
    FOREIGN KEY (MaNhomSP) REFERENCES NHOMSANPHAM(MaNhomSP)
);
GO
CREATE TABLE NHANVIEN (
    MaNV CHAR(7) PRIMARY KEY,
    Email VARCHAR(100),
    MatKhau CHAR(20),
    HoTen NVARCHAR(100),
    SDT CHAR(11),
    DiaChi NVARCHAR(MAX),
    ChucVu NCHAR(10),
    TrangThai BIT,
    NgayVaoLam DATETIME,
    ChinhSuaGanNhat DATETIME,
    NguoiChinhSuaGanNhat CHAR(7)
);
GO
CREATE TABLE KHACHHANG (
    MaKH CHAR(10) PRIMARY KEY,
    SDT CHAR(11),
    HoTen NVARCHAR(100),
    NgayThamGia DATE,
    DaXoa BIT,
    ChinhSuaGanNhat DATETIME,
    NguoiChinhSuaGanNhat CHAR(7)
);
GO
CREATE TABLE SANPHAM (
    MaSanPham CHAR(5) PRIMARY KEY,
    MaLoaiSP CHAR(4),
    MaThuongHieu CHAR(2),
    TenSanPham NVARCHAR(MAX),
    DonGia DECIMAL(18,2),
    TGBaoHanh TINYINT,
    Hinh IMAGE,
    MoTa NVARCHAR(MAX),
    SoLuongTon INT,
    SoLuongDaBan INT,
    NgayTao DATETIME,
    DaXoa BIT,
    CapNhatGanNhat DATETIME,
    NguoiChinhSuaGanNhat CHAR(7),
    FOREIGN KEY (MaLoaiSP) REFERENCES LOAISANPHAM(MaLoaiSP),
    FOREIGN KEY (MaThuongHieu) REFERENCES THUONGHIEU(MaThuongHieu)
);
GO
CREATE TABLE PHIEUNHAP (
    MaPN CHAR(6) PRIMARY KEY,
    TangTien DECIMAL(18,2),
    NgayNhap DATETIME,
    DaXoa BIT,
);
GO
CREATE TABLE DONHANG (
    MaDonHang CHAR(10) PRIMARY KEY,
    NhanVienTao CHAR(7),
    MaKH CHAR(10),
    NgayTao DATETIME,
    NgayCapNhat DATETIME,
    TinhTrang NVARCHAR(20), -- Chờ xử lý, Đang giao, Hoàn tất, Hủy
    GhiChu NVARCHAR(500),
    ThanhTien DECIMAL(18,2),
    TienGiam DECIMAL(18,2),
    DaXoa BIT,
    FOREIGN KEY (NhanVienTao) REFERENCES NHANVIEN(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
);
GO
CREATE TABLE LICHSU_GIAODICH (
    MaGiaoDich VARCHAR(20) PRIMARY KEY,
	NganHang NVARCHAR(100),
    MaDonHang CHAR(10),
    SoTien DECIMAL(18, 2),
    NgayGiaoDich DATETIME,
    PhuongThuc NVARCHAR(50),
    TrangThai TINYINT,
    FOREIGN KEY (MaDonHang) REFERENCES DONHANG(MaDonHang)
);
GO
CREATE TABLE CHUONGTRINH (
    MaCT CHAR(4) PRIMARY KEY,
    NgayBD DATE,
    NgayKT DATE,
    GiaTriPhanTram TINYINT,
    GiaTriHoaDon DECIMAL(18,2),
    DieuKienApDung NVARCHAR(MAX),
    NgayTao DATETIME,
    DaXoa BIT
);
GO
CREATE TABLE CHITIETPHIEUNHAP (
    MaPN CHAR(6),
    MaSanPham CHAR(5),
	MaThuongHieu CHAR(2),
    GiaNhap DECIMAL(18,2),
    SoLuong INT,
    ThanhTien DECIMAL(18,2),
    PRIMARY KEY (MaPN, MaSanPham),
    FOREIGN KEY (MaPN) REFERENCES PHIEUNHAP(MaPN),
    FOREIGN KEY (MaSanPham) REFERENCES SANPHAM(MaSanPham),
    FOREIGN KEY (MaThuongHieu) REFERENCES ThuongHieu(MaThuongHieu)
);
GO
CREATE TABLE CHITIETDONHANG (
    MaDonHang CHAR(10),
    MaSanPham CHAR(5),
    ThanhTien DECIMAL(18,2),
    SoLuong INT,
    PRIMARY KEY (MaDonHang, MaSanPham),
    FOREIGN KEY (MaDonHang) REFERENCES DONHANG(MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SANPHAM(MaSanPham)
);
GO
CREATE TABLE KHUYENMAI (
    MaKhuyenMai CHAR(9) PRIMARY KEY,
	MaDH CHAR(10),
    MaCT CHAR(4),
    DaDung BIT,
    FOREIGN KEY (MaCT) REFERENCES CHUONGTRINH(MaCT),
	FOREIGN KEY (MaDH) REFERENCES DONHANG(MaDonHang)
);
GO
-- Dữ liệu mẫu cho bảng NHOMSANPHAM
INSERT INTO NHOMSANPHAM (MaNhomSP, TenNhom, NgayTao, DaXoa)
VALUES 
('001', N'Linh kiện máy tính', GETDATE(), 0),
('002', N'Phụ kiện', GETDATE(), 0),
('003', N'Thiết bị mạng', GETDATE(), 0),
('004', N'Thiết bị lưu trữ', GETDATE(), 0),
('005', N'Thiết bị âm thanh', GETDATE(), 0);
GO
-- Dữ liệu mẫu cho bảng THUONGHIEU
INSERT INTO THUONGHIEU (MaThuongHieu, TenThuongHieu, NgayTao, DaXoa)
VALUES 
('AS', 'Asus', GETDATE(), 0),
('MS', 'MSI', GETDATE(), 0),
('DE', 'Dell', GETDATE(), 0),
('HP', 'HP', GETDATE(), 0),
('AC', 'Acer', GETDATE(), 0);
GO
-- Dữ liệu mẫu cho bảng LOAISANPHAM
INSERT INTO LOAISANPHAM (MaLoaiSP, MaNhomSP, TenLoai, NgayTao, DaXoa)
VALUES 
('L001', '001', 'CPU', GETDATE(), 0),
('L002', '001', N'Mainboard', GETDATE(), 0),
('L003', '001', N'RAM', GETDATE(), 0),
('L004', '001', N'Ổ cứng SSD', GETDATE(), 0),
('L005', '001', N'Card đồ họa', GETDATE(), 0);
GO
-- Dữ liệu mẫu cho bảng NHANVIEN
INSERT INTO NHANVIEN (MaNV, Email, MatKhau, HoTen, SDT, DiaChi, ChucVu, TrangThai, NgayVaoLam, ChinhSuaGanNhat, NguoiChinhSuaGanNhat)
VALUES 
('NV00001', 'nv1@example.com', 'a1234', N'Nguyễn Văn A', '01234567890', N'Hà Nội', N'Quản lý', 1, GETDATE(), GETDATE(), 'NV00001'),
('NV00002', 'nv2@example.com', 'b1234', N'Trần Văn B', '09876543210', N'Hồ Chí Minh', N'Nhân viên', 1, GETDATE(), GETDATE(), 'NV00001'),
('NV00003', 'nv3@example.com', 'c1234', N'Lê Thị C', '03216549870', N'Đà Nẵng', N'Thu ngân', 1, GETDATE(), GETDATE(), 'NV00001'),
('NV00004', 'nv4@example.com', 'd1234', N'Phạm Văn D', '05678903412', N'Cần Thơ', N'Nhân viên', 1, GETDATE(), GETDATE(), 'NV00001'),
('NV00005', 'nv5@example.com', 'e1234', N'Hoàng Thị E', '07482913756', N'Huế', N'Thu ngân', 1, GETDATE(), GETDATE(), 'NV00001');
GO
-- Dữ liệu mẫu cho bảng KHACHHANG
INSERT INTO KHACHHANG (MaKH, SDT, HoTen, NgayThamGia, DaXoa, ChinhSuaGanNhat, NguoiChinhSuaGanNhat)
VALUES 
('KH0000001', '0912345678', N'Nguyễn Minh Tâm', GETDATE(), 0, GETDATE(), 'NV00001'),
('KH0000002', '0934567890', N'Trần Văn Hùng', GETDATE(), 0, GETDATE(), 'NV00001'),
('KH0000003', '0945678901', N'Lê Thị Hoa', GETDATE(), 0, GETDATE(), 'NV00001'),
('KH0000004', '0978901234', N'Phạm Quang Vinh', GETDATE(), 0, GETDATE(), 'NV00001'),
('KH0000005', '0990123456', N'Hoàng Thị Lan', GETDATE(), 0, GETDATE(), 'NV00001');
GO
-- Dữ liệu mẫu cho bảng SANPHAM
INSERT INTO SANPHAM (MaSanPham, MaLoaiSP, MaThuongHieu, TenSanPham, DonGia, TGBaoHanh, Hinh, MoTa, SoLuongTon, SoLuongDaBan, NgayTao, DaXoa, CapNhatGanNhat, NguoiChinhSuaGanNhat)
VALUES 
('SP001', 'L001', 'AS', 'Intel Core i5', 3000000, 36, NULL, N'CPU Intel thế hệ 10', 50, 10, GETDATE(), 0, GETDATE(), 'NV00001'),
('SP002', 'L001', 'AS', 'Intel Core i7', 4500000, 36, NULL, N'CPU Intel thế hệ 10', 30, 5, GETDATE(), 0, GETDATE(), 'NV00001'),
('SP003', 'L002', 'MS', 'MSI B450M', 2500000, 24, NULL, N'Mainboard cho AMD', 40, 8, GETDATE(), 0, GETDATE(), 'NV00002'),
('SP004', 'L002', 'AS', 'ASUS TUF B450', 2800000, 24, NULL, N'Mainboard hỗ trợ Ryzen', 35, 12, GETDATE(), 0, GETDATE(), 'NV00001'),
('SP005', 'L003', 'DE', 'Kingston 8GB', 700000, 12, NULL, N'RAM DDR4', 100, 50, GETDATE(), 0, GETDATE(), 'NV00002'),
('SP006', 'L003', 'HP', 'Corsair Vengeance 16GB', 1500000, 12, NULL, N'RAM DDR4', 60, 30, GETDATE(), 0, GETDATE(), 'NV00001'),
('SP007', 'L004', 'DE', 'Samsung SSD 860 EVO', 1200000, 36, NULL, N'SSD 256GB', 75, 40, GETDATE(), 0, GETDATE(), 'NV00003'),
('SP008', 'L004', 'HP', 'WD Green 240GB', 900000, 36, NULL, N'SSD 240GB', 85, 45, GETDATE(), 0, GETDATE(), 'NV00002'),
('SP009', 'L005', 'MS', 'NVIDIA GTX 1660', 7000000, 36, NULL, N'Card đồ họa 6GB', 20, 15, GETDATE(), 0, GETDATE(), 'NV00001'),
('SP010', 'L005', 'AS', 'NVIDIA RTX 2060', 12000000, 36, NULL, N'Card đồ họa 6GB', 10, 8, GETDATE(), 0, GETDATE(), 'NV00001');
GO


-- Dữ liệu mẫu cho bảng PHIEUNHAP
INSERT INTO PHIEUNHAP (MaPN,  TangTien, NgayNhap, DaXoa)
VALUES 
('PN0001', 3000000, GETDATE(), 0),
('PN0002', 4500000, GETDATE(), 0),
('PN0003', 2500000, GETDATE(), 0),
('PN0004', 2800000, GETDATE(), 0),
('PN0005', 700000, GETDATE(), 0);

-- Dữ liệu mẫu cho bảng DONHANG


-- Dữ liệu mẫu cho bảng CHITIETPHIEUNHAP
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaSanPham, GiaNhap, SoLuong, ThanhTien, MaThuongHieu)
VALUES 
('PN0001', 'SP001', 2500000, 10, 25000000,'AS'),
('PN0002', 'SP002', 3700000, 5, 18500000, 'MS'),
('PN0003', 'SP003', 2300000, 8, 18400000, 'DE'),
('PN0004', 'SP004', 2400000, 6, 14400000, 'MS'),
('PN0005', 'SP005', 600000, 15, 9000000, 'DE');

select * from thuonghieu
select * from sanpham
select * from nhanvien
select * from phieunhap
select * from chitietphieunhap