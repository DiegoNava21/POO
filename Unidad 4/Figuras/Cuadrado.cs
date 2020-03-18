using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado:Figura
    {
        //Atributos de la clase
        private int Lado = 0, Perimetro = 0, Area = 0;

        //Metodo de la clase
        private void AreaCuadrado()
           {
            Area = Lado * Lado;
           }
        private void PerimetroCuadrado()
           {
            Perimetro = Lado * 4;
           }
    }
}
