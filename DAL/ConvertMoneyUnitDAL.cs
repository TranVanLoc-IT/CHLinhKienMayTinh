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
            if(price < 1000){
                return price.ToString("N0") + " Đồng VND";
            }
            if (price < 10000)
            {
                return price.ToString("N0") + " Nghìn VND";
            }
            if (price < 1000000)
            {
                return price.ToString("N0") + " Triệu VND";
            }
            return price.ToString("N0") + " Tỷ VND";
        }
    }
}
