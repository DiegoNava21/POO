using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Circulo : Figura
    {
        private double Radio = 0, Circunferencia = 0, Area = 0, Perimetro = 0;

        public void AreaCirculo()
         {
            Area = (3.1416 * Radio) * (3.1416 * Radio);
         }
    }
}
