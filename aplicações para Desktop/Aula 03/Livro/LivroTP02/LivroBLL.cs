using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroTP02
{
    internal class LivroBLL
    {
        public static void validaDados(Livro dadosLivro)
        {
            Erro.setErro(false);
            if (dadosLivro.getTitulo().Length == 0)
            {
                Erro.setErro("O campo ''Título'' é de preenchimento obrigatório!");
                return;
            }

            if (dadosLivro.getAutor().Length == 0)
            {
                Erro.setErro("O campo ''Autor'' é de preenchimento obrigatório!");
                return;
            }

            if (dadosLivro.getEditora().Length == 0)
            {
                Erro.setErro("O campo ''Editora'' é de preenchimento obrigatório!");
                return;
            }

            if (dadosLivro.getLocal().Length == 0)
            {
                Erro.setErro("O campo ''Local'' é de preenchimento obrigatório!");
                return;
            }

            if (dadosLivro.getAnoEdicao().Length == 0)
            {
                Erro.setErro("O campo ''Ano da edição'' é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    int.Parse(dadosLivro.getAnoEdicao());
                }
                catch
                {
                    Erro.setErro("O campo ''Ano da edição'' deve ser inteiro!");
                    return;
                }
                if (float.Parse(dadosLivro.getAnoEdicao()) <= 0)
                {
                    Erro.setErro("O campo ''Ano da edição'' deve ser maior que zero!");
                    return;
                }

            }

        }
    }
}
