﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float b, h, a;

            b = float.Parse(textBox1.Text);
            h = float.Parse(textBox2.Text);
            a = b * h / 2;

            MessageBox.Show("A área do triângulo é de: " + a);
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
