using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class funcionarioBLL
    {
        public static void validaDados(funcionario meusalario)
        {
            Erro.setErro(false);
            if (meusalario.getNome().Length == 0)
            {
                Erro.setErro("O campo NOME é de preenchimento obrigatório...");
                return;
            }

            if (meusalario.getQuantidade_horas().Length == 0)
            {
                Erro.setErro("O campo QUANTIDADE DE HORAS é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    int.Parse(meusalario.getQuantidade_horas());
                }
                catch
                {
                    Erro.setErro("O campo QUANTIDADE DE HORAS deve ser numérico...");
                    return;
                }

            }

            if (meusalario.getValor_horas().Length == 0)
            {
                Erro.setErro("O campo VALOR HORAS é de preenchimento obrigatório...");
                return;
            }

            else
            {
                try
                {
                    int.Parse(meusalario.getValor_horas());
                }
                catch
                {
                    Erro.setErro("O campo VALOR HORAS deve ser numérico...");
                    return;
                }
                if (float.Parse(meusalario.getValor_horas()) <= 0)
                {
                    Erro.setErro("O campo VALOR HORAS deve ser maior que zero.");
                    return;
                }
            }

        }
    }
}
