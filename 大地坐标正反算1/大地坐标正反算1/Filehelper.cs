using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 大地坐标正反算1
{
    class Filehelper
    {
        public static List<Basedata> Getzheng(string path)

        {
            List<Basedata> basedatas = new List<Basedata>();
            using (StreamReader Sr=new StreamReader(path))
            {
                string[] suf = Sr.ReadLine().Split(',');
                double a = double.Parse(suf[0]);
                double f = double.Parse(suf[1]);
                Ellipse ellipse = new Ellipse(a, f);
                while (!Sr.EndOfStream)
                {
                    Basedata basedata = new Basedata(ellipse);
                    string[] vs = Sr.ReadLine().Split(',');
                    Point point1 = new Point();
                    point1.name = vs[0];
                    point1.B = Convert.ToDouble(vs[1]);
                    point1.L = Convert.ToDouble(vs[2]);
                    point1.A = Convert.ToDouble(vs[3]);
                    basedata.S = Convert.ToDouble(vs[4]);
                    Point point2 = new Point();
                    point2.name = vs[5];
                    basedata.Pstart = point1;
                    basedata.pend = point2;
                    basedatas.Add(basedata);
                }
            }
            return basedatas;
        }

        public static List<Basedata> Getfan(string path)
        {
            
            List<Basedata> basedatas = new List<Basedata>();
            using (StreamReader SR = new StreamReader(path))
            {
                string[] suf = SR.ReadLine().Split(',');
                double a = Convert.ToDouble(suf[0]);
                double f = Convert.ToDouble(suf[1]);
                Ellipse ellipse = new Ellipse(a,f);
                while (!SR.EndOfStream)
                {
                    string[] str = SR.ReadLine().Split(',');
                    Basedata basedata1 = new Basedata(ellipse);
                    Point point1 = new Point();
                    point1.name = str[0];
                    point1.B = Convert.ToDouble(str[1]);
                    point1.L = Convert.ToDouble(str[2]);
                    Point point2 = new Point();
                    point2.name = str[3];
                    point2.B = Convert.ToDouble(str[4]);
                    point2.L = Convert.ToDouble(str[5]);

                    basedata1.Pstart = point1;
                    basedata1.pend = point2;
                    basedatas.Add(basedata1);
                }
                
            }
            return basedatas;
        }
    }
}
