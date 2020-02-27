using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClassCuadrado
    {
        //Atrivutos
        public int lado = 0;
        public int area = 0, Perimetro = 0;

        //Metodo Area
        public void ObtenerArea()
        {
            area = lado * lado;
        }

        //Metodo Perimetro
        public void ObtenerPerimetro()
        {
            Perimetro = lado * 4;
        }


   
    }
}
