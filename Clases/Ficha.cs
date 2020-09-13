using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2SIPC2.Clases
{
    public class Ficha
    {
        public string color;
        public string columna;
        public string fila;

        public Ficha() 
        {
        }
        public Ficha(string color, string columna, string fila) 
        {
            this.color = color;
            this.columna = columna;
            this.fila = fila;
        }
    }
}