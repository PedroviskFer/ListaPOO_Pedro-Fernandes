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
            Quadrado quadrado = new Quadrado();

            Console.WriteLine("Quanto é a aresta do quadrado?");
            int aresta = int.Parse(Console.ReadLine());

            quadrado.SetAresta(aresta);
            quadrado.CalArea();

            Console.WriteLine("Segundo o que colocou, a área do quadrado vai ser:"+quadrado.GetArea());         
           
            Console.ReadLine();
        }
    }
}

    

