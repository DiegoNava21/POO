using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Cajero:Empleado
    {
        private double sueldoca = 0;
        private string caja;

        //Prpoiedades
        public double SueldoCa
        {
           set { sueldoca = value; }
           get { return sueldoca; }

        }
        public string Caja
        {
           set { caja = value; }
           get { return caja; }
        }
        public Cajero()
        {
            sueldoca = 0;
            caja = "";
        }
        public override void SacarSueldo()
        {
            if (Caja == "1")
            {
                SueldoCa = Sueldo * Diastra;
            }
            else if(Caja == "2")
            {
                SueldoCa = (Sueldo * Diastra) + (SueldoCa * 0.3);
            }
        }

    }
}
