using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    internal class Program
    { /* 8. Entrar via teclado, com dois valores distintos. Exibir o maior deles. */
        static void Main(string[] args)
        {  Comparador comparador = new Comparador();

            Console.WriteLine("COMPARADOR DE VALORES VALOROSOS****:Digite o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            comparador.SetValores(valor1, valor2);
            comparador.CalcularMaior();

            Console.WriteLine("O maior valor é: " + comparador.GetMaiorValor());
        }
    }
}