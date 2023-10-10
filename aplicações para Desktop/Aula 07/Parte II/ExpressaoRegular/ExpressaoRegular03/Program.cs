using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExpressaoRegular03
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex expressao = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");

            Match telefone = expressao.Match("(11) 94876-8956");
            if (telefone.Success)
                Console.WriteLine("número de telefone válido!!!");
            else
                Console.WriteLine("número de telefone inválido!!!");
            Console.ReadKey();
        }
    }
}
