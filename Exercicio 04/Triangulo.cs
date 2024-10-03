using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex04
{ /*4. A partir dos valores da base e altura de um triângulo, calcular e exibir sua área. */
    internal class Triangulo
    {
        private int b;
        private int h;
        private int area;

        public void setAltura(int h)
        { this.h = h; 
        }
        public void setBase(int b)
        {
            this.b = b;
        }
        public int getBase()
            { return this.b; 
        }
        public int getAltura()
        {
            return this.h;
        }
        public int getArea()
        {
            return this.area;
        }
        public void Calcularea()
            { this.area = (b * h) / 2; ; 
        }


    }
}
