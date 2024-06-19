using System;
using System.Linq;

namespace 练习文件555
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] vs = { 1, 2, 3, 4, 5 };
            var str = vs.Where(a => a == 1);

            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
