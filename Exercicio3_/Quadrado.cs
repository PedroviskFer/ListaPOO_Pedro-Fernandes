using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO_ex3
{
    internal class Quadrado
    {
        private double diagonal;
        private double area;

        public void SetDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }
                public double GetDiagonal()
        {
            return this.diagonal;
        }
        public double GetArea()
        {
            return this.area;
        }
        public void CalcularArea()
        {          
            this.area = (this.diagonal * this.diagonal) / 2;
        }
    }
}
