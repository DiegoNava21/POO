using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class ClassVehiculo
    {
        public string tipo;
        public int costo = 0;

        //Metodos de la clase
        public void cantidadpre()
        {
            switch (tipo)
            {
                case "Motociclista":
                    {
                        costo = 50;
                        break;
                    }
                case "Automovil":
                    {
                        costo = 112;
                        break;
                    }
                case "Autobus":
                    {
                        costo = 170;
                        break;
                    }
                case "Trailer":
                    {
                        costo = 250;
                        break;
                    }
            }
        }
    }
}


