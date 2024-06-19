using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace 电离层改正计算
{
    class filerhelper
    {
        public static List<point> Getdiandata(string path,ref double[] time)
        {
            List<point> points = new List<point>();
            using (StreamReader Sr =new StreamReader(path))
            {
                string str= Sr.ReadLine().Replace('*',' ');
                str = Regex.Replace(str, @"\s+", " ");
                string[] vs = str.Split(' ');
                time[0] = Convert.ToDouble(vs[1]);
                time[1] = Convert.ToDouble(vs[2]);
                time[2] = Convert.ToDouble(vs[3]);
                time[3] = Convert.ToDouble(vs[4]);
                time[4] = Convert.ToDouble(vs[5]);
                time[5] = Convert.ToDouble(vs[6]);

                while (!Sr.EndOfStream)
                {
                    string Line = Sr.ReadLine();
                    Line = Regex.Replace(Line, @"\s+", " ");
                    point point = new point(Line);
                    points.Add(point);
                }
            }
            return points;
        }
    }
}
