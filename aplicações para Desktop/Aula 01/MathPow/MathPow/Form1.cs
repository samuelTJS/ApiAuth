using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPow
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
            double numero1, numero2, exponencial;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);


            exponencial = Math.Pow(numero1, numero2);

            MessageBox.Show("O resultado é: " + exponencial);
        }
    }
}
