using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 对流层改正计算
{
    class Filehelper
    {
        public static List<station> Getdata(string path)
        {
            List<station> stations = new List<station>();
            using (StreamReader SR=new StreamReader(path))
            {
                SR.ReadLine();
                while (!SR.EndOfStream)
                {
                    string Line = SR.ReadLine();
                    station station = new station(Line);
                    stations.Add(station);
                }
            }
            return stations;
        }
    }
}
