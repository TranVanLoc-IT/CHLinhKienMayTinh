﻿using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class PhieuNhapDAL
    {
        private PHIEUNHAPTableAdapter _db;
        private SANPHAMTableAdapter _dbSP;
        private CTPhieuNhapDAL _ctpnDAL;
        public PhieuNhapDAL()
        {
            _db = new PHIEUNHAPTableAdapter();
            _ctpnDAL = new CTPhieuNhapDAL();
            _dbSP = new SANPHAMTableAdapter();
        }
        public void Update(PHIEUNHAPDataTable pn)
        {
            _db.Update(pn);
        }
        public void Create(EditDTO.PhieuNhap pn, List<EditDTO.ChiTietPhieuNhap> pns)
        {
            _db.Insert(pn.MaPN, pn.TongTien, pn.NgayNhap, pn.DaXoa);
            _ctpnDAL.Create(pns);
        }
        public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaPhieuNhap(id);
        }
        public List<ResponseDTO.PhieuNhap> GetAll()
        {
            return _db.GetData().Where(p => p.DaXoa == false).Select(p => new ResponseDTO.PhieuNhap { MaPN = p.MaPN, TongTien = p.TangTien, NgayNhap = p.NgayNhap }).ToList<ResponseDTO.PhieuNhap>();
        }

        public List<ResponseDTO.PhieuNhap> GetAllValid()
        {
            return _db.GetData().Select(p => new ResponseDTO.PhieuNhap { MaPN = p.MaPN, TongTien = p.TangTien, NgayNhap = p.NgayNhap }).ToList<ResponseDTO.PhieuNhap>();
        }

        public ResponseDTO.PhieuNhap GetById(string id)
        {
            return (ResponseDTO.PhieuNhap)_db.GetData().Where(r => r.MaPN == id);
        }

        public List<ResponseDTO.SanPhamPhieuNhap> GetAllSP()
        {
            return _dbSP.GetData().Select(p => new ResponseDTO.SanPhamPhieuNhap { MaSP = p.MaSanPham, TenSP = p.TenSanPham, MaThuongHieu = p.MaThuongHieu, DonGia = p.DonGia, SoLuongTon = p.SoLuongTon }).ToList<ResponseDTO.SanPhamPhieuNhap>();
        }
    }
}
