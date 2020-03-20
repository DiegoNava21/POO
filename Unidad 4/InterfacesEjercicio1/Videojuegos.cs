using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    abstract class Videojuegos
    {
        private int añoes = 0;
        private double precio = 0;
        private string nombre = "";

        //Propiedades
        public string Nombre
        {
           set { nombre = value; }
           get { return nombre; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public int AñoEs
        {
            set { añoes = value; }
            get { return añoes; }
        }

        public Videojuegos()
        {
            precio = 0;
            añoes = 0;
        }
        public abstract void SacarPrecio();

    }

}
