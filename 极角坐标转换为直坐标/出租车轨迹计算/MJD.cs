using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 出租车轨迹计算
{
    class MJD  //计算儒略历的·
    {
        public static double MJD1(int year,int moth,int day ,int hour, int min,int sec,int timezone)
        {
            double mjd = -678987 + 367.0 * year;
            mjd -= Convert.ToInt32(7.0 / 4.0 * (year + Convert.ToInt32((moth + 9.0) / 12.0)));
            mjd += Convert.ToInt32((275.0 * moth) / 9.0);
            mjd += day + (hour - timezone) / 24.0 + min / 1440.0 + sec / 86400.0;
            return mjd;
        }
    }
}
