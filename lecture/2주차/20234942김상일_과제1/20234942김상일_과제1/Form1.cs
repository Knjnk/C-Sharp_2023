using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234942김상일_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            label1.Text = "결과는 " + iData01 + "입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData01 = double.Parse(textBox1.Text);
            label1.Text = "결과는 " + dData01 + "입니다.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            string sData01 = "332";
            string sData02 = iData01 + sData01;
            label1.Text = "결과는 " + iData01 + "+" + sData01 + "=" + sData02 + "입니다.";
        }
    }
}
