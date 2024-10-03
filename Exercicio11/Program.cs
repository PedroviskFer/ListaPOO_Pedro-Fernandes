using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{ /*11. Entrar com o peso e a altura de uma determinada pessoa. Após a digitação, exibir se esta
pessoa está ou não com seu peso ideal. Veja tabela da relação peso/altura². */
    internal class Program
    {
        static void Main(string[] args)
        {  BalancaSincera balanca = new BalancaSincera();

            Console.WriteLine("Digite o seu peso (sem virgula, meu nobre):");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua altura (em cm):");
            int altura = Convert.ToInt32(Console.ReadLine());

            balanca.SetPesoEAltura(peso, altura);
            balanca.CalcularRelacao();
            string resultado = balanca.VerificarPesoIdeal();
            Console.WriteLine(resultado);
        }
    }
}