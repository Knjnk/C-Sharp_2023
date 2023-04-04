using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20234942김상일_과제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = "20234942";
            string sData02 = "김상일";

            label1.Text = "학번 : " + sData01 + "\n성명 : " + sData02; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData01 = "010-3400-3973";
            string sData02 = "055-123-4567";

            label2.Text = "유선 : " + sData01 + "\n무선 : " + sData02; 
        }
    }
}
