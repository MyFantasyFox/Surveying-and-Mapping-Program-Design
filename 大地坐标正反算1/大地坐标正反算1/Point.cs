using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算1
{
    class Point
    {
        public string name;
        public double B;
        public double L;
        public double S;
        public double A;
        public Point(double A,double B,double L)
        {
            this.A = A;
            this.L = L;
            this.B = B;

        }
        public Point()
        {

        }
    }

    class Basedata
    {
        public Point Pstart;
        public Point pend;
        public double S;
        public Ellipse Ellipse;
        public Basedata(Ellipse ellipse)
        {
            this.Ellipse = ellipse;
        }
    }
}
