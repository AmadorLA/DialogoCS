using System;
using System.Collections.Generic;
using System.Text;

namespace DialogoCS
{
    class Articulo
    {
        private string nombre;
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
     
        }

        public Articulo()
        {
            nombre = "";
            precio = 0;
        }
        public override string ToString()
        {
            return nombre + "-" + precio;
        }
    }

}
