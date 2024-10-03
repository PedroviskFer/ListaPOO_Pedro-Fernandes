using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_09
{
    internal class Comparador
    {   private int valor1;
        private int valor2;
        public void SetValores(int v1, int v2)
        {
            this.valor1 = v1;
            this.valor2 = v2;
        }
        public string VerificarMaior()
        {
            if (valor1 > valor2)
            {
                return "O maior valor é: " + valor1;
            }
            else if (valor2 > valor1)
            {
                return "O maior valor é: " + valor2;
            }
            else
            {
                return "Os números são idênticos.";
            }
        }
    }
}
