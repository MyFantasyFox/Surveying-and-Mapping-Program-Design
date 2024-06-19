using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 激光点云数据的平面分割
{
    class Filerhelper
    {
        public List<Point> points = new List<Point>();
        public string allpoint = "";
        public Filerhelper(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                allpoint = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string Line = "";
                    Line = reader.ReadLine();
                    Point point = new Point(Line);
                    points.Add(point);
                }
            }
        }
    }
}
