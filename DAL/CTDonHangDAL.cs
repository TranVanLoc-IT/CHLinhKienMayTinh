﻿using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTDonHangDAL
    {
        private SanPhamDAL _spDAL;
        private CHITIETDONHANGTableAdapter _db;
        public CTDonHangDAL()
        {
            _spDAL = new SanPhamDAL();
            _db = new CHITIETDONHANGTableAdapter();
        }
        public IEnumerable<ResponseDTO.ChiTietDonHang> GetAll(string idDH)
        {
            return (IEnumerable<ResponseDTO.ChiTietDonHang>)_db.GetData().Where(r => r.MaDonHang == idDH);
        }
        public void CreateRange(string madh, List<ProductCartModel> cart)
        {
            foreach (var dh in cart)
            {
                _db.Insert(madh, dh.MaSanPham, dh.ThanhTien, dh.SoLuong);
                _spDAL.UpdateQuantity(dh.MaSanPham, dh.SoLuong);
            }
        }
    }
}
