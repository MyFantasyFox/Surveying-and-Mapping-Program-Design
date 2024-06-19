using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用线性回归模型进行卫星轨道的预报
{
    class Algo
    {
        public static double[] Getxishu(List<int> time,List<double> v)
        {
            double a = 0;
            double b = 0;
            for(int i = 0; i < time.Count; i++)
            {
                a += time[i];
                b += v[i];
            }
            double timejun = a / time.Count;
            double vjun = b / time.Count;

            double up = 0;
            double down = 0;
            double[] beta = new double[2];
            for (int j = 0; j < time.Count; j++)
            {
                up += (time[j] - timejun) * (v[j] - vjun);
                down += (time[j] - timejun) * (time[j] - timejun);
            }
            beta[0] = up / down;
            beta[1] = vjun - beta[0] * timejun;
            return beta;
        }

        public static double[] Getyuce(double[] x,double[] y,double[] z,int t)
        {
            double[] data = new double[3];
            data[0] = x[1] + x[0] * t;
            data[1] = y[1] + y[0] * t;
            data[2] = z[1] + z[0] * t;
            return data;
        }
    }
}
