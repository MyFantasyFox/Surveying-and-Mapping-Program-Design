using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 算法_实践
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

        private void btn_Click(object sender, EventArgs e)
        {
            double ax = Convert.ToDouble(textBox1.Text);
            double ay = Convert.ToDouble(textBox2.Text);

            double bx = Convert.ToDouble(textBox4.Text);
            double by = Convert.ToDouble(textBox5.Text);

            double dx = bx - ax;
            double dy = by - ay;
            textBox7.Text = Convert.ToString(Math.Sqrt(dx*dx+dy*dy));

            double dx1 = Math.Abs(dx);
            double dy1 = Math.Abs(dy);
            double arfa = Math.Atan2(dy1, dx1)*180/Math.PI;

            if (dx > 0 && dy > 0)
            {
                textBox3.Text = Convert.ToString(arfa);
            }
            if (dx > 0 && dy < 0)
            {
                arfa = 360 - arfa;
                textBox3.Text = Convert.ToString(arfa);
            }
            if(dx < 0 && dy > 0)
            {
                arfa = 180 - arfa;
                textBox3.Text = Convert.ToString(arfa);
            }
            if(dx<0 && dy < 0)
            {
                arfa += 180;
                textBox3.Text = Convert.ToString(arfa);
            }

            textBox6.Text = Convert.ToString(arfa * Math.PI / 180);

            double[] angle = Getangle.Angle(arfa);
            textBox8.Text = Convert.ToString(angle[0]);
            textBox9.Text = Convert.ToString(angle[1]);
            textBox10.Text = Convert.ToString(angle[2]);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
