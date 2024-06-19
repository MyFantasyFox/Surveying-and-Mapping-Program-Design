using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电离层改正计算
{
    class point
    {
        public string name;
        public double X;
        public double Y;
        public double Z;
        public double H_angle;
        public double F_angle;
        

        public point(string Line)
        {
            string[] suf = Line.Split(' ');
            name = suf[0];
            X = Convert.ToDouble(suf[1]);
            Y = Convert.ToDouble(suf[2]);
            Z = Convert.ToDouble(suf[3]);

        }
        public point()
        {

        }
    }
}
