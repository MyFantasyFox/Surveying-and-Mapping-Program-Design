using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地主题正反算
{
    class jiben
    {
        public static double[] Getcanshu(double a,double b)
        {
            double[] data = new double[3];
            data[0]  = (a - b) / (a);
            //扁率
            data[1] = (a * a - b * b) / (a * a);
            //第一偏心率的平方
            data[2] = data[1] / (1 - data[1]);
            //第二偏心率的平方
            return data;
        }
    }
}
