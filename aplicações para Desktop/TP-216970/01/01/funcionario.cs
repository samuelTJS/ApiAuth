using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class funcionario
    {
        private String quantidade_horas;
        private String valor_horas;
        private String nome;

        public void setQuantidade_horas(string _quantidade_horas) { quantidade_horas = _quantidade_horas; } 
        public String getQuantidade_horas() { return quantidade_horas; }
        public void setValor_horas(string _valor_horas) { valor_horas = _valor_horas; }
        public string getValor_horas() { return valor_horas; }

        public void setNome(string _nome) { nome = _nome; }
        public String getNome() { return nome; }

        public String getSalarioBruto()
        {
            return ((int.Parse(quantidade_horas) * float.Parse(valor_horas)).ToString());
        }

    }
}
