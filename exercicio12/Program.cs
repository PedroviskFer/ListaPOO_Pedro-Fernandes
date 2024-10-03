using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {   Triangulo triangulo = new Triangulo();       
            Console.WriteLine("Digite o valor do primeiro lado:");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado:");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado:");
            int lado3 = Convert.ToInt32(Console.ReadLine());
            
            triangulo.SetLados(lado1, lado2, lado3);
            
            if (triangulo.EhTriangulo())
            {
                Console.WriteLine("Formam um triângulo! " + triangulo.ClassificarTriangulo());
            }
            else
            {
                Console.WriteLine("Esses lados não formam um triângulo! (Tenta de novo!)");
            }
        }
    }
}       