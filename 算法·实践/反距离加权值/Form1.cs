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


namespace 反距离加权值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<interpoint> point = new List<interpoint>();
        string data = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //出Q1（4310，3600）、Q2（4330，3600）、Q3（4310，3620）和Q4（4330，3620
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "(*txt)|*txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string filename=of.FileName;
                List<station> data = filenamehelper.duqu(filename);
                interpoint Q1=new interpoint("Q1", 4310, 3600, data, 5);
                interpoint Q2 = new interpoint("Q2", 4330, 3600, data, 5);
                interpoint Q3 = new interpoint("Q3", 4310, 3620, data, 5);
                interpoint Q4 = new interpoint("Q4", 4330, 3620, data, 5);
                point.Add(Q1);
                point.Add(Q2);
                point.Add(Q3);
                point.Add(Q4);
                textBox1.Text = "数据导入成功";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            data += "点名, X坐标分量（m） Y坐标分量（m） 高程（m） 参与插值的点名"+"\r\n";
            for(int i = 0; i < 4; i++)
            {
                interpoint a = point[i];
                data += $"{a.name:f3}     {a.x:f3}      {a.y:f3}        {a.h:f3}  ";
                for(int j = 0; j < a.a.Count; j++)
                {
                    
                    data += $" {a.a[j].name} ";
                }
                data += "\r\n";
            }
            textBox1.Text = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\86155\\Desktop\\mytxt.txt", data);
            textBox1.Text = "文件保存成功";
        }
    }
}
