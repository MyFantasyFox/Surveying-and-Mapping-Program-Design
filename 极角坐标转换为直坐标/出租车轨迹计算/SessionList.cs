using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 出租车轨迹计算
{
    class SessionList
    {
        public List<Session> data = new List<Session>();
        public double TotalLength, DirctLength;

        public SessionList(List<epoch> epoches)
        {
            for (int i=0;i<epoches.Count-1;i++)
            {
                Session s = new Session(epoches[i], epoches[i + 1]);
                s.sn = i;
                data.Add(s);
            }
            GetdictLength(epoches);
            GetTotalLength();

        }
        private void GetdictLength(List<epoch> epoches)
        {
            int len = epoches.Count;
            Session s = new Session(epoches[0],epoches[len-1]);
            DirctLength = s.length;
        }
        private void GetTotalLength()
        {
            TotalLength = 0;
            foreach (Session s in data)
            {
                TotalLength += s.length;
            }
        }

        public override string ToString()
        {
            string line = "------------速度和方位角计算结果----------\r\n";
            foreach (var s in data)
            {
                string str = $"{s.sn},{s.StartMjd:f5}-{s.EndMjd:f5},{s.Velocity:f3},{s.Azimuth:f3}";
                line += str+"\r\n";
            }
            line += "------------距离计算结果-----------------\r\n";
            line += $"累积距离：{TotalLength:f3} (km)\r\n";
            line += $"首尾直线距离： {DirctLength:f3} (km)";

            return line;
        }
    }
}
