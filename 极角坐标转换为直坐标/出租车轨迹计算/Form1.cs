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

namespace 出租车轨迹计算
{
    public partial class Form1 : Form
    {
        private SessionList Data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();
            form.Filter = "Text files (*.txt)|*.txt";
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var data = new List<epoch>();
                string Filename = form.FileName;
                var s=duqu.Filenamehelp("T2", Filename);
                Data = new SessionList(s);
                textBox1.Text = "数据读取完成！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=Data.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\86155\\Desktop\\mytxt.txt", Data.ToString());
            textBox1.Text = "文件保存成功";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
