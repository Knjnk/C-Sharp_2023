using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023942김상일_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 == iData02;

            label1.Text = "==";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 <= iData02;

            label1.Text = "<=";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 < iData02;

            label1.Text = "<";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 != iData02;

            label1.Text = "!=";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 < iData02;

            label1.Text = "<";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);

            bool bdata01 = iData01 > iData02;

            label1.Text = ">";
            label2.Text = "결과는 " + bdata01 + " 입니다.";
        }
    }
}
