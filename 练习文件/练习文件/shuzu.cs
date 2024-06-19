using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习文件
{
    class shuzu
    {
        public static void Shuzu1()
        {
            //数组及其方法
            //一维数组
            int[] a;     //定义数组
            a = new int[2]; //分配内存
            a[0] = 1; a[1] = 4;  //赋值

            //多维数组
            int[,] b = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            string[] str = new[] { "python", "C#", "C++", "java", "basic", "Fortran" };//定义一个数组
            Array.Sort(str);
            Console.WriteLine("{0,-10}{1,-10}", str[0]/*第一个元素*/, str[str.Length - 1]/*最后一个元素*/);
            //{}中的是占位符，-10表示至少占有10格位置，如有空缺就用空格补上
            string searchstr = "C#";
            int index = Array.BinarySearch(str, searchstr);//寻找searchstr在str中的索引找到就返回索引值，找不到就返回一个负数
            Array.Reverse(str);//只适用于一维数组用于把数组反向排列

            Console.WriteLine(index);
        }
    }
}
