using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    class ClassAsistente
    {
        //Atributos de la clase
        public int Bebe = 0, num1 = 0;
        public int Niño = 0, num2 = 0;
        public int Adulto = 0, num3 = 0;
        public int Terceraedad = 0, num4 = 0;
        public string persona;

        //Metodo de la clase
        public void Registrar ()
        {
           switch(persona)
           {
                case "Bebe":
                    Bebe = Bebe + num1;
                    break;
                case "Niño":
                    Niño = Niño + num2;
                    break;
                case "Adulto":
                    Adulto = Adulto + num3;
                    break;
                case "Terceraedad":
                    Terceraedad = Terceraedad + num4;
                    break;
                
           }
        }
    }

}
