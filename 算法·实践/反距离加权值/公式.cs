using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反距离加权值
{
    class gongshi
    {
        public static double Getlength(double x1,double y1,double x2,double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double S = Math.Sqrt(dx * dx + dy * dy);
            return S;
        }
    }
}
