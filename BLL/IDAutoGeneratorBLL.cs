using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IDAutoGeneratorBLL
    {
        public static string Generate(string prefix, int length)
        {
            if(length < 0 && prefix == null)
            {
                return null;
            }
            return IDAutoGeneratorDAL.Generate(prefix, length);
        }
    }
}
