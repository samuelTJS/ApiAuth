using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Aluno
    {
        private static string ra;
        private static string nome;
        private static string sexo;
        private static string datanascimento;
        private static string telefone;

        public static void setRA(string _ra)
        {
            ra = _ra;
        }

        public static void setNome(string _nome)
        {
            nome = _nome;
        }

        public static void setSexo(string _sexo)
        {
            sexo = _sexo;
        }

        public static void setDataNascimento(string _datanascimento)
        {
            datanascimento = _datanascimento;
        }

        public static void setTelefone(string _telefone)
        {
            telefone = _telefone;
        }

        public static string getRA()
        {
            return ra;
        }

        public static string getNome()
        {
            return nome;
        }

        public static string getSexo()
        {
            return sexo;
        }

        public static string getDataNascimento()
        {
            return datanascimento;
        }

        public static string getTelefone()
        {
            return telefone;
        }
    }
}
