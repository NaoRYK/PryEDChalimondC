using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null || Nuevo.Codigo < Primero.Codigo)
            {

                Nuevo.Siguiente = Primero;
                Primero = Nuevo;

            }
            else
            {
              
              
                
                    clsNodo _aux = Primero;
                    while(_aux.Siguiente != null && _aux.Siguiente.Codigo < Nuevo.Codigo )
                    {
                        _aux = _aux.Siguiente;
                    }

                    Nuevo.Siguiente = _aux.Siguiente;

                    _aux.Siguiente = Nuevo;

                
            }
        }


        public void Eliminar(clsNodo eliminado)
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
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
    }
}



