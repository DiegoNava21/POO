using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
     class Deportes:Videojuegos
    {
        private int preciod = 0;
        private string tipodeporte = "";

        //Porpiedades
        public int PrecioD
        {
           set { preciod = value; }
           get { return preciod; }
        }
        public string TipoDeporte
        {
            set { tipodeporte = value; }
            get { return tipodeporte; }
        }

        public override void SacarPrecio()
        {
            if (AñoEs==2020)
            {
                PrecioD = 1000;
            }
            else if (AñoEs<2020)
            {
                PrecioD = 750;
            }
        }

    }
}
