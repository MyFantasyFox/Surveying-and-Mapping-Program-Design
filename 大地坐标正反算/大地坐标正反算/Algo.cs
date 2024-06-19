using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 大地坐标正反算
{
    class Algo
    {
        public static List<Fansuan> Fan(List<string[]> vs, Form1 form1)
        {
            double a = Convert.ToDouble(vs[0][0]);
            double f = 1 / Convert.ToDouble(vs[0][1]);
            ellipse ellipse = new ellipse(a, f);
            form1.textBox1.Text = Convert.ToString(a);
            form1.textBox2.Text = Convert.ToString(ellipse.b);
            form1.textBox3.Text = vs[0][1];

            List<Fansuan> fansuans = new List<Fansuan>();
            for(int i = 0; i < vs.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    Fansuan fansuan = new Fansuan(vs[i], ellipse);
                    fansuans.Add(fansuan);
                }
                
            }

            return fansuans;
            
        }

        public static List<string[]> zheng(List<string[]> vs, Form1 form1)
        {
            double a = Convert.ToDouble(vs[0][0]);
            double f = 1 / Convert.ToDouble(vs[0][1]);
            ellipse ellipse = new ellipse(a, f);
            form1.textBox1.Text = Convert.ToString(a);
            form1.textBox2.Text = Convert.ToString(ellipse.b);
            form1.textBox3.Text = vs[0][1];

            List<string[]> tmp = new List<string[]>();

            for (int i = 0; i < vs.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    zhengsuan zhengsuan = new zhengsuan(vs[i], ellipse);
                    tmp.Add(Tostring.ToStr(zhengsuan));
                }
            }
            return tmp;
        }

            /// <summary>
            /// 度分秒转为弧度制
            /// </summary>
            /// <param name="angle">弧度制</param>
            /// <returns></returns>
            public static double transred(double angle)
            {
            int i = 1;
            if (angle < 0)
            {
                i = -1;
                angle = -angle;
            }
            double d = Math.Floor(angle);
            double f = Math.Floor((angle - d +5E-14 ) * 100);
            double m = (angle - d - f / 100) * 10000; 

            double D = d + f / 60 + m / 3600;
            return D * i * Math.PI / 180;
            }
        /// <summary>
        /// 弧度制转为度分秒
        /// </summary>
        /// <param name="Rad"></param>
        /// <returns></returns>
        public static double trandfm(double Rad)
        {
            int i = 1;
            if (Rad < 0)
            {
                Rad = -Rad;
                i = -1;
            }
            double angle = Rad * 180 / Math.PI;//使用公式后弧度制转换为度分秒，但是是十进制

            double D = Math.Floor(angle);    
            double F = Math.Floor((angle - D) * 60);
            double M = ((angle - D) * 60 - F) * 60;   //度分秒十进制再转换为度数形式

            return (D + F / 100.0 + M / 10000.0) * i;   //把度数转为DD.FFMM形式
        }
    }
}
