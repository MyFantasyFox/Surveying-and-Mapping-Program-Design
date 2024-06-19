using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算1
{
    class Ellipse
    {
        public double f;
        public double a;
        public double b;
        public double e2;
        public double e_2;

        public double cos2A0, k2, A, B, C, arfa, beita, gama;
        public Ellipse(double a,double f)
        {
            this.f = Math.Pow(f, -1);
            this.a = a;
            xishu();
        }

        public void xishu()
        {
            b = a - f * a;
            e2 = (a * a - b * b) / (a * a);
            e_2 = e2 / (1 - e2);

        }
        public  void xishu(double sinA0)
        {
            cos2A0 = 1 - sinA0 * sinA0;
            k2 = e_2 * cos2A0;
            A = (1 - k2 / 4 + 7 * k2 * k2 / 64 - 15 * k2 * k2 * k2 / 256) / b;
            B = (k2 / 4 - k2 * k2 / 8 + 37 * k2 * k2 * k2 / 512);
            C = (k2 * k2 / 128 - k2 * k2 * k2 / 128);
            arfa = (e2 / 2 + e2 * e2 / 8 + e2 * e2 * e2 / 16) - (e2 * e2 / 16 + e2 * e2 * e2 / 16) * cos2A0 + (3 * e2 * e2 * e2 / 128) * (cos2A0 * cos2A0);
            beita = (e2 * e2 / 16 + e2 * e2 * e2 / 16) * cos2A0 - (e2 * e2 * e2 / 32) * cos2A0 * cos2A0;
            gama = (e2 * e2 * e2 / 256) * cos2A0 * cos2A0;
        }
    }
}
