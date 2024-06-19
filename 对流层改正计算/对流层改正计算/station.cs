using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对流层改正计算
{
    class station
    {
        public string name;
        public string Time;
        public double B;
        public double L;
        public double H;
        public double Angle;

        public double Mw;
        public double Md;
        public TimeSpan yearday;
        public double doy;
        public double ZHD, ZWD, dertaS;
        public station(string Line)
        {
            string[] vs = Line.Split(',');
            name = vs[0];
            Time = vs[1];
            B = Convert.ToDouble(vs[2]);
            L = Convert.ToDouble(vs[3]);
            H = Convert.ToDouble(vs[4]);
            Angle = Convert.ToDouble(vs[5]);

            doy = Yearday(Time);
            ZHD= 2.29951 * Math.Pow(Math.E, -0.000116 * H);
            ZWD = 0.1;
        }

        public station()
        {

        }

        public  double Yearday(string Time)
        {
            int Year = Convert.ToInt32(Time.Substring(0, 4));
            int month = Convert.ToInt32(Time.Substring(4, 2));
            int day = Convert.ToInt32(Time.Substring(6, 2));

            DateTime dateTime = new DateTime(Year, month, day);
            yearday = dateTime - new DateTime(Year, 1, 1);
            return yearday.Days;
        }
    }
}
