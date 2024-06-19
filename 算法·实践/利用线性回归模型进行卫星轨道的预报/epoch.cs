using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用线性回归模型进行卫星轨道的预报
{
    class epoch
    {
        public int time;
        public double X;
        public double Y;
        public double Z;

        public void Parse(string Line)
        {
            string[] suf = Line.Split('，');
            time = Convert.ToInt32(suf[0]);
            X = Convert.ToDouble(suf[1]);
            Y = Convert.ToDouble(suf[2]);
            Z = Convert.ToDouble(suf[3]);
        }
    }
}
