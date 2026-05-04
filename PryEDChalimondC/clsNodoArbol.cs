using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDChalimondC
{
    internal class clsNodoArbol
    {
        private Int32 cod;
        private String nom;
        private String tram;



        private clsNodoArbol izq;
        private clsNodoArbol der;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tram; }
            set { tram = value; }
        }


        public clsNodoArbol Izquierda
        {
            get { return izq; }
            set { izq = value; }

        }
        public clsNodoArbol Derecha
        {
            get { return der; }
            set { der = value; }

        }
    }
}
