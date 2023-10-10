using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;


namespace TP04
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafico meugrafico = new grafico();
            meugrafico.setA(textBox1.Text);
            meugrafico.setB(textBox2.Text);
            graficoBLL.validaconta(meugrafico);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                for (int i = -100; i <= 100; i++)
                {
                    chart1.Series[0].Points.AddXY(i,int.Parse(meugrafico.getFuncao(i)));
                }
            }
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
