using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
    public partial class TelaInicial_IHM : Form
    {
        public TelaInicial_IHM()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroAlunoIHM cadastroAlunoIHM = new CadastroAlunoIHM();
            cadastroAlunoIHM.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastroProdutoIHM cadastroProdutoIHM = new CadastroProdutoIHM();
            cadastroProdutoIHM.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
