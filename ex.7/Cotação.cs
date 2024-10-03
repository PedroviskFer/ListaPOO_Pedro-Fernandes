using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ex7
{
    internal class Cotação
    {/*7.Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares.
Calcular e exibir o valor correspondente em Reais(R$)*/
        private int cotacaoDoDolar;
        private int quantidadeDeDolares;
        private int valorEmReais;

        public void SetCotacaoDoDolar(int cotacao)
        {
            this.cotacaoDoDolar = cotacao;
        }

        public void SetQuantidadeDeDolares(int quantidade)
        {
            this.quantidadeDeDolares = quantidade;
        }

        public void CalcularValorEmReais()
        {
            this.valorEmReais = this.cotacaoDoDolar * this.quantidadeDeDolares;
        }

        public int GetValorEmReais()
        {
            return this.valorEmReais;
        }
    }
}
