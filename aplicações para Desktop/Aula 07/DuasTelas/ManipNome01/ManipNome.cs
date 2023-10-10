using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipNome01
{
    class ManipNome
    {
        private static String nome;

        public static void setNome(String _nome) { nome = _nome; }
        public static String getNome() { return nome; }
        public static int getUltimoEspaco()
        {
            int i;

            for (i = nome.Length - 1; nome[i] != ' '; --i) ;
            return i;
        }
        public static String getSobrenome()
        {
            string[] sobrenome = nome.Split(' ');
            return sobrenome[sobrenome.Length - 1];
        }
        public static String getNomeF1()
        {
            string[] sobrenome = nome.Split(' ');
            int i;
            string aux = getSobrenome() + ",";  
            for (i = 0; i < sobrenome.Length-1; ++i)
            {
                aux = aux + sobrenome[i] + " ";
            }
            return aux;
        }
        public static String getNomeF2()
        {
            string[] sobrenome = nome.Split(' ');
            int i;
            string aux = getSobrenome() + ",";
            for (i = 0; i < sobrenome.Length - 1; ++i)
            {
                aux = aux + sobrenome[i][0] + ". ";
            }
            return aux;
        }
        public static String getNomeF3()
        {
            String aux = "";
            for (int i = nome.Length-1; i >= 0; --i)
            {
                aux += nome[i];
            }
            return aux;
        }

    }
}
