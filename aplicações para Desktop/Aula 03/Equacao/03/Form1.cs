using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
           EqSegundoGrau meucalculo = new EqSegundoGrau();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            meucalculo.setA(tbA.Text);
            meucalculo.setB(tbB.Text);
            meucalculo.setC(tbC.Text);
            EqSegundoGrauBLL.validaDados(meucalculo);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
