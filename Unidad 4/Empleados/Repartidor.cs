using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Repartidor:Empleado
    {
        private double sueldore = 0;
        private double propinare = 0;
        private string zonare="";
        private double abonos = 0;

        //Propiedades
        public double SueldoRe
        {
          set { sueldore = value; }
          get { return sueldore; }
        }
        public double PropinaRe
        {
           set { propinare = value; }
           get { return propinare; }
        }
        public string ZonaRe
        {
           set { zonare = value; }
           get { return zonare; }
        }
        public double Abonos
        {
           set { abonos = value; }
           get { return abonos; }
        }
        public override void SacarSueldo()
        {
            if (ZonaRe=="1")
            {
                SueldoRe = Sueldo * (Diastra + 5);

            }
            else if(ZonaRe=="2")
            {
                SueldoRe = Sueldo * (Diastra + 2);
            }

        }
    }
}
