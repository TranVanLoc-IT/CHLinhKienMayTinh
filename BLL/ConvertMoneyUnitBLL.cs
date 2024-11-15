using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConvertMoneyUnitBLL
    {
        private ConvertMoneyUnitDAL _dal;
        public ConvertMoneyUnitBLL()
        {
            _dal = new ConvertMoneyUnitDAL();
        }
        public string ConvertToVND(decimal price)
        {
            return _dal.ConvertToVND(price);
        }
    }
}
