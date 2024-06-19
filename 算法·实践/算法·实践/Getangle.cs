using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法_实践
{
    class Getangle
    {
        /// <summary>
        /// ？？？？？？
        /// </summary>
        /// <param name="angle">十进制角度</param>
        /// <returns>返回有度分秒的双精度数组</returns>
        public static double[] Angle(double angle)
        {
            double Deg, Min, Sec;
            Deg = (int)angle;
            Min = (int)((angle - Deg + 1e-12) * 60);
            Sec = (((angle - Deg + 1e-12) * 60) - Min) * 60;
            double[] result = new double[3] { Deg, Min, Sec };
            return result;
        }
    }
}
