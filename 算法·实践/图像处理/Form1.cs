using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图像处理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static Bitmap b2;
        static OpenFileDialog OF = new OpenFileDialog(); //创建一个实例选择框
        private void button1_Click(object sender, EventArgs e)
        {
            OF.Filter = "图片文件读取|*.jpg";
            OF.Multiselect = false;//不能多选
            if(OF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap b = new Bitmap(OF.FileName);//创建一个位图
                b2 = b;//复制一份位图，用于恢复原图 
                pictureBox1.Image = b;
            }
        }

        Color c;
        int value = 0;
        int da = 0;
        int quan = 0;
        double count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b2.Width; i++)
            {
                for (int j = 0; j < b2.Height; j++)
                {
                    c = b2.GetPixel(i, j);  //用于获取指定索引值坐标的像素
                    value = (c.R + c.G + c.B) / 3;  //平均值灰度算法
                    b2.SetPixel(i, j, Color.FromArgb(value, value, value));
                    //在fromargb方法中value不能用double类型只能用int类型
                }
            }
            pictureBox1.Image = b2;
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b2.Width; i++)
            {
                for (int j = 0; j < b2.Height; j++)
                {
                    c = b2.GetPixel(i, j);
                    int[] a = new int[3] { c.R, c.G, c.B };
                    Array.Sort(a);
                    da = a[2];
                    b2.SetPixel(i, j, Color.FromArgb(da, da, da));
                }
            }
            pictureBox1.Image = b2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //？？？？？？
            //for (int i = 0; i < b2.Width; i++)
            //{
            //    for (int j = 0; j < b2.Height; j++)
            //    {
            //        count = c.R + c.G + c.B;
            //        value = Convert.ToInt32((c.R * c.R + c.G * c.G + c.B * c.B) / count);
            //        b2.SetPixel(i, j, Color.FromArgb(value, value, value));
            //    }
            //}
            //pictureBox1.Image = b2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(OF.FileName);
            pictureBox1.Image = b;
        }
    }
}
