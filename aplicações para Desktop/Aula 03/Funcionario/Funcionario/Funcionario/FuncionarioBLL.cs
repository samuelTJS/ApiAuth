using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class FuncionarioBLL
    {
        public static void validaDados(Funcionario dadosFuncionario)
        {
            Erro.setErro(false);
            if (dadosFuncionario.getNome().Length == 0)
            {
                Erro.setErro("O campo ''Nome de funcionário'' é de preenchimento obrigatório!");
                return;
            }
           

            if (dadosFuncionario.getValorHora().Length == 0)
            {
                Erro.setErro("O campo ''Valor da hora'' é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    int.Parse(dadosFuncionario.getValorHora());
                }
                catch
                {
                    Erro.setErro("O campo ''Valor da hora'' deve ser inteiro!");
                    return;
                }
                if (float.Parse(dadosFuncionario.getValorHora()) <= 0)
                {
                    Erro.setErro("O campo ''Valor da hora'' deve ser maior que zero!");
                    return;
                }

            }

            if (dadosFuncionario.getHoras().Length == 0)
            {
                Erro.setErro("O campo ''Horas trabalhadas'' é de preenchimento obrigatório!");
                return;
            }
            else
            {
                try
                {
                    float.Parse(dadosFuncionario.getHoras());
                }
                catch
                {
                    Erro.setErro("O campo ''Horas trabalhadas'' deve ser numérico!");
                    return;
                }
                if (float.Parse(dadosFuncionario.getHoras()) <= 0)
                {
                    Erro.setErro("O campo ''Horas trabalhadas'' deve ser maior que zero!");
                    return;
                }

            }


        }
    }
}
