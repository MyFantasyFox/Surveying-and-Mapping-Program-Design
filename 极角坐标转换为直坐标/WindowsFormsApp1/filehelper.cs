using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class filehelper
    {
        public static List<epoch> a(string path)
        {

            List<epoch> h = new List<epoch>();
            using (StreamReader sr =new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string data = "";
                    data = sr.ReadLine();
                    epoch epoch = new epoch();
                    epoch.parse(data);
                    h.Add(epoch);
                }
            }
            return h;
        }
    }
}
