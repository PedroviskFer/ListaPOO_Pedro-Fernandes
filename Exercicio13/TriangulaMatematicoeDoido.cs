using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{/*13. Verificar se três valores quaisquer (A,B, C) que serão digitados formam ou não um
triângulo retângulo. Lembre-se que o quadrado da hipotenusa é igual a soma dos quadrados dos
catetos. */
    internal class TriangulaMatematicoeDoido
    {   private int a;
        private int b;
        private int c;
        public void SetLados(int ladoA, int ladoB, int ladoC)
        {   this.a = ladoA;
            this.b = ladoB;
            this.c = ladoC;
        }
        public bool EhTrianguloRetangulo()
        {          
            return (a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b);
        }
    }
}
