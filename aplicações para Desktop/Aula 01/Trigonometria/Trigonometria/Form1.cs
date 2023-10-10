using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometria
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double angulo, radiano, seno, cosseno, tangente, secante;

            angulo = double.Parse(textBox1.Text);

            radiano = angulo * (Math.PI / 180);

            seno = Math.Sin(radiano);
            cosseno = Math.Cos(radiano);
            tangente = Math.Tan(radiano);
            secante = 1 / cosseno;

            MessageBox.Show("O valor do seno é de: " + seno + "\nO valor do cosseno é de: " + cosseno + "\nO valor da tangente é de: " + tangente + "\nO valor da secante é de: " + secante);
        }
    }
}
