using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros
{
    internal class Produto
    {
        private static string codigo;
        private static string descricao;
        private static string fornecedor;
        private static string qtdestoque;
        private static string valorunitario;

        public static void setCodigo(string _codigo)
        {
            codigo = _codigo;
        }

        public static void setDescricao(string _descricao)
        {
            descricao = _descricao;
        }

        public static void setFornecedor(string _fornecedor)
        {
            fornecedor = _fornecedor;
        }

        public static void setQtdestoque(string _qtdestoque)
        {
            qtdestoque = _qtdestoque;
        }

        public static void setValorUnitario(string _valorunitario)
        {
            valorunitario = _valorunitario;
        }

        public static string getCodigo()
        {
            return codigo;
        }

        public static string getDescricao()
        {
            return descricao;
        }

        public static string getFornecedor()
        {
            return fornecedor;
        }

        public static string getQtdestoque()
        {
            return qtdestoque;
        }

        public static string getValorUnitario()
        {
            return valorunitario;
        }
    }
}
