using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario dadosFuncionario = new Funcionario();

            dadosFuncionario.setNome(textBox1.Text);
            dadosFuncionario.setHoras(textBox2.Text);
            dadosFuncionario.setValorHora(textBox3.Text);

            FuncionarioBLL.validaDados(dadosFuncionario);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textBox4.Text = dadosFuncionario.CalculaSalario();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}
