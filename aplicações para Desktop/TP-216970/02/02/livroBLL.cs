using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class livroBLL
    {
        public static void validaDados(livro meuslivros)
        { 
            Error.setErro(false);
            if (meuslivros.getTitulo().Length == 0)
            {
                Error.setErro("O campo TÍTULO é de preenchimento obrigatório...");
                return;
            }

            if (meuslivros.getAutor().Length == 0)
            {
                Error.setErro("O campo AUTOR é de preenchimento obrigatório...");
                return;
            }

            if (meuslivros.getEditora().Length == 0)
            {
                Error.setErro("O campo EDITORA  é de preenchimento obrigatório...");
                return;
            }

            if (meuslivros.getAnoEdicao().Length == 0)
            {
                Error.setErro("O campo ANO DE EDIÇÃO é de preenchimento obrigatório...");
                return;
            }

            else
            {
                try
                {
                    int.Parse(meuslivros.getAnoEdicao());
                }
                catch
                {
                    Error.setErro("O campo ANO DE EDUÇÃO deve ser numérico...");
                    return;
                }
                if (int.Parse(meuslivros.getAnoEdicao()) <= 0)
                {
                    Error.setErro("O campo ANO DE EDUÇÃO deve ser maior que zero.");
                    return;
                }
            }

            if (meuslivros.getLocal().Length == 0)
            {
                Error.setErro("O campo LOCAL é de preenchimento obrigatório...");
                return;
            }
        }
    }
}
