using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 轨迹压缩算法
{
    class filehelper
    {
        string path = "";
        public filehelper(string path)
        {
            this.path = path;
        }

        public static List<Station> Path(string path)
        {
            List<Station> data = new List<Station>();
            using (StreamReader reader =new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string Line = reader.ReadLine();
                    Station station = new Station();
                    station.Parse(Line);
                    data.Add(station);
                }
            }
            return data;
        }
    }
}
