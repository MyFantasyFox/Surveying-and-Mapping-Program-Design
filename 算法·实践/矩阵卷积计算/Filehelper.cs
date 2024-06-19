using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 矩阵卷积计算
{
    class Filehelper
    {
        public static List<double[]> Getmatrix(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                    List<double[]> M = new List<double[]>();
                    while (!reader.EndOfStream)
                    {
                        string Line = reader.ReadLine();
                        string[] data = Line.Split('	');
                        double[] data1 = new double[data.Length];
                        //当要定义一个转换类型的数组就可以用一个新的数组数组
                        //长度与第一个长度相等即可
                        for (int i = 0; i < data.Length; i++)
                        {
                            data1[i] = Convert.ToDouble(data[i]);
                        }
                        M.Add(data1);
                    }
                    return M;
            }
        }
    }
}
