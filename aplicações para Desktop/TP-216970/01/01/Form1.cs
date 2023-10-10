using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario meusalario = new funcionario();

           meusalario.setNome(tbNome.Text);
           meusalario.setValor_horas(tbValor.Text);
           meusalario.setQuantidade_horas(tbHoras.Text);
           funcionarioBLL.validaDados(meusalario);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                tbSalario.Text = meusalario.getSalarioBruto();
                tbNome.Enabled = false;
                tbValor.Enabled = false;
                tbHoras.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
