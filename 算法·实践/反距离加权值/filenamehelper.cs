using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 反距离加权值
{
    class filenamehelper
    {
        public static List<station> duqu(string filename)
        {
            var list = new List<station>();
            using (StreamReader SR = new StreamReader(filename))
                //使用streamreader来读取文件
            {
                while (!SR.EndOfStream)
                {
                    string str=SR.ReadLine();
                    station sta = new station();
                    sta.Parse(str);
                    list.Add(sta);
                }
            }
            return list;
        }
    }
}
