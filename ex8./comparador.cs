using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    internal class Comparador
    {   private int valor1;
        private int valor2;
        private int maiorValor;
        /* 8. Entrar via teclado, com dois valores distintos. Exibir o maior deles. */
        public void SetValores(int v1, int v2)
        {
            this.valor1 = v1;
            this.valor2 = v2;
        }

        public void CalcularMaior()
        {
            if (valor1 > valor2)
            {
                maiorValor = valor1;
            }
            else
            {
                maiorValor = valor2;
            }
        }

        public int GetMaiorValor()
        {
            return maiorValor;
        }
    }
}