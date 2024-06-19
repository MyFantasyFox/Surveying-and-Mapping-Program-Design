using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 激光点云数据的平面分割
{
    class mian
    {
        public double A;
        public double B;
        public double C;
        public double D;

        public List<Point> pointin;
        public List<Point> pointout;
        public mian(double[] vs)
        {
            A = vs[0];
            B = vs[1];
            C = vs[2];
            D = vs[3];
        }
        public mian()
        {

        }
    }
}
