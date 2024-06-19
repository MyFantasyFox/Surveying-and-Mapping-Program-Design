using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 矩阵卷积计算
{
    class ALGO
    {
        /// <summary>
        /// 算法1
        /// </summary>
        /// <param name="M">M数组</param>
        /// <param name="N">N数组</param>
        /// <returns>返回卷积后的二维数组，需转为字符串才能输出</returns>
        public static double[,] Algo1(List<double[]> M,List<double[]> N)
        {
            double[,] N1 = new double[N.Count, N[0].Length];
            for (int I = 0; I < N.Count; I++)
            {                
                for (int J=0; J < N[0].Length; J++)
                {
                    double up = 0;
                    double down = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (I - i - 1 < 0 || J - j - 1 < 0 || I - i - 1 > 9 || J - j - 1 > 9)
                            {
                                continue;
                            }
                            else
                            {
                                up += M[i][j] * N[I - i - 1][J - j - 1];
                                down += M[i][j];
                            }
                            
                        }
                    }
                    N1[I,J] = up / down;
                }
            }
            return N1;
        }

        public static double[,] Algo2(List<double[]> M, List<double[]> N)
        {
            double[,] N1 = new double[N.Count, N[0].Length];
            for (int I = 0; I < N.Count; I++)
            {
                for (int J = 0; J < N[0].Length; J++)
                {
                    double up = 0;
                    double down = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (I - i - 1 < 0 || J - j - 1 < 0 || I - i - 1 > 9 || J - j - 1 > 9)
                            {
                                continue;
                            }
                            else
                            {
                                up += M[i][j] * N[9 - (I - i - 1)][9 - (J - j - 1)];
                                down += M[i][j];
                            }
                        }
                    }
                    N1[I, J] = up / down;
                }
            }
            return N1;
        }


        public static string Getstring(double[,] N)
        {
            int lie = N.GetLength(1);//获取二维数组列数
            int hang = N.GetLength(0);//获取二维数组行数
            string data = "";
            for(int i = 0; i < hang; i++)
            {
                for (int j = 0; j < lie; j++)
                {
                    data +=$"{ N[i, j]:f2}"+ "\t";
                }
                data += "\r\n";
            }
            return data;
        }
    }
}
