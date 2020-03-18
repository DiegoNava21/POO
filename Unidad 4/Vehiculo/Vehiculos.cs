using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Vehiculos
    {
       public string tipoCombustible, color;
       public int numLlantas, numPuertas, numVentanas;

        /*Constructor de la clase, es un metodo que se llama igual que la clase y se ejecuta automaticamente al crear el objeto*/
        public void Vehiculo()
        {
            tipoCombustible = "";
            color = "Blanco";
            numLlantas = 0;
            numPuertas = 0;
            numVentanas = 0;
        }

        public string arrancarMotor(string sonido)
        {
            return "se arrancó el motor" + sonido;
        }
        public string pararMotor(string sonido)
        {
            string mensaje;
            mensaje = "se arranco l motor" + sonido;
            return mensaje;
        }
    }
}
