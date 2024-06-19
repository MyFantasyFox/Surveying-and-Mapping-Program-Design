using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 激光点云数据的平面分割
{
    class Algo
    {

        /// <summary>
        /// 判断点在哪一行，那一列
        /// </summary>
        /// <param name="points"></param>
        /// <param name="dy"></param>
        /// <returns></returns>
        public static List<Point> shangehua(List<Point> points,double dy)
        {
            foreach(var data in points)
            {
                data.i = Math.Floor(data.Y / dy);
                data.j = Math.Floor(data.X / dy);
            }
            return points;
        }

        #region
        /// <summary>
        /// 判断点是否在C中
        /// </summary>
        /// <param name="points">点集</param>
        /// <returns>平均高程，最高点，最低点</returns>
        public static double[] Height(List<Point> points)
        {
            List<Point> Cshan = new List<Point>();
            foreach(var point in points)
            {
                if (point.i == 2 && point.j == 3)
                {
                    Cshan.Add(point);
                }
            }
            double[] Averagr_H = AllHeight(Cshan);
            return Averagr_H;

        }

        /// <summary>
        /// 计算平均高度
        /// </summary>
        /// <param name="points">点集</param>
        /// <returns></returns>
        public static double[] AllHeight(List<Point> points)
        {
            double allzk =0;
            double[] Height =new double[3];
            for(int i = 0; i < points.Count; i++)
            {
                allzk += points[i].Z;
            }
            Height[0] = allzk / points.Count;
            //计算平均高程

            double zmax=int.MinValue, zmin=int.MaxValue; 
            foreach(var z in points)
            {
                if (z.Z > zmax)
                {
                    zmax = z.Z;
                }
                if (z.Z < zmin)
                {
                    zmin = z.Z;
                }
            }
            Height[1] = zmax - zmin;
            //最高点最低点和高差


            double up=0;
            for(int i = 0; i < points.Count; i++)
            {
                up += Math.Pow((points[i].Z - Height[1]), 2);
            }

            Height[2] = up / points.Count;
            //计算栅格单元的高度方差

            return Height;
        }
        #endregion

        /// <summary>
        /// 生成一个平面
        /// </summary>
        /// <param name="p1">点1</param>
        /// <param name="p2">点2</param>
        /// <param name="p3">点3</param>
        /// <returns>返回A,B,C,D</returns>
        public static double[] Nihe(Point p1, Point p2, Point p3)
        {
            double a = Sofpoint(p1, p2);
            double b = Sofpoint(p2, p3);
            double c = Sofpoint(p3, p1);
            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double[] data = { 0, 0, 0, 0 };

            if (S > 15)
            {
                
                data[0] = (p2.Y - p1.Y) * (p3.Z - p1.Z) - (p3.Y - p1.Y) * (p2.Z - p1.Z);
                data[1] = (p2.Z - p1.Z) * (p3.X - p1.X) - (p3.Z - p1.Z) * (p2.X - p1.X);
                data[2] = (p2.X - p1.X) * (p3.Y - p1.Y) - (p3.X - p1.X) * (p2.Y - p1.Y);
                data[3] = -data[0] * p1.X - data[1] * p1.Y - data[2] * p1.Z;

                data[0] = Convert.ToDouble(data[0].ToString("f6"));
                data[1] = Convert.ToDouble(data[1].ToString("f6"));
                data[2] = Convert.ToDouble(data[2].ToString("f6"));
                data[3] = Convert.ToDouble(data[3].ToString("f6"));

                return data;
            }
            return data;
        }

        /// <summary>
        /// 两点之间距离公式
        /// </summary>
        /// <param name="p1">起点</param>
        /// <param name="p2">终点</param>
        /// <returns>距离</returns>
        public static double Sofpoint(Point p1,Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double d = Math.Sqrt(dx * dx + dy * dy);
            return d;
        }

        /// <summary>
        /// 计算点到平面距离
        /// </summary>
        /// <param name="point">点</param>
        /// <param name="vs">平面方程系数</param>
        /// <returns>距离</returns>
        public static double PointtoS(Point point,double[] vs)
        {
            double d = 10;
            if (vs[0]==0&&vs[1]==0&&vs[2] == 0 && vs[3] == 0)
            {

            }
            double up = Math.Abs(vs[0] * point.X + vs[1] * point.Y + vs[2] * point.Z + vs[3]);
            double down = Math.Sqrt(vs[0] * vs[0] + vs[1] * vs[1] + vs[2] * vs[2]);
            d = up / down;
            return d;
        }

        public static List<double[]> diedai(List<Point> points,int n)
        {
            List<double[]> pingmian = new List<double[]>();
            int t = 0;
            //找最佳分割平面
            for (int i = 3; i < points.Count; i += 3)
            {
                double[] vs = Nihe(points[i], points[i + 1], points[i + 2]);
                pingmian.Add(vs);
                t++;
                if (t == n)
                {
                    break;
                }
            }
            return pingmian;
        }

        /// <summary>
        /// 寻找最佳分割平面
        /// </summary>
        /// <param name="points">点集</param>
        /// <returns>最佳平面J1</returns>
        public static double[] zuijiafen(List<Point> points,int n,string J,ref List<Point> pointin ,ref List<Point> pointout)
        {

            List<double[]> pingmian = diedai(points, n);
            
            double[] J1 = new double[4];
            
            foreach (double[] a in pingmian)
            {
                List<Point> pingin1 = new List<Point>();
                List<Point> pingout1 = new List<Point>();
                for (int i = 0; i < points.Count; i++)
                { 
                    double s = PointtoS(points[i], a);
                    if (s < 0.1)
                    {
                        pingin1.Add(points[i]);
                    }
                    else
                    {
                        pingout1.Add(points[i]);
                    }
                    
                }
                if (pingin1.Count > pointin.Count)
                {
                    pointin = pingin1;
                    pointout = pingout1;
                    for(int i = 0; i < pointin.Count; i++)
                    {
                        pointin[i].J = J;
                    }
                    for(int i = 0; i < pointout.Count; i++)
                    {
                        pointout[i].J = "0";
                    }
                    J1 = a;
                }
            }
            return J1;
        }

        public static void touying(ref Point point,double[] j)
        {
            double A = j[0];
            double B = j[1];
            double C = j[2];
            double D = j[3];
            double x0 = point.X;
            double y0 = point.Y;
            double z0 = point.Z;

            point.touying[0] = ((B * B + C * C) * x0 - A * (B * y0 + C * z0 + D)) / (A * A + B * B + C * C);
            point.touying[1] = ((A * A + C * C) * y0 - B * (A * x0 + C * z0 + D)) / (A * A + B * B + C * C);
            point.touying[2] = ((A * A + B * B) * z0 - C * (A * x0 + B * y0 + D)) / (A * A + B * B + C * C);
        }
    }
}
