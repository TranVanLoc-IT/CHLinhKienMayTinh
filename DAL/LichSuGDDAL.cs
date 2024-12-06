using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichSuGDDAL
    {
        private LICHSU_GIAODICHTableAdapter _adapter;
        private DonHangDAL _dh;

        public LichSuGDDAL()
        {
            _adapter = new LICHSU_GIAODICHTableAdapter();
            _dh = new DonHangDAL();
        }
        public void Create(EditDTO.LichSuGD gd)
        {
            _adapter.Insert(gd.MaGiaoDich, gd.NganHang, gd.MaDonHang, gd.SoTien, gd.NgayTao, gd.PhuongThuc, gd.TrangThai);

            _dh.UpdateStatus(gd.MaDonHang);
        }

        public IEnumerable<ResponseDTO.LichSuGD> GetAllGDToday()
        {
            return _adapter.GetData().Where(r => r.NgayGiaoDich.Date == DateTime.Now.Date).Select(r => new ResponseDTO.LichSuGD()
            {
                MaGiaoDich = r.MaGiaoDich,
                MaDonHang = r.MaDonHang,
                SoTien = r.SoTien,
                NganHang = r.NganHang,
                PhuongThuc = r.PhuongThuc,
                TrangThai = r.TrangThai,
                NgayTao = r.NgayGiaoDich
            });
        }
    }
}
