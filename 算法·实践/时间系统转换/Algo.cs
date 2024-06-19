using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间系统转换
{
    class Algo
    {

        public static double[] Get_time(double mjd)
        {
            int a = Convert.ToInt32(mjd + 0.5);
            int b = a + 1537;
            double c = Convert.ToInt32((b - 122.1) / 365.25);
            int d = Convert.ToInt32(365.25 * c);
            int e = Convert.ToInt32((b - d) / 30.600);

            double[] data = new double[3];
            double frac = mjd + 0.5 - Math.Truncate(mjd + 0.5);
            data[0] = b - d - Convert.ToInt32(30.6001 * e) + frac; //日
            data[1] = e - 12 * Convert.ToInt32(e / 14); //月
            data[2] = c - 4715 - Convert.ToInt32((7 + data[1]) / 10); //年

            return data;
        }

        public static int year_of_day(time time)
        {
            int[] moth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if((time.year % 4 == 0 && time.year % 100 != 0)||(time.year % 400 == 0 && time.year % 3200 != 0))
            {
                moth[1] = 29;
            }
            int day=0;
            for(int i = 0; i < time.moth-1; i++)
            {
                day += moth[i];
            }
            day += Convert.ToInt32(time.day);
            return day;
        }
        public static void shaiwang(DateTime start, time time)
        {
            DateTime end = new DateTime((int)time.year, (int)time.moth, (int)time.day);
            //datetime用来存储年月日
            int sumDay = (end - start).Days + 1;  //计算两天之间相差的天数
            int period = Math.Abs(sumDay) % 5;   //求出除以5之后的余数

            if (period > 0 &&period <= 3)
            {
                time.shaiwang = true;  //今天是打鱼日   
            }
            else
            {
                time.shaiwang = false;  //今天是晒网日
            }
        }
    }
}
