using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<epoch> data = new List<epoch>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog windows = new OpenFileDialog();
            windows.Filter = "(*txt)|*txt";
            if (windows.ShowDialog() == DialogResult.OK)
            {
                string path = windows.FileName;
                data=filehelper.a(path);
            }
        }
    }
}
