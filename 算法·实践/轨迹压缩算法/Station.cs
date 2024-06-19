using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 轨迹压缩算法
{
    class Station
    {
        public string name="";
        public double x = 0;
        public double y = 0;
        public double d = 0;

        public void Parse(string Line)
        {
            string[] data = Line.Split('，');
            name = data[0];
            x = Convert.ToDouble(data[1]);
            y = Convert.ToDouble(data[2]);

        }

    }
}
