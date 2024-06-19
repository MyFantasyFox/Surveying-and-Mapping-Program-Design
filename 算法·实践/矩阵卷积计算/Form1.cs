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

namespace 矩阵卷积计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double[]> M = new List<double[]>();
        List<double[]> N = new List<double[]>();
        private void btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = windows.FileName;
                M=Filehelper.Getmatrix(path);
                MessageBox.Show("矩阵M导入成功");                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = windows.FileName;
                N=Filehelper.Getmatrix(path);
                MessageBox.Show("矩阵N导入成功");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double[,] data1 = new double[N.Count, N[0].Length];
            string N1 = "";
            data1 = ALGO.Algo1(M, N);
            N1=ALGO.Getstring(data1);
            textBox1.Text = N1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[,] data1 = new double[N.Count, N[0].Length];
            string N1 = "";
            data1 = ALGO.Algo2(M, N);
            N1 = ALGO.Getstring(data1);
            textBox1.Text += N1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = of.FileName;
                Bitmap bitmap1 = new Bitmap(of.FileName);

                double mapwidth = bitmap1.Width;
                double mapheight = bitmap1.Height;
                //这里要注意图片的初始大小应该用double类型储存；
                int picturewidth = pictureBox1.Width;
                int pictureheight = pictureBox1.Height;
                double sizex = picturewidth / mapwidth;
                double sizey = pictureheight / mapheight;

                int newwidth = Convert.ToInt32(mapwidth * sizex);
                int newheight = Convert.ToInt32(mapheight * sizey);
                
                Bitmap newImage = new Bitmap(newwidth,newheight);
                using (Graphics graphics = Graphics.FromImage(newImage))
                //不能创建一个graphics实体，它必须在括号中写被画的对象
                {
                    graphics.DrawImage(bitmap1, 0, 0, newwidth, newheight);
                }

                pictureBox1.Image = newImage;
                //这种方法可以向picture中导入图像
                //picturebox.image=bitmap也可以进行导入图形

                Color c;
                int average = 0;
                Bitmap huiduhua = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                for(int i = 0; i < newImage.Width; i++)
                {
                    for(int j = 0; j < newImage.Height; j++)
                    {
                        c = newImage.GetPixel(i, j);
                        average = (c.R + c.G + c.B) / 3;
                        //平均值灰度化
                        huiduhua.SetPixel(i, j, Color.FromArgb(average, average, average));
                    }
                }
                pictureBox2.Image = huiduhua;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
