using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaBanco01
{
    class CaixaBanco
    {
        private int numcaixa;
        private static int senhacliente = 0;

        public CaixaBanco() {}
        public CaixaBanco(int _numcaixa) { numcaixa=_numcaixa; }
        
        public void setNumCaixa(int _numcaixa) { numcaixa = _numcaixa; }
        public int getNumCaixa() { return numcaixa; }
        public void setSenhaCliente(int _senhacliente) { senhacliente = _senhacliente; }
        public int getSenhaCliente() { return senhacliente; }
        public void AtenderCliente() {++senhacliente;}
    }
}
