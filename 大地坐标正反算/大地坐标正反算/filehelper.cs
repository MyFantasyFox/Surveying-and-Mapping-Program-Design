using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 大地坐标正反算
{
    class filehelper
    {
        public static List<string[]> Read(string path)
        {
            List<string[]> vs = new List<string[]>();
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] tmp = reader.ReadLine().Split(',');
                    vs.Add(tmp);
                }
            }
            return vs;
        }
    }
}
