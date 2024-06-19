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

namespace 大地坐标正反算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string[]> vs = new List<string[]>();
        private void 反算数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                vs=filehelper.Read(open.FileName);
                MessageBox.Show("数据读取成功");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 正算数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                vs = filehelper.Read(open.FileName);
                MessageBox.Show("数据读取成功");
            }
        }

        List<Fansuan> fansuans = new List<Fansuan>();
        List<string[]> vs1 = new List<string[]>();
        private void 数据反算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fansuans=Algo.Fan(vs, this);
            foreach(var str in fansuans)
            {
                string[] vs2 = Tostring.ToStr(str);
                vs1.Add(vs2);
            }
            foreach(var a1 in vs1)
            {
                this.dataGridView1.Rows.Add(a1);
            }
            
        }
        
        private void 数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs1=Algo.zheng(vs, this);
            foreach(var tmp in vs1)
            {
                dataGridView1.Rows.Add(tmp);
            }
        }
        

        private void 报告导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data == "")
            {
                MessageBox.Show("没有生成报告");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "(*txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter Sw=new StreamWriter(saveFileDialog.FileName))
                    {
                        Sw.Write(textBox4.Text);
                    }
                    MessageBox.Show("文件已保存");
                }
                
            }
        }
        string data = "";
        private void 生成报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var a in vs1)
            {
                foreach(var i in a)
                {
                    data += i + "\t";
                }
                data += "\r\n";
            }
            textBox4.Text = data;
        }
    }
}
