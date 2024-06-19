using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习文件
{
    class xunhaun
    {
        public static void Xunhuan1()
        {
            //循环
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
            }//for循环
            Console.WriteLine(sum);

            int j = 0;
            while (j < 101)
            {
                sum1 += j;
                j++;
            }//while循环
            Console.WriteLine(sum1);

            int s = 0;
            do
            {
                sum2 += s;
                s++;
            } while (s < 101);//do-while循环
            Console.WriteLine(sum2);
        }
    }
}
