using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2y3
{
    class ClassVehiculo
    {   //Atributos de la clase
        public string tipo;
        public int precio = 0;

        //Metodos de la clase
        public void cantidadcosto()
        {
            switch (tipo)
            {
                case "Motociclista":
                    {
                        precio = 50;
                        break;
                    }
                case "Automovil":
                    {
                        precio = 112;
                        break;
                    }
                case "Autobus":
                    {
                        precio = 170;
                        break;
                    }
                case "Trailer":
                    {
                        precio = 250;
                        break;
                    }
            }
        }
    }
}

