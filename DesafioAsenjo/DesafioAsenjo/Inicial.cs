using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAsenjo
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            Criar form_criar = new Criar();
            form_criar.Show();
        }

        private void Ler_Click(object sender, EventArgs e)
        {
            Ler ler = new Ler();
            ler.Show();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir form_excluir = new Excluir();
            form_excluir.Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Editar form_editar = new Editar();
            form_editar.Show();
        }
    }
}
