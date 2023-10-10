using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;


namespace TP04
{
    internal class graficoBLL
    {
        public static void validaconta(grafico meugrafico)
        {
            Erro.setErro(false);
            if(meugrafico.getA().Length == 0)
            {
                Erro.setErro("O campo A é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(meugrafico.getB());
                }
                catch
                {
                    Erro.setErro("O campo A deve ser numérico...");
                    return;
                }
                if (float.Parse(meugrafico.getB()) <= 0)
                {
                    Erro.setErro("O campo A deve ser maior que zero.");
                    return;
                }
            }

            if (meugrafico.getB().Length == 0)
            {
                Erro.setErro("O campo B é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    float.Parse(meugrafico.getB());
                }
                catch
                {
                    Erro.setErro("O campo B deve ser numérico...");
                    return;
                }
                if (float.Parse(meugrafico.getB()) <= 0)
                {
                    Erro.setErro("O campo B deve ser maior que zero.");
                    return;
                }
            }
        }
    }
}
