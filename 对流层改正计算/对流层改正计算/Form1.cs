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

namespace 对流层改正计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<station> stations = new List<station>();
        private void 数据输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                stations = Filehelper.Getdata(path);
            }
        }

        private void 干分量的投影函数计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 干分量的投影函数计算ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(var station in stations)
            {
                station.Mw = Algo.shifenliang(station);
            }
        }

        private void 干分量的投影函数计算ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach(var station in stations)
            {
                station.Md = Algo.Ganfenliang(station);
            }
        }

        private void 计算延迟改正ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stations[0].Mw == 0 || stations[0].Md == 0)
            {
                MessageBox.Show("湿分量或干分量没有计算");
            }
            else
            {
                foreach (var station in stations)
                {
                    station.dertaS = station.ZHD * station.Md + station.ZWD * station.Mw;
                }
            }
        }

        string data = "";
        private void 生成报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data += "测站名      高度角     ZHD     MD     ZWD    mw    延迟改正"+"\r\n";
            foreach(station station in stations)
            {
                data += $"{station.name}        {station.H}   {station.ZHD:f3}   {station.Md:f3}   {station.ZWD:f3}   {station.Mw:f3}  {station.dertaS:f3}\r\n";
            }
            textBox1.Text = data;
        }

        private void 保存报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(data);
                }
                MessageBox.Show("数据保存成功");
            }
        }
    }
}
