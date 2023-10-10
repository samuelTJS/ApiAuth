using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class EqSegundoGrau
    {
        private String a;
        private String b;
        private String c;

        public void setA(string _a) { a = _a; }
        public String getA() { return a; }

        public void setB(string _b) { b = _b; }
        public String getB() { return b; }

        public void setC(string _c) { c = _c; }
        public String getC() { return c; }

        public String getcalcDelta()
        {
            return ((int.Parse(b) * int.Parse(b)) * -(int.Parse(c)) * int.Parse(a) * int.Parse(c)).ToString();
        }

        public String calcX1()
        {
            float aa = float.Parse(a);
            float bb = float.Parse(b);
            float cc = float.Parse(c);

            return ((-bb + Math.Sqrt(float.Parse(getcalcDelta())))/(2*aa) ).ToString();
        }

        public String calcX2()
        {
            float aa = float.Parse(a);
            float bb = float.Parse(b);
            float cc = float.Parse(c);

            return ((-bb - Math.Sqrt(float.Parse(getcalcDelta()))) / (2 * aa)).ToString();
        }
    }

}
