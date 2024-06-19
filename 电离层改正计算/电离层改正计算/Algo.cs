using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电离层改正计算
{
    class Algo
    {
        /// <summary>
        /// 以测站P为原点建立直角坐标系
        /// </summary>
        /// <param name="pointP"></param>
        /// <param name="point"></param>
        public static void H_angleandangle(point pointP,point point)
        {
            double dx = point.X - pointP.X;
            double dy = point.Y - pointP.Y;
            double dz = point.Z - pointP.Z;
            double BP = 30;
            double LP = 114;
            double X = -Math.Sin(BP) * Math.Cos(LP) * dx + (-Math.Sin(BP) * Math.Sin(LP) * dy) + Math.Cos(BP) * dz;
            double Y = -Math.Sin(LP) * dx + Math.Cos(LP) * dy;
            double Z = Math.Cos(BP) * Math.Cos(LP) * dx + Math.Cos(BP) * Math.Sin(LP) * dy + Math.Sin(BP) * dz;

            point.H_angle = trandfm(Math.Atan(Y / X));
            point.F_angle = trandfm( Math.Atan(Z / Math.Sqrt(X * X + Y * Y)));
        }

        /// <summary>
        /// 穿刺点计算
        /// </summary>
        public static void chuancidian(point P)
        {

        }

        /// <summary>
        /// 弧度制转换为度分秒
        /// </summary>
        public static double trandfm(double Rad)
        {
            int i = 1;
            if (Rad < 0)
            {
                Rad = -Rad;
                i = -1;
            }

            double Dfm = Rad * 180 / Math.PI;

            double D = Math.Floor(Dfm);
            double F = Math.Floor((Dfm-D)*60);
            double M = ((Dfm - D) * 60 - F) * 60;

            return (D + F / 100.0 + M / 10000.0) * i;
        }
    }
}
