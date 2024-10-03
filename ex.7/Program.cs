using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ex7
{
    internal class Program
    {/*7.Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares.
Calcular e exibir o valor correspondente em Reais(R$)*/
        static void Main(string[] args)
        {
            Cotação cotacao = new Cotação();

            Console.WriteLine("Qual é a cotação do dólar? (Respira fundo antes de responder):");
            int cotacaoDoDolar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantos dólares você tem? (Se não tem, é só chorar):");
            int quantidadeDeDolares = Convert.ToInt32(Console.ReadLine());

            cotacao.SetCotacaoDoDolar(cotacaoDoDolar);
            cotacao.SetQuantidadeDeDolares(quantidadeDeDolares);

            cotacao.CalcularValorEmReais();

            Console.WriteLine("O valor em reais é: R$ " + cotacao.GetValorEmReais() + " (Melhor não olhar muito!)");
        }
    }
}
