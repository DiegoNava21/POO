using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseta_de_Autopista
{
    class ClassVehivulo
    {
        //Atributos de la clase
        public string tipo;
        public int Cobro = 0;

        //Metodo de la clase
        public void CantidadCosto()
        {
         switch(tipo)
          {     
               case"Motociclista":
                {
                    Cobro= 50;
                    break;
                }
               case"Automovil":
                 {
                    Cobro = 112;
                        break;
                 }
               case"Autobus":
                 {
                    Cobro = 170;
                        break;
                 }
               case"Trailer":
                 {
                    Cobro = 170;
                    break;
                 }
            
            }    
         }





    }
}
