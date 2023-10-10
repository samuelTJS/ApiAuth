using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioAsenjo
{
    internal class PessoaBLL
    {
        //public static bool ValidaCEP(string cep)
        //{
        //    string padraoCEP = @"^\d{5}-\d{3}$";

        //    Regex regex = new Regex(padraoCEP);

        //    if (regex.IsMatch(cep))
        //    {
        //        return true;
        //    }

        //    return false;
        //}
        public static bool validaEmail(Pessoa pessoa)
        {
            string email = pessoa.getEmail();

            string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(padraoEmail);

            if (regex.IsMatch(email))
            {
                return true;
            }

            return false;
        }

        public static void validaCadastro(Pessoa pessoa)
        {
            Erro.setErro(false);
            if (pessoa.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }

            string telefone = pessoa.getTelefone();
            string telefoneLimpo = new string(telefone.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(telefoneLimpo) || telefoneLimpo.Length < 10)
            {
                Erro.setMsg("Preencha o telefone corretamente!");
                return;
            }


            if (pessoa.getEmail().Equals(""))
            {
                Erro.setMsg("O e-mail é de preenchimento obrigatório!");
                return;
            }
            else if (validaEmail(pessoa) == false)
            {
                Erro.setMsg("E-mail inválido!");
                return;
            }
            else if (PessoaDAL.verificaEmailExistente(pessoa.email))
            {
                Erro.setMsg("E-mail já registrado!");
                return;
            }

            string cep = pessoa.getCep();
            if(pessoa.getCep().Equals(""))
            {
                Erro.setMsg("O cep é de preenchimento obrigatório!");
                return;
            }
            else if (cep.Length != 8)
            {
                Erro.setMsg("O cep é invalido!");
                return;
            }

            if (pessoa.getEstado().Equals(""))
            {
                Erro.setMsg("O Estado é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getCidade().Equals(""))
            {
                Erro.setMsg("A cidade é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getBairro().Equals(""))
            {
                Erro.setMsg("O bairro é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getRua().Equals(""))
            {
                Erro.setMsg("A rua é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getNumero().Equals(""))
            {
                Erro.setMsg("O numero é de preenchimento obrigatório!");
                return;
            }

            PessoaDAL.cadastraPessoa(pessoa);
        }

        public static void validaEdicao(Pessoa pessoa)
        {
            Erro.setErro(false);
            if (pessoa.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }

            string telefone = pessoa.getTelefone();
            string telefoneLimpo = new string(telefone.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(telefoneLimpo) || telefoneLimpo.Length < 10)
            {
                Erro.setMsg("Preencha o telefone corretamente!");
                return;
            }

            string cep = pessoa.getCep();
            string cepLimpo = new string(cep.Where(char.IsDigit).ToArray());
            if (string.IsNullOrEmpty(cepLimpo) || cepLimpo.Length != 8)
            {
                Erro.setMsg("Preencha o CEP corretamente!");
                return;
            }

            if (pessoa.getEstado().Equals(""))
            {
                Erro.setMsg("O Estado é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getCidade().Equals(""))
            {
                Erro.setMsg("A cidade é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getBairro().Equals(""))
            {
                Erro.setMsg("O bairro é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getRua().Equals(""))
            {
                Erro.setMsg("A rua é de preenchimento obrigatório!");
                return;
            }

            if (pessoa.getNumero().Equals(""))
            {
                Erro.setMsg("O numero é de preenchimento obrigatório!");
                return;
            }

            PessoaDAL.editaPessoa(pessoa);
        }

        public static void validaExclusão(string email)
        {
            if (email.Equals(""))
            {
                Erro.setMsg("O e-mail é de preenchimento obrigatório!");
                return;
            }
            else if (PessoaDAL.verificaEmailExistente(email) == false)
            {
                Erro.setMsg("E-mail não existe");
                return;
            }
            PessoaDAL.excluirCadastro(email);

        }
    }
}
