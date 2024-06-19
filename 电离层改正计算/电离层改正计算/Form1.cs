using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电离层改正计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<point> points = new List<point>();
        double[] time = new double[6];
        private void 电离层数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                points = filerhelper.Getdiandata(path,ref time);
                textBox1.Text = Convert.ToString(time[0]);
                textBox2.Text = Convert.ToString(time[1]);
                textBox3.Text = Convert.ToString(time[2]);
                textBox4.Text = Convert.ToString(time[3]);
                textBox5.Text = Convert.ToString(time[4]);
                textBox6.Text = Convert.ToString(time[5]);
                MessageBox.Show("数据导入成功");
            }
        }

        private void 计算卫星高度角和方位角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 穿刺点的地磁纬度ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        point pointP = new point();
        private void 高度角和方位角计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointP.name = "P";
            pointP.X = -2225669.7744;
            pointP.Y = 4998936.1598;
            pointP.Z = 3265908.9678;

            for (int i = 0; i < points.Count; i++)
            {
                Algo.H_angleandangle(pointP, points[i]);
            }
        }

        private void 穿刺点的地磁纬度ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void 对流层数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
