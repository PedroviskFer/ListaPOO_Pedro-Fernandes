using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    internal class Program
    { /*13. Verificar se três valores quaisquer (A,B, C) que serão digitados formam ou não um
triângulo retângulo. Lembre-se que o quadrado da hipotenusa é igual a soma dos quadrados dos
catetos. */
        static void Main(string[] args)
        {  TriangulaMatematicoeDoido triangulo = new TriangulaMatematicoeDoido();
            Console.WriteLine("Pitagoras está querendo cheirar o seu triangulo para ver se aprova.Digite o valor do primeiro lado (A):");
           
            Console.WriteLine("Digite o valor do primeiro lado (A):");
            int ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado :(B):");
            int ladoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado por favore  (C):");
            int ladoC = Convert.ToInt32(Console.ReadLine());

            triangulo.SetLados(ladoA, ladoB, ladoC);

            if (triangulo.EhTrianguloRetangulo())
            {
                Console.WriteLine("Você tem um triângulo retângulo nas mãos! (Pitagoras está orgulhoso! Ele vai sair do Tumulo só para tomar um belo café melita com você)");
            }
            else
            {
                Console.WriteLine("Não é um triângulo retângulo! (Pitagoras desaprova e revira do tumulo!)");
            }
        }
    }
}
