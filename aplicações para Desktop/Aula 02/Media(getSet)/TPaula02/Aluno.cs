using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPaula02
{
    internal class Aluno
    {
        private String p1, p2, p3, p4;

        public void setP1(String _p1)
        {
            p1 = _p1;
        }

        public void setP2(String _p2)
        {
            p2 = _p2;
        }

        public void setP3(String _p3)
        {
            p3 = _p3;
        }

        public void setP4(String _p4) {
            p4 = _p4;
        }

        public String getP1() { return p1; }
        public String getP2() { return p2; }
        public String getP3() { return p3; }
        public String getP4() { return p4; }

        public String getMedia()
        {
            return ((float.Parse(p1) + float.Parse(p2) + float.Parse(p3) + float.Parse(p4)) / 4).ToString();
        }
    }
}
