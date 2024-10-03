using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadradito = new Quadrado();

            Console.WriteLine("escreva o valor da aresta do quadrado");
            int aresta = int.Parse(Console.ReadLine());

            quadradito.SetAresta(aresta);
            quadradito.CalcularA();

            Console.WriteLine("A área vai ser:" + quadradito.GetArea());
            Console.ReadLine();
        }
    }
}
