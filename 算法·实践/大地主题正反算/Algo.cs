using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地主题正反算
{
    class Algo
    {
        //反算算法
        public static void Getfan(List<Basedata> basedatas,double[] jiben)
        {
            double startB = basedatas[0].startpoint.B;
            double startL = basedatas[0].startpoint.L;
            double endB = basedatas[0].endpoint.B;
            double endL = basedatas[0].endpoint.L;

            double u1 = Math.Atan(Math.Sqrt(1 - jiben[1]) * Math.Tan(startB));
            double u2 = Math.Atan(Math.Sqrt(1 - jiben[1]) * Math.Tan(endB));

            double a1 = Math.Sin(u1) * Math.Sin(u2);
            double a2 = Math.Cos(u1) * Math.Cos(u2);
            double b1 = Math.Cos(u1) * Math.Sin(u2);
            double b2 = Math.Sin(u1) * Math.Cos(u2);

            double l = endL - startL;
            double deta = 0;
            double lama = l + deta;

            double p = Math.Cos(u2) * Math.Sin(lama);
            double q = b1 - b2 * Math.Cos(lama);
            double A1 = Math.Atan(p / q);

            double sigema;
            if (p > 0 && q > 0)
            {
                A1 = Math.Abs(A1);
            }
            else if (p > 0 && q < 0)
            {
                A1 = 180 - Math.Abs(A1);
            }
            else if (p < 0 && q < 0)
            {
                A1 = Math.Abs(A1) + 180;
            }
            else if (p < 0 && q > 0)
            {
                A1 = 360 - Math.Abs(A1);
            }

            if (A1 < 0)
            {
                A1 = A1 + 360;
            }
            if (A1 > 360)
            {
                A1 = A1 - 360;
            }


        }
    }
}
