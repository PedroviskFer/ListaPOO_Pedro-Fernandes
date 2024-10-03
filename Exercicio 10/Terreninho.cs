using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{/*10. Calcular e exibir a área de um retângulo, a partir dos valores da base e altura que serão
digitados.Se a área for maior que 100, exibir a mensagem “Terreno grande”, caso contrário, exibir
a mensagem “Terreno pequeno”*/
    internal class Terreninho
    {   private int baseRetangulo;
        private int alturaRetangulo;
        private int area;
        public void SetValores(int baseRet, int alturaRet)
        {
            this.baseRetangulo = baseRet;
            this.alturaRetangulo = alturaRet;
        }
        public void CalcularArea()
        {
            this.area = baseRetangulo * alturaRetangulo;
        }
        public int GetArea()
        {
            return this.area;
        }
        public string ClassificarTerreno()
        {
            if (area > 100)
            {
                return "Terreno grande";
            }
            else
            {
                return "Terreno pequeno";
            }
        }
    }
}

