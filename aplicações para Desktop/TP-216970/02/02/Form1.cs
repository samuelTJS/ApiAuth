using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        livro meuslivros = new livro();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            meuslivros.setTitulo(tbTitulo.Text);
            meuslivros.setAutor(tbAutor.Text);
            meuslivros.setEditora(tbEditora.Text);
            meuslivros.setAnoEdicao(tbAnoEdicao.Text);
            meuslivros.setLocal(tbLocal.Text);
            livroBLL.validaDados(meuslivros);
            if (Error.getErro())
            {
                MessageBox.Show(Error.getMens());
            }
            else
            {
                //tbSalario.Text = meusalario.getSalarioBruto();
                tbTitulo.Enabled = false;
                tbAutor.Enabled = false;
                tbEditora.Enabled = false;
                tbAnoEdicao.Enabled = false;
                tbLocal.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTitulo.Clear();
            tbAutor.Clear();
            tbEditora.Clear();
            tbAnoEdicao.Clear();
            tbLocal.Clear();
            tbTitulo.Enabled = true;
            tbAutor.Enabled = true;
            tbEditora.Enabled = true;
            tbAnoEdicao.Enabled = true;
            tbLocal.Enabled = true;

            tbTitulo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbTitulo.Text = meuslivros.getTitulo();
            tbAutor.Text = meuslivros.getAutor();
            tbEditora.Text = meuslivros.getEditora();
            tbAnoEdicao.Text = meuslivros.getAnoEdicao();
            tbLocal.Text = meuslivros.getLocal();

        }
    }
}
