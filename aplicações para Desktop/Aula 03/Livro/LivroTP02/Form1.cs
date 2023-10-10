using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LivroTP02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livro dadosLivro = new Livro();

            dadosLivro.setTitulo(textBox1.Text);
            dadosLivro.setAutor(textBox2.Text);
            dadosLivro.setEditora(textBox3.Text);
            dadosLivro.setAnoEdicao(textBox4.Text);
            dadosLivro.setLocal(textBox5.Text);

            LivroBLL.validaDados(dadosLivro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        
    }
}
