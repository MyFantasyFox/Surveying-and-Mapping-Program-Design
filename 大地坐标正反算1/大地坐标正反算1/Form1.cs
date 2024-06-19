using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大地坐标正反算1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Basedata> basedatas = new List<Basedata>();
        private void 正算数据读取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                basedatas = Filehelper.Getzheng(open.FileName);
            }
            textBox2.Text = Convert.ToString(basedatas[0].Ellipse.a);
            textBox3.Text = Convert.ToString(basedatas[0].Ellipse.b);
            textBox4.Text = Convert.ToString(Math.Pow(basedatas[0].Ellipse.f, -1));
        }

        List<Basedata> basedatasfan = new List<Basedata>();
        private void 反算数据读取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                basedatasfan = Filehelper.Getfan(openFileDialog.FileName);
            }
        }

        private void 数据正算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algo.zheng(basedatas[0]);
        }

        private void 数据反算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algo.FanSuan(basedatasfan[0]);
        }
    }
}
