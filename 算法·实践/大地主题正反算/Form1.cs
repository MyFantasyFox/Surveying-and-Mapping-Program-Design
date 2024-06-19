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

namespace 大地主题正反算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "*(txt)|*txt";
            if (windows.ShowDialog() == DialogResult.OK)
            {
                string filename = windows.FileName;
                filehelper.Getfan(filename);
            }
        }
    }
}
