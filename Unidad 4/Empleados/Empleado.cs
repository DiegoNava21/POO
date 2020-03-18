using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
       abstract class Empleado
    {
        private int fechanac = 0, diastra = 0; 
        private double sueldo = 0;
        private string nombre;

        //Propiedades 
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int FechaNac
        {
            set { fechanac = value; }
            get { return fechanac; }
        }
        public int Diastra
        {
            set { diastra = value; }
            get { return diastra; }
        }
        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public Empleado()
        {
            nombre = "";
            fechanac = 0;
            diastra = 0;
            sueldo = 0;
        }

        public abstract void SacarSueldo();
        
    }
}
