using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Program
    {/*10. Calcular e exibir a área de um retângulo, a partir dos valores da base e altura que serão
digitados.Se a área for maior que 100, exibir a mensagem “Terreno grande”, caso contrário, exibir
a mensagem “Terreno pequeno”*/
        static void Main(string[] args)
        {  Terreninho terreninho = new Terreninho();

            Console.WriteLine("Digite o valor da base do retângulo (A base do seu terreninho):");
            int baseRetangulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o a altura do seu terreinho :");
            int alturaRetangulo = Convert.ToInt32(Console.ReadLine());

            terreninho.SetValores(baseRetangulo, alturaRetangulo);
            terreninho.CalcularArea();

            int area = terreninho.GetArea();
            Console.WriteLine("A área do retângulo é: " + area);

            string classificacao = terreninho.ClassificarTerreno();
            Console.WriteLine(classificacao);
        }
    }
}