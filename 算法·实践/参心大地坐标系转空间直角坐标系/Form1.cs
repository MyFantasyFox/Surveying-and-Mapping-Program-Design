using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 参心大地坐标系转空间直角坐标系
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //利用数组存储度分秒
            double[] B = new double[3];
            B[0] = Convert.ToDouble(textBox1.Text);
            B[1] = Convert.ToDouble(textBox2.Text);
            B[2] = Convert.ToDouble(textBox3.Text);

            double[] L = new double[3];
            L[0] = Convert.ToDouble(textBox4.Text);
            L[1] = Convert.ToDouble(textBox5.Text);
            L[2] = Convert.ToDouble(textBox6.Text);

            double H = Convert.ToDouble(textBox7.Text);
            double f = 1 / 298.257222101;
            double e2 = (2 * f - f * f) * (2 * f - f * f);
            double angleB = (B[0] + B[1] / 60.0 + B[2] / 3600.0)*Math.PI/180;
            double angleL = (L[0] + L[1] / 60.0 + L[2] / 3600.0)*Math.PI/180;

            double N = 6378137 / (Math.Sqrt(1 - e2 * Math.Sin(angleB) * Math.Sin(angleB)));

            textBox8.Text = Convert.ToString((N + H) * Math.Cos(angleB) * Math.Cos(angleL));
            textBox9.Text = Convert.ToString((N + H) * Math.Cos(angleB) * Math.Sin(angleL));
            textBox10.Text = Convert.ToString((N * (1 - e2) + H) * Math.Sin(angleB));

        }
    }
}
