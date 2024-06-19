using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间系统转换
{
    class time
    {
        public double year;
        public double moth;
        public double day;
        public double hour;
        public double min;
        public double sec;
        public double mjd;
        public bool shaiwang;

        public time(string Line)
        {
            //str = str.Replace("  ", " ");   replace()方法是把旧字符串转换为新字符串
            //string[] cp = str.Split(' ', ',');  //以逗号和空格为标志拆分     

            Line = Line.Replace("  ", " ");
            string[] suf = Line.Split(' ','，');
            this.year = Convert.ToDouble(suf[0]);
            this.moth = Convert.ToDouble(suf[1]);
            this.day = Convert.ToDouble(suf[2]);
            this.hour = Convert.ToDouble(suf[3]);
            this.min = Convert.ToDouble(suf[4]);
            this.sec = Convert.ToDouble(suf[5]);

            Getmjd();
        }

        public  void Getmjd()
        {
            mjd += 1721013.5 + 367.0 * year;
            mjd -= Convert.ToInt32((7.0 / 4.0)*(year + Convert.ToInt32((moth + 9.0) / 12.0)) );
            mjd += Convert.ToInt32((275.0 * moth) / 9.0) + day;
            mjd += hour / 24.0 + min / 1440.0 + sec / 86400.0;
        }
    }
}
