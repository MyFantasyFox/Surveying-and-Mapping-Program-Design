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

namespace 激光点云数据的平面分割
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<Point> points = new List<Point>();
        private void 点云数据输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            if (windows.ShowDialog() == DialogResult.OK)
            {
                Filerhelper filerhelper = new Filerhelper(windows.FileName);
                groupBox1.Text = filerhelper.allpoint;
                for(int i = 0; i < filerhelper.points.Count; i++)
                {
                    dataGridView1.Rows.Add(filerhelper.points[i].name, filerhelper.points[i].X, filerhelper.points[i].Y, filerhelper.points[i].Z);
                }
                points = filerhelper.points;
                textBox2.Text = Convert.ToString(points.Count);
            }
        }

        private void 点云数据栅格化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points=Algo.shangehua(points, 10);
        }

        double[] vs;//vs[0]平均高程，vs[1]最高点最低点高差，vs[2]栅格单元的高度方差；
        private void 计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs = Algo.Height(points);
        }

        private void 随机抽样一致RANSAC平面分割ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 平面拟合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point> pointinS = new List<Point>();
            List<Point> pointoutS = new List<Point>();

            double[] pingmian = Algo.Nihe(points[0], points[1], points[2]);
            double p1000 = Algo.PointtoS(points[999], pingmian);
            double p5 = Algo.PointtoS(points[4], pingmian);

            for(int i = 3; i < points.Count; i++)
            {
                double S = Algo.PointtoS(points[i], pingmian);
                if (S < 0.1)
                {
                    pointinS.Add(points[i]);
                }
                else
                {
                    pointoutS.Add(points[i]);
                }
            }

            List<Point> pointinS1 = new List<Point>();
            List<Point> pointoutS2 = new List<Point>();
            double[] J1 = Algo.zuijiafen(points,300,"J1",ref pointinS1, ref pointoutS2);

            List<Point> pointsinJ2 = new List<Point>();
            List<Point> pointsoutJ2 = new List<Point>();
            double[] J2 = Algo.zuijiafen(pointoutS2, 80,"J2",ref pointsinJ2, ref pointsoutJ2);

            Point P5 = points[4];
            Point P800 = points[799];
            Algo.touying(ref P5, J1);
            Algo.touying(ref P800, J2);

        }

        string data = "";
        private void 生成报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data += "点名    X    Y   Z   标识\r\n";
            foreach(Point point in points)
            {
                data += $"{point.name}   {point.X:f3}  {point.Y:f3}  {point.Z:f3}  {point.J}" + "\r\n";
            }
            textBox1.Text = data;
            MessageBox.Show("报告已生成");
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(data);
                }
                MessageBox.Show("报告已生成");
            }
        }
    }
}
