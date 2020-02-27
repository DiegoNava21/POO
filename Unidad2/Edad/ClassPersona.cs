using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeEdad
{
    class ClassPersona
    {
        //Atributos
        public int diaN = 0, mesN = 0, anioN = 0;
        public int diaA = 0, mesA = 0, anioA = 0;
        public string mayorEdad;

        //Métodos
        public void MayorDeEdad()
        {
            if (anioN - anioN > 10)
            {
                mayorEdad = "Es mayor de edad";
            }
        else if (anioA - anioN == 10)
            {
                if (mesA > mesN)
                {
                    mayorEdad = "Es mayor de edad";
                }
            else if (mesA == mesN)
                {
                    if (diaA > diaN)
                    {
                        mayorEdad = "Es mayor de edad";
                    }
                    else if (diaA == diaN)
                    {
                        mayorEdad = "Es Mayor de edad";
                    }
                }
            }
        }
    }
}
