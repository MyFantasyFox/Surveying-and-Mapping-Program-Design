using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 利用线性回归模型进行卫星轨道的预报
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path="";
        List<epoch> epoch1 = new List<epoch>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = windows.FileName;
            }
            textBox1.Text = "数据导入完成";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            epoch1 = filehelper.filehelper2(path);
            List<int> time = new List<int>();
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            List<double> z = new List<double>();
            for (int i = 0; i < epoch1.Count; i++)
            {
                epoch ep = new epoch();
                ep = epoch1[i];
                time.Add(ep.time);
                x.Add(ep.X);
                y.Add(ep.Y);
                z.Add(ep.Z);
            }
            double[] xdeta = new double[2];
            double[] ydeta = new double[2];
            double[] zdeta = new double[2];
            xdeta = Algo.Getxishu(time, x);
            ydeta = Algo.Getxishu(time, y);
            zdeta = Algo.Getxishu(time, z);

            string da = "";
            da+="回归系数"+"\r\n";
            da += $"{xdeta[0]:f5}    {xdeta[1]:f5}" + "\r\n";
            da += $"{ydeta[0]:f5}    {ydeta[1]:f5}" + "\r\n";
            da += $"{zdeta[0]:f5}    {zdeta[1]:f5}" + "\r\n";

            double[] data1 = new double[3];
            double[] data2 = new double[3];
            double[] data3 = new double[3];
            data1 = Algo.Getyuce(xdeta, ydeta, zdeta, 4200);
            data2 = Algo.Getyuce(xdeta, ydeta, zdeta, 4500);
            data3 = Algo.Getyuce(xdeta, ydeta, zdeta, 4800);
            da +="\r\n"+ "预测结果" + "\r\n";
            da += "4200"  +$"   {data1[0]:f3}  {data1[1]:f3}  {data1[2]:f3}" + "\r\n";
            da += "4500" + $"   {data2[0]:f3}  {data2[1]:f3}  {data2[2]:f3}" + "\r\n";
            da += "4800" + $"   {data3[0]:f3}  {data3[1]:f3}  {data3[2]:f3}" + "\r\n";

            textBox1.Text = da;
        }
    }
}
