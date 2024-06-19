using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 时间系统转换
{
    class Filehelper
    {
        public static List<time> Helper(string path)
        {
            List<time> data = new List<time>();
            using (StreamReader reader=new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string Line = reader.ReadLine();
                    time time = new time(Line);
                    data.Add(time);
                }
            }
            return data;
        }
    }
}
