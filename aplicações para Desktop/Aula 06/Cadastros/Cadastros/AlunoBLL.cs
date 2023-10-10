using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace Cadastros
{
    internal class AlunoBLL
    {
        public static void validaDados()
        {
            Erro.setErro(false);
            if (Aluno.getNome().Length == 0)
            {
                Erro.setErro("O campo do nome é de preenchimento obrigatório!");
                return;
            }
            if (Aluno.getRA().Length == 0)
            {
                Erro.setErro("O campo do RA é de preenchimento obrigatório!");
                return;
            }
            if (Aluno.getSexo().Length == 0)
            {
                Erro.setErro("O campo de sexo é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
