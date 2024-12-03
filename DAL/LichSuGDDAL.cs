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

        public LichSuGDDAL()
        {
            _adapter = new LICHSU_GIAODICHTableAdapter();
        }
        public void Create(EditDTO.LichSuGD gd)
        {
            _adapter.Insert(gd.MaDonHang, gd.NganHang, gd.MaDonHang, gd.SoTien, gd.NgayTao, gd.PhuongThuc, gd.TrangThai);
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
