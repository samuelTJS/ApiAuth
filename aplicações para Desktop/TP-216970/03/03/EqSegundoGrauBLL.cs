using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class EqSegundoGrauBLL
    {
        public static void validaDados(EqSegundoGrau meucalculo)
        {

            Erro.setErro(false);

            if(meucalculo.getcalcDelta().Length < 0)
            {
                Erro.setErro("Delta deve ser maior que zero");
            }

            if (meucalculo.getA().Length == 0)
            {
                Erro.setErro("O campo A é de preenchimento obrigatório...");
                return;
            }

            else
            {
                try
                {
                    int.Parse(meucalculo.getA());
                }
                catch
                {
                    Erro.setErro("O campo A deve ser numérico...");
                    return;
                }
                if (float.Parse(meucalculo.getA()) <= 0)
                {
                    Erro.setErro("O campo A deve ser maior que zero.");
                    return;
                }
            }


            if (meucalculo.getB().Length == 0)
            {
                Erro.setErro("O campo B é de preenchimento obrigatório...");
                return;
            }

            else
            {
                try
                {
                    int.Parse(meucalculo.getB());
                }
                catch
                {
                    Erro.setErro("O campo B deve ser numérico...");
                    return;
                }
                if (float.Parse(meucalculo.getB()) <= 0)
                {
                    Erro.setErro("O campo B deve ser maior que zero.");
                    return;
                }
            }


            if (meucalculo.getC().Length == 0)
            {
                Erro.setErro("O campo C é de preenchimento obrigatório...");
                return;
            }

            else
            {
                try
                {
                    int.Parse(meucalculo.getC());
                }
                catch
                {
                    Erro.setErro("O campo C deve ser numérico...");
                    return;
                }
                if (float.Parse(meucalculo.getA()) <= 0)
                {
                    Erro.setErro("O campo C deve ser maior que zero.");
                    return;
                }
            }

        }
    }
}
