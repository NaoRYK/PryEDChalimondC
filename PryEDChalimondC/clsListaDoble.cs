using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDChalimondC
{
    internal class clsListaDoble
    {
        private clsNodo pri, ult;

        public clsNodo Primero
        {
            get{ return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }


        public void Agregar(clsNodo Nuevo)
        {
             if(Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;

              
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo) {

                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;

                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo _aux = Primero;
                        clsNodo _ant = Primero;
                        while (_aux.Codigo > Nuevo.Codigo)
                        {
                            _ant = _aux;
                            _aux = _aux.Siguiente;
                        }

                        _ant.Siguiente = Nuevo;
                        Nuevo.Anterior = _ant;
                        Nuevo.Siguiente = _aux;
                        _aux.Anterior = Nuevo;

                    }
                }
            }

        }
    }
}
