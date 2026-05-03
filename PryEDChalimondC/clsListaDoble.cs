using PryEDChalimondC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if(Nuevo.Codigo < Primero.Codigo)
                {
                    Primero.Anterior = Nuevo;
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    if(Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo _aux = Primero;

                        while(_aux.Siguiente != null && _aux.Siguiente.Codigo < Nuevo.Codigo)
                        {
                            _aux = _aux.Siguiente;
                        }
                        if (_aux.Siguiente == null)
                        {
                            _aux.Siguiente = Nuevo;
                            Nuevo.Anterior = _aux;
                            Ultimo = Nuevo;
                        }
                        else
                        {
                            Nuevo.Anterior = _aux;
                            Nuevo.Siguiente = _aux.Siguiente;
                            _aux.Siguiente.Anterior = Nuevo;
                            _aux.Siguiente = Nuevo;
                        }

                          
                      
                    }
                }

            }
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaSimple.txt", true, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");

            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }

        public void Eliminar(clsNodo nodoEliminado)
        {
            if (Primero == null) return;

            // es unico nodo?
            if (nodoEliminado.Anterior == null && nodoEliminado.Siguiente == null)
            {
                Primero = null;
                Ultimo = null;
            }
            // es el primero?
            else if (nodoEliminado.Anterior == null)
            {
                Primero = nodoEliminado.Siguiente;
                Primero.Anterior = null;
            }
            // es el último?
            else if (nodoEliminado.Siguiente == null)
            {
                Ultimo = nodoEliminado.Anterior;
                Ultimo.Siguiente = null;
            }
            // esta en el medio?
            else
            {
                nodoEliminado.Anterior.Siguiente = nodoEliminado.Siguiente;
                nodoEliminado.Siguiente.Anterior = nodoEliminado.Anterior;
            }

            nodoEliminado.Anterior = null;
            nodoEliminado.Siguiente = null;
        }
    }
}
/* 
if (Primero == null)
{
    Primero = Nuevo;
    Ultimo = Nuevo;


}
else
{
    if (Nuevo.Codigo < Primero.Codigo)
    {

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
}  */