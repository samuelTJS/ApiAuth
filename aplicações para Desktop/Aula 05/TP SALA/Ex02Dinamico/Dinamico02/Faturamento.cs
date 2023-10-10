using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamico02
{
    internal class Faturamento
    {
        private float valor = 0;

        public float getValor()
        {
            return valor;
        }

        public void setValor(float _valor)
        {
            valor = _valor;
        }
    }
}
