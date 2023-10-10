using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP04
{
    internal class grafico
    {
        private String a;
        private String b;

        public void setA(string _a) { a = _a; }
        public string getA() { return a; }
        public void setB(string _b) { b = _b; }
        public string getB() { return b; }

        public string getFuncao(int x)
        {
            return ((float.Parse(a) * x) + float.Parse(b)).ToString();
        }
    }
}
