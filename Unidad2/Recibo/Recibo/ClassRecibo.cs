using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo
{
    class ClassRecibo
    {
        public int cantpagar = 0;
        public int Kilowatts;
        public string TipoContrato;
        //Metodos de la clase
        public void CantidadPagar()
       { 
            if (TipoContrato == "Hogar")
            
                
                if (Kilowatts>0 & Kilowatts<250)
                   {
                      cantpagar = Kilowatts * 0/65;
                   }
                   else if (Kilowatts>251 & Kilowatts<500)
                   {
                      cantpagar = Kilowatts * 0/85;
                   }
                   else if (Kilowatts> 501 & Kilowatts<1200)
                   {
                      cantpagar = Kilowatts * 1/5;                   
                   }
                   else if (Kilowatts>1201 & Kilowatts<2100)
                   {
                      cantpagar = Kilowatts * 2/5;
                   }
                   else if (Kilowatts>=2101)
                   {
                      cantpagar = Kilowatts * 3/5;  
                   }

                else if (TipoContrato=="Negocio")
                {
                    cantpagar = Kilowatts * 5;
                }
                 

               }


        }
}
