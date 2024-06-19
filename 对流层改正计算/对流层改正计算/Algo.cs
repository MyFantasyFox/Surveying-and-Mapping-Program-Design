using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对流层改正计算
{
    class Algo
    {
        #region //湿分量计算
        public static double shifenliang(station station)
        {
            double Al = station.Angle * Math.PI / 180;
            double SinE = Math.Sin(Al);
            List<double[]> pavg = Data.vs();
            double aw = shifenliangxishu(station.L, pavg, 1);
            double bw = shifenliangxishu(station.L, pavg, 2);
            double cw = shifenliangxishu(station.L, pavg, 3);

            double up = 1 + aw / (1 + bw / (1 + cw));
            double down = SinE + aw / (SinE + bw / (SinE + cw));
            double mw = up / down;
            return mw;
        }

        public static double shifenliangxishu(double L,List<double[]> data,int number)
        {
            double p = 0;
            if (L < 15)
            {
                p = data[0][number];
                return p;
            }
            if (L > 75)
            {
                p = data[4][number];
                return p;
            }
            //判断L的值确定p是否要直接赋值

            double fai_i = 0;
            double fai_i1 = 0;
            double fai_i_Pavg = 0;
            double fai_i1_Pavg = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (L > data[i][0] && L < data[i+1][0])
                {
                    fai_i = data[i][0];
                    fai_i1 = data[i + 1][0];
                    fai_i_Pavg = data[i][number];
                    fai_i1_Pavg = data[i + 1][number];
                    break;
                }
            }
            //确定L在那两个fai值之间

            p = fai_i_Pavg + (fai_i1_Pavg - fai_i_Pavg) * (L - fai_i) / (fai_i1 - fai_i);

            return p;
        }
        #endregion
        #region //干分量计算
        public static double Ganfenliang(station station)
        {
            double Al = station.Angle * Math.PI / 180;
            double sinE = Math.Sin(Al);
            List<double[]> pavg = Data.Pavg();
            List<double[]> pamp = Data.Pamp();

            double ad = Ganfenliangxishu(station.L, station.doy, pavg, pamp, 1);
            double bd = Ganfenliangxishu(station.L, station.doy, pavg, pamp, 2);
            double cd = Ganfenliangxishu(station.L, station.doy, pavg, pamp, 3);
            double aht = 2.53 * Math.Pow(10, -5);
            double bht = 5.49 * Math.Pow(10, -3);
            double cht = 1.14 * Math.Pow(10, -3);

            double up = 1 + ad / (1 + bd / (1 + cd));
            double down = sinE + ad / (sinE + bd / (sinE + cd));
            double up1 = 1 + aht / (1 + bht / (1 + cht));
            double down1 = sinE + aht / (sinE + bht / (sinE + cht));
            
            double result = up / down + ((1 / sinE) - (up1 / down1)) * (station.H / 1000);

            return result;
        }

        public static double Ganfenliangxishu(double L,double doy ,List<double[]> vs,List<double[]> pamp,int n)
        {
            double p = 0;
            if (L < 15)
            {
                p = vs[0][n] + vs[0][n] * Math.Cos(2 * Math.PI * (doy - 28) / 365.25);
                return p;
            }
            if (L > 75)
            {
                p = vs[4][n] + vs[4][n] * Math.Cos(2 * Math.PI * (doy - 28) / 365.25);
                return p;
            }

            double fai_i = 0;
            double fai_i1 = 0;
            double faipavg = 0;
            double fai1pavg = 0;
            double faipamp = 0;
            double faipamp1 = 0;

            for(int i = 0; i < vs.Count; i++)
            {
                if (L > vs[i][0] && L < vs[i + 1][0])
                {
                    fai_i = vs[i][0];
                    fai_i1 = vs[i + 1][0];
                    faipavg = vs[i][n];
                    fai1pavg = vs[i + 1][n];
                    faipamp = pamp[i][n];
                    faipamp1 = pamp[i + 1][n];
                    break;
                }
            }

            p = faipavg + (fai1pavg - faipavg) * (L - fai_i) / (fai_i1 - fai_i);
            p -= (faipamp + (faipamp1 - faipamp) * (L - fai_i) / (fai_i1 - fai_i)) * Math.Cos(2 * Math.PI * (doy + 1 - 28) / 365.25);

            return p;
        }
        #endregion
    }
}
