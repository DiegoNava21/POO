using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasVacaciones
{
    class ClassEmpleado
    {
        //Atributos
        public int aniosTrabajo = 0;
        public int DDV = 0;

        //Métodos
        public void Vacaciones()
        {
            if (aniosTrabajo>0 & aniosTrabajo<=5)
            {
                DDV = DDV + 5;
            }
            else if (aniosTrabajo>=6 & aniosTrabajo<=10)
            {
                DDV = DDV + 10;
            }
            else if (aniosTrabajo>=11 & aniosTrabajo<20)
            {
                DDV = 10 + ((aniosTrabajo - 10) * 1);
            }
            else if (aniosTrabajo>=21)
            {
                DDV = 10 + ((aniosTrabajo- 10) * 1);
            }
            if (DDV>45)
            {
                DDV = 45;
            }
         }
     }
}
