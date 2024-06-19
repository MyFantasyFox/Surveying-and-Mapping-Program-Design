using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算
{
    class ellipse
    {
        public double a;
        public double b;
        public double f;
        public double e2;
        public double e_2;
        //反算需要的值
        public double cos2A0, k2, A, B, C, arfa, beta, gama;
        //正算需要的值
        public double W1, sinu1, cosu1,sinA0,cotsigema1,sigema1;
        public ellipse(double a,double f)
        {
            this.a = a;
            this.f = f;
            b = a - a * f;
            e2 = (a * a - b * b) / (a * a);
            e_2 = e2 / (1 - e2);
        }

        public void xishu(double A0)
        {
            cos2A0 = 1 - A0 * A0;
            k2 = e_2 * cos2A0;
            A = (1 - k2 / 4 + (7 * k2 * k2) / 64 - (15 * k2 * k2 * k2) / 256) / b;
            B = (k2 / 4 - (k2 * k2) / 8 + (37 * k2 * k2 * k2) / 512);
            C = ((k2 * k2) * 1.0 / 128 - (k2 * k2 * k2) * 1.0 / 128);
            arfa = (e2 / 2 + e2 * e2 / 8 + e2 * e2 * e2 / 16) - (e2 * e2 / 16 + e2 * e2 * e2 / 16) * cos2A0 + (3 * e2 * e2 * e2 / 128) * cos2A0 * cos2A0;
            beta = (e2 * e2 * 1.0 / 16 + e2 * e2 * e2 * 1.0 / 16) * cos2A0 - (e2 * e2 * e2 * 1.0 / 32) * cos2A0 * cos2A0;
            gama = e2 * e2 * e2 / 256 * cos2A0 * cos2A0;
        }

        /// <summary>
        /// 输出大地方位角反算系数
        /// </summary>
        /// <param name="B1">起始点经度</param>
        /// <param name="A1">起始点方位角</param>
        public void zhengxishu(double B1,double A1)
        {
            W1 = Math.Sqrt(1 - e2 * Math.Pow(Math.Sin(B1), 2));
            sinu1 = (Math.Sin(B1) * Math.Sqrt(1 - e2)) / W1;
            cosu1 = Math.Cos(B1) / W1;

            sinA0 = cosu1 * Math.Sin(A1);
            cotsigema1 = cosu1 * Math.Cos(A1) / sinu1;
            sigema1 = Math.Atan(1 / cotsigema1);

        }
    }
}
