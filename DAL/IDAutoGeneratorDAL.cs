using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IDAutoGeneratorDAL
    {
        public static string Generate(string prefix, int length)
        {
            string auto = Guid.NewGuid().ToString("N").Substring(0, length);
            return prefix + auto;
        }
    }
}
