using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo:Figura
    {
        //Atributos de la clase
        private int Base = 0, Altura = 0, Area = 0, Perimetro = 0, Lado = 0;

        //Metodo de la clase
        private void Areatriangulo()
        {
            Area = Base * Altura / 2;
        } 
        private void Perimetrotriangulo()
        {
            Perimetro= Lado * 3;
        }
        
    }
}
