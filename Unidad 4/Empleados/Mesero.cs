using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Mesero:Empleado
    {
        private int propinasemanal = 0;
        private double sueldom = 0;

        //Propiedades 
        public int PropinaSemanal
        {
            set { propinasemanal= value; }
            get { return propinasemanal; }

        }
        public double SueldoM
        {
            set { sueldom = value; }
            get { return sueldom; }
        }
        public Mesero()
        {
            propinasemanal = 0;
            sueldom = 0;
        }
        public override void SacarSueldo()
        {
             SueldoM = (Diastra * Sueldo) + PropinaSemanal;
        }

            

          
    }
}
