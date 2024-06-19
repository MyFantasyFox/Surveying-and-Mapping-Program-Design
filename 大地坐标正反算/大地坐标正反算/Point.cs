using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算
{
    class Point
    {
        public string name;
        public double B;
        public double L;
        public double A;
        public Point(string a,double b,double c,double d)
        {
            name = a;
            B = b;
            L = c;
            A = d;
        }
        public Point()
        {

        }
    }

    class Fansuan
    {
        public Point startpoint=new Point();
        public Point endpoint=new Point();
        public double S;
        public double A1;
        public double A2;
        public Fansuan(string[] vs, ellipse ellipse)
        {
            startpoint.name = vs[0];
            startpoint.B = Algo.transred(Convert.ToDouble(vs[1]));
            startpoint.L = Algo.transred(Convert.ToDouble(vs[2]));
            endpoint.name = vs[3];
            endpoint.B = Algo.transred(Convert.ToDouble(vs[4]));
            endpoint.L = Algo.transred(Convert.ToDouble(vs[5]));
            //导入起始点和终点并把经纬度转换为弧度

            double u1 = Math.Atan(Math.Sqrt(1 - ellipse.e2) * Math.Tan(startpoint.B));
            double u2 = Math.Atan(Math.Sqrt(1 - ellipse.e2) * Math.Tan(endpoint.B));
            double l = endpoint.L - startpoint.L;
            //求出u1 ，u2，和l

            double a1 = Math.Sin(u1) * Math.Sin(u2);
            double a2 = Math.Cos(u1) * Math.Cos(u2);
            double b1 = Math.Cos(u1) * Math.Sin(u2);
            double b2 = Math.Sin(u1) * Math.Cos(u2);
            //求出a1,a2,b1,b2

            //一会可能会从这里开始循环
            
            double derta = 0;
            double lamuda = l + derta;
            double lamuda1 = lamuda;
            double   sigema, sA0, sigema1;
            do
            {
                lamuda = lamuda1;
                double p = Math.Cos(u2) * Math.Sin(lamuda);
                double q = b1 - b2 * Math.Cos(lamuda);
                A1 = Math.Abs(Math.Atan(p / q));


                if (p > 0 && q < 0)
                {
                    A1 = Math.PI - A1;
                }
                if (p < 0 && q < 0)
                {
                    A1 += Math.PI;
                }
                if (p < 0 && q > 0)
                {
                    A1 = Math.PI * 2 - A1;
                }
                //判断A1的值，类似于坐标方位角

                if (A1 < 0)
                {
                    A1 += Math.PI * 2;
                }
                if (A1 > Math.PI * 2)
                {
                    A1 -= Math.PI * 2;
                }

                double sinsigema = p * Math.Sin(A1) + q * Math.Cos(A1);
                double cossigeme = a1 + a2 * Math.Cos(lamuda);
                sigema = Math.Atan(sinsigema / cossigeme);

                if (cossigeme > 0)
                {
                    sigema = Math.Abs(sigema);
                }
                if (cossigeme < 0)
                {
                    sigema = Math.PI - Math.Abs(cossigeme);
                }

                sA0 = Math.Cos(u1) * Math.Sin(A1);
                sigema1 = Math.Atan(Math.Tan(u1) / Math.Cos(A1));
                ellipse.xishu(sA0);
                derta = (ellipse.arfa * sigema + ellipse.beta * Math.Cos(2 * sigema1 + sigema) * Math.Sin(sigema) + ellipse.gama * Math.Sin(2 * sigema) * Math.Cos(4 * sigema1 + 2 * sigema)) * sA0;
                lamuda1 = l + derta;
            } while (Math.Abs(lamuda - lamuda1) > Math.Pow(1.0, -10) || !(lamuda == lamuda1));

            //计算大地线长度
            double xs = ellipse.C * Math.Sin(2 * sigema) * Math.Cos(4 * sigema1 + 2 * sigema);
            S = (sigema - ellipse.B * Math.Sin(sigema) * Math.Cos(2 * sigema1 + sigema) - xs) / ellipse.A;

            //计算反方位角
            A2 = Math.Atan(Math.Cos(u1) * Math.Sin(lamuda) / (b1 * Math.Cos(lamuda) - b2));
            if (A2 < 0)
            {
                A2 += Math.PI * 2;
            }
            if (A2 > Math.PI * 2)
            {
                A2 -= Math.PI * 2;
            }
            if (A1 < Math.PI && A2 < Math.PI)
            {
                A2 += Math.PI;
            }
            if (A1 > Math.PI && A2 > Math.PI)
            {
                A2 += Math.PI;
            }
            
        }
    }
    class zhengsuan
    {
        public Point startpoint = new Point();
        public Point endpoint = new Point();
        public double S;
        public zhengsuan(string[] i, ellipse ep)
        {
            startpoint.name = i[0];
            startpoint.B = Algo.transred(Convert.ToDouble(i[1]));
            startpoint.L = Algo.transred(Convert.ToDouble(i[2]));
            startpoint.A = Algo.transred(Convert.ToDouble(i[3]));
            S = Convert.ToDouble(i[4]);
            endpoint.name = i[5];

            ep.zhengxishu(startpoint.B, startpoint.A);
            ep.xishu(ep.sinA0);

            //需要用到的变量
            double derta,sinu2,lamuda,sinA1,tan_lamuda,tan_A2;

            double sigema = ep.A * S;
            double sigema1 = 0;
            do
            {
                sigema1 = sigema;
                sigema = ep.A*S + ep.B * Math.Sin(sigema) * Math.Cos(2 * ep.sigema1 + sigema) + ep.C * Math.Sin(2 * sigema) * Math.Cos(4 * ep.sigema1 + 2 * sigema);
            } while (Math.Abs(sigema - sigema1) >= Math.Pow(10, -10));

            //计算经度改正数
            derta = (ep.arfa * sigema + ep.beta * Math.Sin(sigema) * Math.Cos(2 * ep.sigema1 + sigema) + ep.gama * Math.Sin(2 * sigema) * Math.Cos(4 * ep.sigema1 + 2 * sigema)) * ep.sinA0;

            sinu2 = ep.sinu1 * Math.Cos(sigema) + ep.cosu1 * Math.Cos(startpoint.A) * Math.Sin(sigema);
            endpoint.B = Math.Atan(sinu2 / (Math.Sqrt(1 - ep.e2) * Math.Sqrt(1 - sinu2 * sinu2)));
            lamuda = Math.Atan(Math.Sin(startpoint.A) * Math.Sin(sigema) / (ep.cosu1 * Math.Cos(sigema) - ep.sinu1 * Math.Sin(sigema) * Math.Cos(startpoint.A)));

            sinA1 = Math.Sin(startpoint.A);
            tan_lamuda = Math.Tan(lamuda);
            if (sinA1 > 0 && tan_lamuda > 0)
            {
                lamuda = Math.Abs(lamuda);
            }
            if (sinA1 > 0 && tan_lamuda < 0)
            {
                lamuda = Math.PI - Math.Abs(lamuda);
            }
            if (sinA1 < 0 && tan_lamuda < 0)
            {
                lamuda = -Math.Abs(lamuda);
            }
            if (sinA1 < 0 && tan_lamuda > 0)
            {
                lamuda = Math.Abs(lamuda) - Math.PI;
            }

            endpoint.L = startpoint.L + lamuda - derta;
            endpoint.A = Math.Atan(ep.cosu1 * sinA1 / (ep.cosu1 * Math.Cos(sigema) * Math.Cos(startpoint.A) - ep.sinu1 * Math.Sin(sigema)));

            tan_A2 = Math.Tan(endpoint.A);
            if (sinA1 < 0 && tan_A2 > 0)
            {
                endpoint.A = Math.Abs(endpoint.A);
            }
            if (sinA1 < 0 && tan_A2 < 0)
            {
                endpoint.A = Math.PI - Math.Abs(endpoint.A);
            }
            if (sinA1 > 0 && tan_A2 > 0)
            {
                endpoint.A = Math.PI + Math.Abs(endpoint.A);
            }
            if (sinA1 > 0 && tan_A2 < 0)
            {
                endpoint.A = 2 * Math.PI - Math.Abs(endpoint.A);
            }

            if (endpoint.A < 0)
            {
                endpoint.A += 2 * Math.PI;
            }
            if (endpoint.A > 2 * Math.PI)
            {
                endpoint.A = endpoint.A - 2 * Math.PI;
            }
        }
    }
}
