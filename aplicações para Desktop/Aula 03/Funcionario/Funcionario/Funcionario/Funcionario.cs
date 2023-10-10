using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Funcionario
    {
        private String nomeFuncionario;
        private String horasTrabalhadas;
        private String valorHora;

        public void setNome(string _nomeFuncionario) { nomeFuncionario = _nomeFuncionario; }
        public String getNome() { return nomeFuncionario; }
        public void setHoras(string _horasTrabalhadas) { horasTrabalhadas = _horasTrabalhadas; }
        public String getHoras() { return horasTrabalhadas; }
        public void setValorHora(string _valorHora) { valorHora = _valorHora; }
        public String getValorHora() { return valorHora; }
        public String CalculaSalario()
        {
            return (float.Parse(valorHora) * int.Parse(horasTrabalhadas)).ToString();
        }
    }
}
