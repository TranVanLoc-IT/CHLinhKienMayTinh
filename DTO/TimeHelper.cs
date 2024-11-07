using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TimeHelper
    {
        public static DateTimeOffset GetCurrentTime()
        {
            TimeSpan span = new TimeSpan(7,0,0);
            return DateTimeOffset.Now.ToOffset(span);
        }
    }
}
