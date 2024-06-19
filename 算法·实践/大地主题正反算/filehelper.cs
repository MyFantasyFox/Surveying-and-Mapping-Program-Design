using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 大地主题正反算
{
    class filehelper
    {
        public static void Getfan(string data)
        {
            List<Basedata> fan = new List<Basedata>();
            using (StreamReader reader=new StreamReader(data))
            {
                string[] Line = reader.ReadLine().Split(',');
                double a = Convert.ToDouble(Line[0]);
                double b = Convert.ToDouble(Line[1]);
                double[] ji = jiben.Getcanshu(a, b);
                List<point> points = new List<point>();
                while (!reader.EndOfStream)
                {
                    string[] vs = reader.ReadLine().Split(',');
                    double B1 = Convert.ToDouble(vs[1]);
                    double L1 = Convert.ToDouble(vs[2]);
                    point point1 = new point(vs[0], B1, L1);

                    double B2 = Convert.ToDouble(vs[5]);
                    double L2 = Convert.ToDouble(vs[4]);
                    point point2 = new point(vs[3], B2, L2);
                    Basedata basedata = new Basedata();
                    basedata.startpoint = point1;
                    basedata.endpoint = point2;
                    fan.Add(basedata);
                }
                Algo.Getfan(fan, ji);
            }
        }
    }
}
