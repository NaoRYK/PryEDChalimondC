



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDChalimondC
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if(Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        public void Eliminar(clsNodo eliminar)
        {
            if(Primero == null)
            {
                Primero = eliminar;
                Ultimo = eliminar;

            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }
    }
}
