using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 极角坐标转换为直坐标
{
    public partial class 极坐标转换为直角坐标 : Form
    {
        public 极坐标转换为直角坐标()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private static void BLH2XYZ(double B, double L, double H, double X, out double Y, double Z)
        {
            //地理坐标系转空间直角坐标系函数
            double deg2red = Math.PI / 180;
            B = B * deg2red;
            L = L * deg2red;
            double a = 6378137;
            double f = 1 / 298.257222101;
            double e2 = 2 * f - f * f;
            double sinB = Math.Sin(B);
            double N = a / Math.Sqrt(1 - e2 * sinB * sinB);
            X = (N + H) * Math.Cos(B) * Math.Cos(L);
            Y = (N + H) * Math.Cos(B) * Math.Sin(L);
            Z = (N * (1 - e2) + H) * Math.Sin(B);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("坐标转换");
            double banjing = (double)this.numericUpDown1.Value;   //注意框是否有最大值限制
            double jiaodu = (double)this.numericUpDown2.Value;
            double x = banjing * Math.Cos(jiaodu);
            double y = banjing * Math.Sin(jiaodu);
            //把输入的半径与角度计算为xy

            this.textBox1.Text = x.ToString("##.##");//保留两位小数
            this.textBox2.Text = y.ToString("##.##");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";   //寻找文件
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofd.FileName;
                string[] s = System.IO.File.ReadAllLines(filename);//这两步是找到文件路径按行返会txt文档数据
                foreach (string data in s)
                {
                    string[] values = data.Split(',');  //把字符串按照','拆分
                    MessageBox.Show(values[0].ToString());  //返回第一列
                }
            }
        }
    }
}
