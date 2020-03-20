using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    class Accion:Videojuegos
    {

        private int descuento = 0, precioa = 0;

        //Propiedades
        public double Descuento
        {
            set { descuento = value; }
            get { return descuento; }
        }
        public int PrecioA
        {
            set { precioa = value; }
            get { return precioa; }
        }
        public override void SacarPrecio()
        {
            if (AñoEs == 2020) 
            { 
                  PrecioA = 1500; 
            }
            else if (AñoEs < 2020)
            {
                PrecioA = 1000;
            }
        }
    }
}
