using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteKM_Milha
{
    internal class Converte
    {
        private String valor;

        public void setValor(String _valor)
        {
            valor = _valor;
        }

        public String getValor() { return valor; }

        public String getKm_Milha()
        {
            return (float.Parse(valor) / 1.609344).ToString("N5");
        }

        public String getMilha_Km()
        {
            return (float.Parse(valor) * 1.609344).ToString("N5");
        }

    }
}
