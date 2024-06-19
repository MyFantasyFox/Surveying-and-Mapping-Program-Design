using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间系统转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<time>  data1 = new List<time>();
        List<double[]> day = new List<double[]>();
        List<int> dayofyear = new List<int>();
        //!!!!!空列表不能直接赋值必须使用add（）方法
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = windows.FileName;
                data1 = Filehelper.Helper(path);
                for(int i = 0; i < data1.Count; i++)
                {
                    double[] tmp = Algo.Get_time(data1[i].mjd);
                    day.Add(tmp);
                }

                for(int i = 0; i < data1.Count; i++)
                {
                    int day1 = 0;
                    day1 = Algo.year_of_day(data1[i]);
                    dayofyear.Add(day1);

                    DateTime dateTime = new DateTime(2016, 1, 1);
                    Algo.shaiwang(dateTime, data1[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "";
            data += "儒略日形式"+"\r\n";
            for(int i=0; i < data1.Count; i++)
            { 
                data += $"{data1[i].mjd:f4}" + "\r\n"; 
                //这里可以不用转为字符串，直接用变量加到字符串上
            }

            data += "公历" + "\r\n";
            for (int i = 0; i < data1.Count; i++)
            {
                data += $"公历{day[i][2]:f3}年，{day[i][1]:f3}月，{day[i][0]:f3}日"+"\r\n";
            }

            data += "年积日" + "\r\n";
            for (int i = 0; i < data1.Count; i++)
            {
                int nianji = Algo.year_of_day(data1[i]);
                data += $"{nianji}" + "\r\n";
            }

            data += "打鱼日还是晒网日" + "\r\n";
            for (int i = 0; i < data1.Count; i++)
            {
                DateTime dateTime = new DateTime(2016, 1, 1);
                Algo.shaiwang(dateTime, data1[i]);
                if (data1[i].shaiwang == true)
                {
                    data += "打鱼日"+"\r\n";
                }
                else
                {
                    data += "晒网日"+"\r\n";
                }
            }
            textBox1.Text = data;
        }
    }
}
