using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace Cadastros
{
    internal class ProdutoBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);
            if (Produto.getCodigo().Length == 0)
            {
                Erro.setErro("O campo do nome é de preenchimento obrigatório!");
                return;
            }
            if (Produto.getDescricao().Length == 0)
            {
                Erro.setErro("O campo do RA é de preenchimento obrigatório!");
                return;
            }
            if (Produto.getFornecedor().Length == 0)
            {
                Erro.setErro("O campo do RA é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
