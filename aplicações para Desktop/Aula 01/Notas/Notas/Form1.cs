using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float p1, p2, p3, p4, media;

            p1 = float.Parse(textBox1.Text);
            p2 = float.Parse(textBox2.Text);
            p3 = float.Parse(textBox3.Text);
            p4 = float.Parse(textBox4.Text);

            media = (p1 + p2 + p3 + p4) / 4;

            MessageBox.Show("A média das quatro notas é: " + media);
        }
    }
}
