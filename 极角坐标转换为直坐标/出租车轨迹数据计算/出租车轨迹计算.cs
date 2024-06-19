using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 出租车轨迹数据计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BTN2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var epoches = FileHelper.Read("T2", openFileDialog1.FileName);
                Data = new SessionList(epoches);
                richTextBox1.Text = "数据读取完成！";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
