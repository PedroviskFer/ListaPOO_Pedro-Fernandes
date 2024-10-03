using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadradao = new Quadrado();

            Console.WriteLine("Quanto é a diagonal (hipotenusa) do quadrado?");
            double diagonal = double.Parse(Console.ReadLine());

            quadradao.SetDiagonal(diagonal);
            quadradao.CalcularArea();

            Console.WriteLine("Segundo o que colocou, a área do quadrado vai ser:"+ quadradao.GetArea());
            Console.ReadLine();
        }
    }
}
    
