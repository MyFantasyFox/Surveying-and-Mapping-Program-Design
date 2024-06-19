using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反距离加权值
{
    class interpoint
    {
        public string name;
        public double x;
        public double y;
        public double h;
        public List<station> a = new List<station>();
        public interpoint(string name ,double x, double y, List<station> sta,int n)
        {
            this.name = name;
            this.x = x;
            this.y = y;

            for(int i = 0; i < sta.Count; i++)
            {
                sta[i].S = gongshi.Getlength(x, y,sta[i].x, sta[i].y);
            }
            
            sta = sta.OrderBy(a => a.S).ToList();  

            double up = 0;
            double down = 0;
            for(int j = 0; j < n; j++)
            {
                station station = sta[j].Clone();//???
                a.Add(station);
                up += sta[j].h / sta[j].S;
                down += 1 / sta[j].S;
            }
            h = up / down;
        }
    }
}
