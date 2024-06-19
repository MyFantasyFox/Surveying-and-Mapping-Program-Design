using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 画图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个画布，画布的长和宽是picturebox的宽和高
            Bitmap bitmap1 = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            Graphics g = Graphics.FromImage(bitmap1);
            g.Clear(Color.White);
            g.DrawLine(Pens.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);
            //g.DrawLine(Pens.Black,0,pictureBox1.Height/2,pictureBox1.Width,pictureBox1.Height/2);
            //g.DrawLine(Pens.Black,pictureBox1.Width/2,0,pictureBox1.Width/2,pictureBox1.Height);
            //g.DrawLine(Pens.Black, pictureBox1.Width / 4, pictureBox1.Height / 4, pictureBox1.Width * 3 / 4, pictureBox1.Height / 4);
            //g.DrawLine(Pens.Black, pictureBox1.Width * 3 / 4, pictureBox1.Height / 4, pictureBox1.Width * 3 / 4, pictureBox1.Height * 3 / 4);
            //g.DrawLine(Pens.Black, pictureBox1.Width * 3 / 4, pictureBox1.Height * 3 / 4, pictureBox1.Width / 4, pictureBox1.Height * 3 / 4);
            //g.DrawLine(Pens.Black, pictureBox1.Width / 4, pictureBox1.Height * 3 / 4, pictureBox1.Width / 4, pictureBox1.Height / 4);

            g.Dispose();
            pictureBox1.Image = bitmap1;
        }
    }
}
