﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = iData01 + iData02;

                label1.Text = "+";
                label2.Text = "결과는 " + iData03 + " 입니다. ";
            }
            catch (Exception ex)   //에러발생 시
            {
                label2.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = iData01 - iData02;

                label1.Text = "-";
                label2.Text = "결과는 " + iData03 + " 입니다. ";
            }
            catch (Exception ex)   //에러발생 시
            {
                label2.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int iData03 = iData01 * iData02;

                label1.Text = "X";
                label2.Text = "결과는 " + iData03 + " 입니다. ";
            }
            catch (Exception ex)   //에러발생 시
            {
                label2.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double iData01 = double.Parse(textBox1.Text);
                double iData02 = double.Parse(textBox2.Text);
                double iData03 = iData01 / iData02;

                label1.Text = "/";
                label2.Text = "결과는 " + iData03 + " 입니다. ";
            }
            catch (Exception ex)   //에러발생 시
            {
                label2.Text = ex.Message;
            }
        }

        }
    }