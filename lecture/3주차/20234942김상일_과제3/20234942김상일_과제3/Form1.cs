using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234942김상일_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);   //가로
                int iData02 = int.Parse(textBox2.Text);   //세로
                int iData03 = int.Parse(textBox1.Text);   //높이

                int iData04 = iData01 * 10 * iData02 * 10 * iData03 * 10;

                label1.Text = "직육면체 가로: " + iData01 * 10 + "mm 세로: " + iData02 * 10 + "mm 높이: " + iData03 * 10 + "mm의 \n " + iData04 + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);   //가로
                int iData02 = int.Parse(textBox2.Text);   //세로
                int iData03 = int.Parse(textBox1.Text);   //높이

                int iData04 = iData01 * iData02 * iData03;

                label1.Text = "직육면체 가로: " + iData01 + "cm 세로: "  + iData02 + "cm 높이: " + iData03 + "mm의 \n " + iData04 + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double iData01 = double.Parse(textBox1.Text);   //가로
                double iData02 = double.Parse(textBox2.Text);   //세로
                double iData03 = double.Parse(textBox1.Text);   //높이

                double iData04 = iData01 / 100 / iData02 / 100 / iData03 / 100;

                label1.Text = "직육면체 가로: " + iData01 / 100 + "m 세로: " + iData02 / 100 + "m 높이: " + iData03 / 100 + "m의 \n " + iData04 + "입니다.";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "결과가 표시되는 곳 입니다. ";
        }
    }
}