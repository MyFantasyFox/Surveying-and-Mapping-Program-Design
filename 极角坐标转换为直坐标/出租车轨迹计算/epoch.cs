using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 出租车轨迹计算
{
    class epoch
    {
        public string ID;
        public int state;
        public string time;
        public double x;
        public double y;
        public double mjd;

        public void chaifen(string a)
        {
            try
            {
                string[] suf = a.Split(',');
                ID = suf[0];
                state = Convert.ToInt32(suf[1]);
                time = suf[2]; 
                x = Convert.ToDouble(suf[3]);
                y = Convert.ToDouble(suf[4]);

                Getjmd();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
      
        private void Getjmd()
        {
            try
            {
                int timeZone = 8;
                int year = Convert.ToInt32(time.Substring(0, 4));
                int month = Convert.ToInt32(time.Substring(4, 2));
                int day = Convert.ToInt32(time.Substring(6, 2));
                int hour = Convert.ToInt32(time.Substring(8, 2));
                int min = Convert.ToInt32(time.Substring(10, 2));
                int sec = Convert.ToInt32(time.Substring(12, 2));

                mjd=MJD.MJD1(year,month,day, hour,min,sec,timeZone);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
