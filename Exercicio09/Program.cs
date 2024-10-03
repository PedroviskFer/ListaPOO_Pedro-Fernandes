using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparador comparador = new Comparador();

            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            comparador.SetValores(valor1, valor2);
            string resultado = comparador.VerificarMaior();

            Console.WriteLine(resultado);
        }
    }
}