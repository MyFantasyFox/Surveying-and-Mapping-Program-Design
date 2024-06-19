using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 出租车轨迹计算
{
    class Session
    {
        public int sn;
        public double StartMjd, EndMjd;
        public double length;
        public double Velocity, Azimuth;

        public Session(epoch start ,epoch end)
        {
            sn = 0;
            StartMjd = start.mjd;
            EndMjd = end.mjd;
            Getlength(start, end);
            Getvelocity();
            Getazimuth(start,end);
        }

        public void Getlength(epoch start ,epoch end)
        {
            double dx, dy;
            dx = end.x - start.x;
            dy = end.y - start.y;
            length = Math.Sqrt(dx*dx+dy*dy)/1000;//除以1000以千米为单位
        }
        private void Getvelocity()
        {
            double dt = (EndMjd - StartMjd)*24;
            Velocity = length / dt;
        }

        private void Getazimuth(epoch start ,epoch end)
        {
            double eps = 1e-5;
            double dx = end.x - start.x;
            double dy = end.y - start.y;
            if (Math.Abs(dx) < eps)
            {
                if (Math.Abs(dy) < eps)
                    Azimuth = 0;
                else if (dy > 0)
                    Azimuth = 0.5 * Math.PI;
                else
                {
                    Azimuth = 1.5 * Math.PI;
                }
            }
            else
            {
                Azimuth = Math.Atan2(dy, dx);
                if (dx < 0)
                {
                    Azimuth += Math.PI;
                }
            }
            if (Azimuth < 0)
            {
                Azimuth += 2 * Math.PI;
            }
            if (Azimuth > 2 * Math.PI)
            {
                Azimuth -= 2 * Math.PI;
            }
            Azimuth *= 180 / Math.PI;
        }

        public string Plus()
        {
            string Line = $"{sn:00},{StartMjd:f5}-{EndMjd:f5}";
            Line += $",{Velocity:f3},{Azimuth:f3}";
            return Line;
        }
    }
}
