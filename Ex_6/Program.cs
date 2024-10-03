using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace POOOEx6_
{ /* Sabendo que uma milha marítima equivale a um mil, oitocentos e cinqüenta e dois metros
e que um quilômetro possui mil metros, fazer um programa para converter milhas marítimas em
quilômetros. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Milhas milhas = new Milhas();

            Console.WriteLine("CONVERSOR DE MILHAS EM QUILÔMETROS");
            Console.WriteLine("Coloque as milhas que você quer converter:");

            int quantidadeMilhas = int.Parse(Console.ReadLine());
            milhas.SetMilhas(quantidadeMilhas);
            milhas.Calcular();
            Console.WriteLine("...girando engrenagens internas");
            Console.WriteLine ("CONVERSOR DIGITALMENTE DIGITAL em kms:"+ milhas.GetQuilometro());
            Console.WriteLine("...Bip BOp Bum, a porta se abriu!!!!");
           
        }
    }
}
