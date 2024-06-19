using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地主题正反算
{
    class point
    {
        public string name;
        public double B;
        public double L;
        public double H;
        public point(string name,double B,double L)
        {
            this.B = B;
            this.L = L;
            this.name = name;
        }
    }

    class Basedata
    {
        public point startpoint;
        public point endpoint;
        public double length;
    }
}
