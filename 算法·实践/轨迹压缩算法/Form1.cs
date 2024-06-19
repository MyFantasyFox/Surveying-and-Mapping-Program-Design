using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 轨迹压缩算法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Station> data = new List<Station>();
        double[] xian = new double[2];
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = windows.FileName;
                data=filehelper.Path(filename);
                xian = Algo.Gethanshu(data[0], data[data.Count - 1]);
                for(int i = 0; i < data.Count; i++)
                {
                    data[i].d=Algo.Getlength(data[i],xian);
                }
                MessageBox.Show("数据导入完成");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Station> data1 = new List<Station>();
            List<Station> data2 = new List<Station>();
            Algo.DP(5.0, data, data1);
            data2 = Algo.remove(data1);

            string tmp = "";
            tmp += "------压缩结果阈值为5.00------"+"\r\n";
            foreach(Station station in data2)
            {
                tmp += $"{station.name},{station.x},{station.y}"+"\r\n";
            }

            List<Station> data3 = new List<Station>();
            Algo.DP(8.0, data, data3);
            data2 = Algo.remove(data3);
            tmp += "------压缩结果阈值为8.00------" + "\r\n";
            foreach (Station station in data2)
            {
                tmp += $"{station.name},{station.x},{station.y}" + "\r\n";
            }
            textBox1.Text = tmp;
        }
    }
}
