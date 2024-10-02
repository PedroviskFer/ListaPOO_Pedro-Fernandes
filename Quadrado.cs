using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex2
{
    internal class Quadrado
    {
        private int aresta;
        private int area;

        public void SetAresta(int aresta)
        {
            this.aresta = aresta;
        }
        public int GetAresta()
        {
            return this.aresta;
        }
        public int GetArea()
        {
            return this.area;
        }
        public void CalcularA()
        {
            this.area = (this.aresta * this.aresta) ;
        }
    }
}
