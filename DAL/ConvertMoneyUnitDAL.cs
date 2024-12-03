using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConvertMoneyUnitDAL
    {
        public string ConvertToVND(decimal price)
        {
            return price.ToString("N0") + " VND";
        }
    }
}
