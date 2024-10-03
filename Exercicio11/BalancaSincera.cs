using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class BalancaSincera
    {   private int peso;
        private int altura;
        private int relacao;
        public void SetPesoEAltura(int peso, int altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public void CalcularRelacao()
        {
            this.relacao = peso/((altura/ 100)* (altura / 100)); 
        }
        public string VerificarPesoIdeal()
        {
            if (relacao<20)
            {
                return "Abaixo do peso (Tá na hora de comer mais, hein Gatao?)";
            }
            else if (relacao >= 20&&relacao < 25)
            {
                return "Peso ideal (Olha você aí, no ponto!)";
            }
            else
            {
                return "Acima do peso (A balança chorou, bora cuidar, meu amigo!)";
            }
        }
    }
}
 
