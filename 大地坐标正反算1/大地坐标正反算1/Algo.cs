using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算1
{
    class Algo
    {
        /// <summary>
        /// 坐标正算
        /// </summary>
        /// <param name="basedatas">基本两点与大地线长度</param>
        public static  void zheng(Basedata basedatas)
        {
            Ellipse ell = basedatas.Ellipse;
            double B1 = tranred(basedatas.Pstart.B);
            double L1 = tranred(basedatas.Pstart.L);
            double A1 = tranred(basedatas.Pstart.A);
            double f = tranred(basedatas.Ellipse.f);
            double S = basedatas.S;
            double e2 = basedatas.Ellipse.e2;
            double e_2 = basedatas.Ellipse.e_2;


            double w1 = Math.Sqrt(1 - e2 * Math.Sin(B1) * Math.Sin(B1));
            double sinu1 = Math.Sin(B1) * Math.Sqrt(1 - e2) / w1;
            double cosu1 = Math.Cos(B1) / w1;
            double sinA0 = cosu1 * Math.Sin(A1);
            double cotsigem1 = cosu1 * Math.Cos(A1) / sinu1;
            double sigema1 = Math.Atan(1 / cotsigem1);
            ell.xishu(sinA0);
            double sigema = ell.A * S;
            double sigema0 = 0;
            int i = 0;

            do
            {
                sigema = sigema0;
                sigema0 = ell.A * S + ell.B * Math.Sin(sigema) * Math.Cos(2 * sigema1 + sigema) + ell.C * Math.Sin(2 * sigema) * Math.Cos(4 * sigema1 + 2 * sigema);
                i++;
            } while (Math.Abs(sigema - sigema0) > Math.Pow(10, -10));

            double yita = (ell.arfa * sigema + ell.beita * Math.Sin(sigema) * Math.Cos(2 * sigema1 + sigema) + ell.gama * Math.Sin(2 * sigema) * Math.Cos(4 * sigema1 + 2 * sigema)) * sinA0;
            double sinu2 = sinu1 * Math.Cos(sigema) + cosu1 * Math.Cos(A1) * Math.Sin(sigema);
            basedatas.pend.B = Math.Atan(sinu2 / (Math.Sqrt(1 - ell.e2) * Math.Sqrt(1 - sinu2 * sinu2)));

            double lamda = Math.Abs(Math.Atan(Math.Sin(A1) * Math.Sin(sigema) / (cosu1 * Math.Cos(sigema) - sinu1 * Math.Sin(sigema) * Math.Cos(A1))));

            if (Math.Sin(A1) > 0 && Math.Tan(lamda) < 0)
            {
                lamda = Math.PI - lamda;
            }
            else if(Math.Sin(A1) < 0 && Math.Tan(lamda) < 0)
            {
                lamda = -lamda;
            }
            else if (Math.Sin(A1) < 0 && Math.Tan(lamda) > 0)
            {
                lamda = lamda - Math.PI;
            }

            basedatas.pend.L = basedatas.Pstart.L + lamda - yita;
            basedatas.pend.A = Math.Atan(cosu1 * Math.Sin(A1) / (cosu1 * Math.Cos(sigema) * Math.Cos(A1) - sinu1 * Math.Sin(sigema)));
            if (Math.Sin(A1) < 0 && Math.Tan(basedatas.pend.A) > 0)
            {
                basedatas.pend.A = Math.Abs(basedatas.pend.A);
            }
            else if (Math.Sin(A1) < 0 && Math.Tan(basedatas.pend.A) < 0)
            {
                basedatas.pend.A =Math.PI - Math.Abs(basedatas.pend.A);
            }
            else if (Math.Sin(A1) > 0 && Math.Tan(basedatas.pend.A) > 0)
            {
                basedatas.pend.A = Math.Abs(basedatas.pend.A)+Math.PI;
            }
            else if (Math.Sin(A1) > 0 && Math.Tan(basedatas.pend.A) < 0)
            {
                basedatas.pend.A = 2 * Math.PI - Math.Abs(basedatas.pend.A);
            }
            if (basedatas.pend.A < 0)
            {
                basedatas.pend.A = basedatas.pend.A + 2 * Math.PI;
            }
            if (basedatas.pend.A > 2*Math.PI)
            {
                basedatas.pend.A = basedatas.pend.A - 2 * Math.PI;
            }

            basedatas.pend.B = trandfm(basedatas.pend.B);
            basedatas.pend.A = trandfm(basedatas.pend.A);

        }
        
        public static void FanSuan(Basedata basedata)
        {
            double u1, u2, l, B1, B2, L1, L2, e2, sinu1, sinu2, cosu1, cosu2, a1, a2, b1, b2;

            e2 = basedata.Ellipse.e2;
            B1 = tranred(basedata.Pstart.B);
            L1 = tranred(basedata.Pstart.L);
            B2 = tranred(basedata.pend.B);
            L2 = tranred(basedata.pend.L);
            u1 = Math.Atan(Math.Sqrt(1 - e2) * Math.Tan(B1));
            u2 = Math.Atan(Math.Sqrt(1 - e2) * Math.Tan(B2));

            l = L2 - L1;

            sinu1 = Math.Sin(u1);
            sinu2 = Math.Sin(u2);
            cosu1 = Math.Cos(u1);
            cosu2 = Math.Cos(u2);

            a1 = sinu1 * sinu2;
            a2 = cosu1 * cosu2;
            b1 = cosu1 * sinu2;
            b2 = sinu1 * cosu2;

            double sita = 0;
            double sita1 = 0;
            double lamda = l + sita;
            double A1 = 0;
            double sigema = 0;
            double sinA0 = 0;
            int i = 0;

            do
            {
                sita1 = sita;

                lamda = l + sita;
                double sinlamuda = Math.Sin(lamda);
                double coslamuda = Math.Cos(lamda);
                double p = cosu2 * sinlamuda;
                double q = b1 - b2 * coslamuda;
                A1 = Math.Abs(Math.Atan(p / q));

                if (p > 0 && q < 0)
                {
                    A1 = Math.PI - A1;
                }

                else if (p < 0 && q < 0)
                {
                    A1 = Math.PI + A1;
                }
                else if (p < 0 && q > 0)
                {
                    A1 = Math.PI * 2 - A1;
                }
                if (A1 < 0)
                {
                    A1 += Math.PI * 2;
                }
                if (A1 > Math.PI * 2)
                {
                    A1 = A1 - Math.PI * 2;
                }

                double sinA1 = Math.Sin(A1);
                double cosA1 = Math.Cos(A1);
                double sinsigema = p * sinA1 + q * cosA1;
                double cossingma = a1 + a2 * coslamuda;
                sigema = Math.Atan(sinsigema / cossingma);

                if (cossingma > 0)
                {
                    sigema = Math.Abs(sigema);
                }
                if (cossingma < 0)
                {
                    sigema = Math.PI - Math.Abs(sigema);
                }

                sinA0 = cosu1 * sinA1;
                basedata.Ellipse.xishu(sinA0);
                double sigema1 = Math.Atan(Math.Tan(u1) / cosA1);
                double arfa = basedata.Ellipse.arfa;
                double beita = basedata.Ellipse.beita;
                double gama = basedata.Ellipse.gama;

                sita = (arfa * sigema + beita * Math.Cos(2 * sigema1 + sigema) * Math.Sin(sigema) + gama * Math.Sin(2 * sigema) * Math.Cos(4 * sigema1 + 2 * sigema)) * sinA0;
                i++;
            } while (Math.Abs(sita - sita1) > Math.Pow(10, -10));
            
            
        }


        /// <summary>
        /// 度分秒转换为弧度制
        /// </summary>
        /// <param name="dfm"></param>
        public static double tranred(double dfm)
        {
            int i = 1;
            if (dfm < 0)
            {
                i = -1;
                dfm = -dfm;
            }

            double D = Math.Floor(dfm);
            double F = Math.Floor((dfm - D) * 100);
            double M = (((dfm - D) * 100) - F) * 100;

            return i*(D + F / 60 + M / 3600) * Math.PI / 180;
        }
        /// <summary>
        /// 弧度制转度分秒
        /// </summary>
        /// <param name="rad">弧度</param>
        /// <returns>度分秒</returns>
        public static double  trandfm(double rad)
        {
            int i = 1;
            if (rad < 0)
            {
                i = -1;
                rad = -rad;
            }
            double dfm = rad * 180 / Math.PI;

            double D = Math.Floor(dfm);
            double F = Math.Floor((dfm - D) * 60);
            double M = (((dfm - D) * 60) - F) * 60;

            return (D + F / 100 + M / 10000)*i;
        }
    }
}
