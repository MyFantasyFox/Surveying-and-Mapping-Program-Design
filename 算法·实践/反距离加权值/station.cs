using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反距离加权值
{
    class station
    {
        public string name;
        public double x;
        public double y;
        public double h;
        public double S;
        public  void Parse(string data)
        {
            string[] str = data.Split(',');
            name = str[0];
            x = Convert.ToDouble(str[1]);
            y = Convert.ToDouble(str[2]);
            h = Convert.ToDouble(str[3]);
        }
        public station Clone()
        {
            return (station)this.MemberwiseClone();
        }
    }
}
