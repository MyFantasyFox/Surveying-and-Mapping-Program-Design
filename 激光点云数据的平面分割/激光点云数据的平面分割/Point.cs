using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 激光点云数据的平面分割
{
    class Point
    {
        public string name;
        public double X;
        public double Y;
        public double Z;
        public double i;
        public double j;
        public string J="0";
        public double[] touying=new double[3];

        public Point(string path)
        {
            string[] data = path.Split(',');
            name = data[0];
            X = Convert.ToDouble(data[1]);
            Y = Convert.ToDouble(data[2]);
            Z = Convert.ToDouble(data[3]);
        }
        public Point()
        {

        }
    }
}
