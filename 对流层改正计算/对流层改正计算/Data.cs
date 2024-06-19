using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对流层改正计算
{
    class Data
    {
        public static List<double[]> vs()
        {
            List<double[]> Vs = new List<double[]>();
            double[] vs1 = { 15, 0.00058021897, 0.0014275268, 0.043472961 };
            double[] vs2 = { 30, 0.00056794847, 0.0015138625, 0.046729510 };
            double[] vs3 = { 45, 0.00058118019, 0.0014572752, 0.043908931 };
            double[] vs4 = { 60, 0.00059727542, 0.0015007428, 0.044626982 };
            double[] vs5 = { 75, 0.00061641693, 0.0017599082, 0.054736038 };
            Vs.Add(vs1);
            Vs.Add(vs2);
            Vs.Add(vs3);
            Vs.Add(vs4);
            Vs.Add(vs5);
            return Vs;
        }
        public static List<double[]> Pavg()
        {
            return new List<double[]>
            {
            new double[] { 15, 0.0012769934, 0.0029153695, 0.062610505 },
            new double[] { 30, 0.0012683230, 0.0029152299, 0.062837393 },
            new double[] { 45, 0.0012465397, 0.0029288445, 0.063721774 },
            new double[] { 60, 0.0012196049, 0.0029022565, 0.063824265 },
            new double[] { 75, 0.0012045996, 0.0029024912, 0.064258455 },
            };

        }

        public static List<double[]> Pamp()
        {
            return new List<double[]>
            {
            new double[] { 15, 0.0, 0.0, 0.0},
            new double[] {30,0.000012709626,0.000021414979,0.000090128400},
            new double[] {45,0.000026523662,0.000030160779,0.000043497037},
            new double[] {60,0.000034000452,0.000072562722,0.00084795348},
            new double[] {75,0.000041202191,0.00011723375,0.0017037206},
            };

        }
    }
}
