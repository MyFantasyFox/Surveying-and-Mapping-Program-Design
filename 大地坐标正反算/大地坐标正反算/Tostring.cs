using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大地坐标正反算
{
    class Tostring
    {
        public static string[] ToStr(Fansuan fansuan)
        {
            fansuan.startpoint.B = Algo.trandfm(fansuan.startpoint.B);
            fansuan.startpoint.L = Algo.trandfm(fansuan.startpoint.L);
            fansuan.A1 = Algo.trandfm(fansuan.A1);
            fansuan.endpoint.B = Algo.trandfm(fansuan.endpoint.B);
            fansuan.endpoint.L = Algo.trandfm(fansuan.endpoint.L);
            fansuan.A2 = Algo.trandfm(fansuan.A2);
            string[] tmp=new string[9];
            tmp[0] = fansuan.startpoint.name;
            tmp[1] = Convert.ToString(fansuan.startpoint.B);
            tmp[2] = Convert.ToString(fansuan.startpoint.L);
            tmp[3] = Convert.ToString(fansuan.A1);
            tmp[4] = fansuan.endpoint.name;
            tmp[5] = Convert.ToString(fansuan.endpoint.B);
            tmp[6] = Convert.ToString(fansuan.endpoint.L);
            tmp[7] = Convert.ToString(fansuan.A2);
            tmp[8] = Convert.ToString(fansuan.S);
            return tmp;
        }

        public static string[] ToStr(zhengsuan fansuan)
        {
            fansuan.startpoint.B = Algo.trandfm(fansuan.startpoint.B);
            fansuan.startpoint.L = Algo.trandfm(fansuan.startpoint.L);
            fansuan.startpoint.A = Algo.trandfm(fansuan.startpoint.A);
            fansuan.endpoint.B = Algo.trandfm(fansuan.endpoint.B);
            fansuan.endpoint.L = Algo.trandfm(fansuan.endpoint.L);
            fansuan.endpoint.A = Algo.trandfm(fansuan.endpoint.A);
            string[] tmp = new string[9];
            tmp[0] = fansuan.startpoint.name;
            tmp[1] = Convert.ToString(fansuan.startpoint.B);
            tmp[2] = Convert.ToString(fansuan.startpoint.L);
            tmp[3] = Convert.ToString(fansuan.startpoint.A);
            tmp[4] = fansuan.endpoint.name;
            tmp[5] = Convert.ToString(fansuan.endpoint.B);
            tmp[6] = Convert.ToString(fansuan.endpoint.L);
            tmp[7] = Convert.ToString(fansuan.endpoint.A);
            tmp[8] = Convert.ToString(fansuan.S);
            return tmp;
        }
    }
}
