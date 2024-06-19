using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数组运算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] a = { "C#", "python", "C", "java", "go" };
        private void button1_Click(object sender, EventArgs e)
        {
            
            Array.Sort(a);
            textBox1.Text = "";
            foreach (string str in a)
            {
                textBox1.Text += str + "\r\n";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s =textBox2.Text;
            int index = Array.BinarySearch(a, s);
            if (index == -1)
            {
                MessageBox.Show("该字符不在数组中");
            }
            else
            {
                string result = $"{s}在s中是第{index+1}位";
                MessageBox.Show(result);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            Array.Reverse(a);
            foreach (string str in a)
            {
                textBox1.Text += str + "\r\n";
            }
        }
    }
}
