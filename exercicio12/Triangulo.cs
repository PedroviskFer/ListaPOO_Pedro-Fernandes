using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Triangulo
    {   private int lado1;
        private int lado2;
        private int lado3;
        public void SetLados(int l1, int l2, int l3)
        {
            this.lado1 = l1;
            this.lado2 = l2;
            this.lado3 = l3;
        }
        public bool EhTriangulo()
        { return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
        }
        public string ClassificarTriangulo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Triângulo Equilátero (Todos os lados iguais, coisa rara hein!)";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Triângulo Isósceles (Dois lados iguais, tá quase simétrico!)";
            }
            else
            {
                return "Triângulo Escaleno (Nenhum lado igual, confusão total!)";
            }
        }
    }
}
   
