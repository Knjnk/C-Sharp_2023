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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = textBox1.Text;
            string sData04 = textBox4.Text;
            label5.Text = "성명 : " + sData04 + "\n학번 : " + sData01; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData02 = textBox2.Text;
            string sData03 = textBox3.Text;
            label6.Text = "유선 : " + sData03 + "\n무선 : " + sData02; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
