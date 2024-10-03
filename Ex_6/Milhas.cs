using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOOEx6_
{ /* Sabendo que uma milha marítima equivale a um mil, oitocentos e cinqüenta e dois metros
e que um quilômetro possui mil metros, fazer um programa para converter milhas marítimas em
quilômetros. */
    internal class Milhas
    {
        private int m;
        private double km;

        public void SetMilhas(int m)
        {
            this.m = m;
        }
        public int GetMilhas()
        {
            return this.m;
        }
        public double GetQuilometro()
        {
            return this.km;
        }

        public void Calcular()
        {
            this.km = (this.m * 1852) / 1000.00;
        }
    }
}

