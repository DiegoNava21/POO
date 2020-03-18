using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Aereo:Vehiculos
    {
        public int numTurbinas, numAlas, numHelices;
        public string tipoAereo;

        public Aereo()
        {
            numAlas = 0;
            numTurbinas = 0;
            numHelices = 0;
            tipoAereo = " ";

        }
        public string enVuelo(string estado)
        {
            return "El " + tipoAereo + "esta volando " + estado;
        }

    }
}
