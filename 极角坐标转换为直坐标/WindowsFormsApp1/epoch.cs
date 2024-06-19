using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class epoch
    {
        public double time;
        public double x;
        public double y;
        public double z;

        public void parse(string line)
        {
            string[] suf = line.Split('，');
            time =Convert.ToDouble( suf[0]);

        }

       
    }
}
