using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 出租车轨迹计算
{
    class duqu
    {
        public static List<epoch> Filenamehelp(string ID,string Filename)
        {
            var data = new List<epoch>();   
            try
            { 
                var reader = new StreamReader(Filename);
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string Line = reader.ReadLine();
                    if (Line.Length > 0)
                    {
                        var ep = new epoch();
                        ep.chaifen(Line);
                        data.Add(ep);
                    }
                }
                reader.Close();
            }
            catch
            {

            }
            return data;
        }
    }
}
