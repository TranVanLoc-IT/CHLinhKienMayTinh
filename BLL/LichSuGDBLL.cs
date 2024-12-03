using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichSuGDBLL
    {
        private LichSuGDDAL _dal;
        public LichSuGDBLL()
        {
            _dal = new LichSuGDDAL();
        }

        public void Create(EditDTO.LichSuGD gd)
        {
            _dal.Create(gd);
        }

        public IEnumerable<ResponseDTO.LichSuGD> GetAllGDToday()
        {
            return _dal.GetAllGDToday();
        }
    }
}
