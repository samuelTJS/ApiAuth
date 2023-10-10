using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiblioteca;

namespace Cadastros
{
    public partial class CadastroProdutoIHM : Form
    {
        public CadastroProdutoIHM()
        {
            InitializeComponent();
        }

        private void bt_Salvar2_Click(object sender, EventArgs e)
        {
            Produto.setCodigo(tb_Codigo.Text);
            Produto.setDescricao(tb_Descricao.Text);
            Produto.setFornecedor(tb_Fornecedor.Text);
            Produto.setQtdestoque(tb_Qtdestoque.Text);
            Produto.setValorUnitario(tb_ValorUnitario.Text);

            ProdutoBLL.validaDados();

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
        }
        private void bt_Mostrar2_Click(object sender, EventArgs e)
        {

        }
        private void bt_Limpar2_Click(object sender, EventArgs e)
        {

        }
    }
}
