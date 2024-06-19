using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 利用线性回归模型进行卫星轨道的预报
{
    class filehelper
    {
        public static List<epoch> filehelper2(string path)
        {
            List<epoch> epochlist = new List<epoch>();
            using (StreamReader reader=new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string Line = reader.ReadLine();
                    epoch ep = new epoch();
                    ep.Parse(Line);
                    epochlist.Add(ep);
                }
            }
            return epochlist;
        }
    }
}
