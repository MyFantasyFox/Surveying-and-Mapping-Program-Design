using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 轨迹压缩算法
{
    class Algo
    {
        /// <summary>
        /// 求直线函数
        /// </summary>
        /// <param name="a">第一个点</param>
        /// <param name="b">第二个点</param>
        /// <returns>返回函数A B C值</returns>
        public static double[] Gethanshu(Station a,Station b)
        {
            double[] da = new double[3];
            da[0] = a.y - b.y;    //一般方程的A
            da[1] = b.x - a.x;    //一般方程的B
            da[2] = a.x * b.y - a.y * b.x;    //一般方程的C
            return da;
        }
        /// <summary>
        /// 点到直线距离
        /// </summary>
        /// <param name="a">点</param>
        /// <param name="xian">直线</param>
        /// <returns>距离</returns>
        public static double Getlength(Station a,double[] xian)
        {
            double d = 0;
            double up = 0;
            double down = 0;
            up = Math.Abs(xian[0] * a.x + xian[1] * a.y + xian[2]);
            down = Math.Sqrt(xian[0] * xian[0] + xian[1] * xian[1]);
            return d = up / down;
        }

        
        public static void DP(double yuzhi,List<Station> a, List<Station> newlist)
        {
            a = a.OrderBy(c => c.x).ToList();   //对x进行排序
            double[] xian=Gethanshu(a[0], a[a.Count - 1]);    //求起点到终点直线的函数
            
            for (int i = 0; i < a.Count; i++)
            {
                a[i].d = Getlength(a[i], xian);
            }
            //求各点到直线距离
     

            double dmax = a.Max(t => t.d);
            //求最高点
            if (dmax < yuzhi)
            {
                newlist.Add(a[0]);
                newlist.Add(a[a.Count - 1]);
            }
            else
            {
                List<Station> left = new List<Station>();
                List<Station> right = new List<Station>();
                //Station max1 = new Station();
                int index = 0;
                for(int i = 0; i < a.Count; i++)
                {
                    if (a[i].d == dmax)
                    {
                        //max1 = a[i];
                        index = i;//找到索引
                    }
                }
                
                
                for (int i = 0; i < a.Count; i++)
                {
                    if (i <= index)
                    {
                        left.Add(a[i]);
                    }
                    //添加左列表
                    if (i >= index)
                    {
                        right.Add(a[i]);
                    }
                    //添加右列表
                }

                
                DP(yuzhi, left, newlist);
                DP(yuzhi, right, newlist);
            }
        }

        public static List<Station> remove(List<Station> newlist)
        {
            List<Station> data = new List<Station>();
            foreach(Station station in newlist)
            {
                if (!data.Contains(station))  
                //contains方法判断是否包含元素在列表中同样适用
                {
                    data.Add(station);
                }
            }
            return data;
        }
    }
}
