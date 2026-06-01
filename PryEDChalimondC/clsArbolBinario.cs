using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    class clsArbolBinario
    {
        private clsNodoArbol raiz = null;

        public void Agregar(clsNodoArbol Nuevo)
        {
            if (raiz == null) {
                raiz = Nuevo;
            }
            else { 
               /* if(Nuevo.Codigo < raiz.Codigo && raiz.Izquierda ==null)
                {   
                    raiz.Izquierda = Nuevo;
                }
                else if(Nuevo.Codigo > raiz.Codigo && raiz.Derecha == null)
                {

                    raiz.Derecha = Nuevo;
                }
                else */
                //{
                    clsNodoArbol _raiz = raiz;
                    clsNodoArbol _padre = null;
                    while (_raiz != null)
                    {

                        _padre = _raiz;
                        if (Nuevo.Codigo == _raiz.Codigo) return;
                        if (Nuevo.Codigo < _raiz.Codigo)
                        {
                            _raiz = _raiz.Izquierda;
                        }
                        else
                        {
                            _raiz = _raiz.Derecha;
                        }
                    }
                    if(Nuevo.Codigo < _padre.Codigo)
                    {
                        _padre.Izquierda = Nuevo;
                    }
                    else
                    {
                        _padre.Derecha = Nuevo;
                    }


                //}
            }
        }

        public clsNodoArbol Buscar(int codigo) { 
        
            if(raiz == null)
            {
                //No hay nodos
                return null;
            }
            else
            {

                clsNodoArbol _aux = raiz;
                while (_aux != null)
                {
                    if (codigo == _aux.Codigo) {
                        //encontrado

                        return _aux;
                        
                    }
                    else
                    {
                        if(codigo < _aux.Codigo)
                        {
                            _aux = _aux.Izquierda;
                        }
                        else
                        {
                            _aux = _aux.Derecha;
                        }
                    }
                }
                return _aux;

            }
        }

        public clsNodoArbol BuscarRecursivo(int codigo, clsNodoArbol nodo)
        {
            if (nodo == null)
                return null;

            if (codigo == nodo.Codigo)
                return nodo;

            if (codigo < nodo.Codigo)
                return BuscarRecursivo(codigo, nodo.Izquierda);
            else
                return BuscarRecursivo(codigo, nodo.Derecha);
        }

        public clsNodoArbol Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        public void Recorrer(TreeView tv)
        {
            tv.Nodes.Clear();
            TreeNode nodoRaiz = new TreeNode("Árbol");
            tv.Nodes.Add(nodoRaiz);
            if (raiz != null)
            {
                GraficarArbol(raiz, nodoRaiz);
            }
            tv.ExpandAll();
        }

        private void GraficarArbol(clsNodoArbol R, TreeNode nodoPadre)
        {
            TreeNode nuevoNodo = new TreeNode(R.Codigo.ToString());
            nodoPadre.Nodes.Add(nuevoNodo);
            if (R.Izquierda != null)
            {
                GraficarArbol(R.Izquierda, nuevoNodo);
            }
            if (R.Derecha != null)
            {
                GraficarArbol(R.Derecha, nuevoNodo);
            }
        }

        public void InOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrden(raiz, grilla);
        }

        private void InOrden(clsNodoArbol R, DataGridView grilla)
        {
            if (R == null) return;
            InOrden(R.Izquierda, grilla);
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            InOrden(R.Derecha, grilla);
        }

        public void PreOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PreOrden(raiz, grilla);
        }

        private void PreOrden(clsNodoArbol R, DataGridView grilla)
        {
            if (R == null) return;
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            PreOrden(R.Izquierda, grilla);
            PreOrden(R.Derecha, grilla);
        }

        public void PostOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PostOrden(raiz, grilla);
        }

        private void PostOrden(clsNodoArbol R, DataGridView grilla)
        {
            if (R == null) return;
            PostOrden(R.Izquierda, grilla);
            PostOrden(R.Derecha, grilla);
            grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void InOrden(ComboBox combo)
        {
            combo.Items.Clear();
            InOrden(raiz, combo);
        }

        private void InOrden(clsNodoArbol R, ComboBox combo)
        {
            if (R == null) return;
            InOrden(R.Izquierda, combo);
            combo.Items.Add(R.Codigo);
            InOrden(R.Derecha, combo);
        }

        public void InOrden(ListBox lista)
        {
            lista.Items.Clear();
            InOrden(raiz, lista);
        }

        private void InOrden(clsNodoArbol R, ListBox lista)
        {
            if (R == null) return;
            InOrden(R.Izquierda, lista);
            lista.Items.Add(R.Codigo);
            InOrden(R.Derecha, lista);
        }

        public void InOrden(StreamWriter sw)
        {
            InOrden(raiz, sw);
        }

        private void InOrden(clsNodoArbol R, StreamWriter sw)
        {
            if (R == null) return;
            InOrden(R.Izquierda, sw);
            sw.WriteLine(R.Codigo + ";" + R.Nombre + ";" + R.Tramite);
            InOrden(R.Derecha, sw);
        }

        public void PreOrden(StreamWriter sw)
        {
            PreOrden(raiz, sw);
        }

        private void PreOrden(clsNodoArbol R, StreamWriter sw)
        {
            if (R == null) return;
            sw.WriteLine(R.Codigo + ";" + R.Nombre + ";" + R.Tramite);
            PreOrden(R.Izquierda, sw);
            PreOrden(R.Derecha, sw);
        }

        public void PostOrden(StreamWriter sw)
        {
            PostOrden(raiz, sw);
        }

        private void PostOrden(clsNodoArbol R, StreamWriter sw)
        {
            if (R == null) return;
            PostOrden(R.Izquierda, sw);
            PostOrden(R.Derecha, sw);
            sw.WriteLine(R.Codigo + ";" + R.Nombre + ";" + R.Tramite);
        }

        public void Recorrer(string archivo, string tipo)
        {
            using (StreamWriter sw = new StreamWriter(archivo, false, Encoding.UTF8))
            {
                sw.WriteLine("Listado del arbol - " + tipo);
                sw.WriteLine("Codigo;Nombre;Tramite");
                if (tipo == "In-Orden") InOrden(sw);
                else if (tipo == "Pre-Orden") PreOrden(sw);
                else if (tipo == "Post-Orden") PostOrden(sw);
            }
        }

        public void Eliminar(int codigo)
        {
            raiz = EliminarNodo(raiz, codigo);
        }

        private clsNodoArbol EliminarNodo(clsNodoArbol actual, int codigo)
        {
            if (actual == null) return null;

            if (codigo < actual.Codigo)
            {
                actual.Izquierda = EliminarNodo(actual.Izquierda, codigo);
            }
            else if (codigo > actual.Codigo)
            {
                actual.Derecha = EliminarNodo(actual.Derecha, codigo);
            }
            else
            {
                if (actual.Izquierda == null)
                {
                    return actual.Derecha;
                }
                else if (actual.Derecha == null)
                {
                    return actual.Izquierda;
                }

                clsNodoArbol sucesor = ObtenerMinimo(actual.Derecha);
                actual.Codigo = sucesor.Codigo;
                actual.Nombre = sucesor.Nombre;
                actual.Tramite = sucesor.Tramite;
                actual.Derecha = EliminarNodo(actual.Derecha, sucesor.Codigo);
            }
            return actual;
        }

        private clsNodoArbol ObtenerMinimo(clsNodoArbol nodo)
        {
            clsNodoArbol actual = nodo;
            while (actual.Izquierda != null)
            {
                actual = actual.Izquierda;
            }
            return actual;
        }

        public void Equilibrar()
        {
            List<clsNodoArbol> nodos = new List<clsNodoArbol>();
            CargarListaInOrden(raiz, nodos);
            raiz = null;
            EquilibrarArbol(nodos, 0, nodos.Count - 1);
        }

        private void CargarListaInOrden(clsNodoArbol nodo, List<clsNodoArbol> nodos)
        {
            if (nodo == null) return;
            CargarListaInOrden(nodo.Izquierda, nodos);
            nodos.Add(nodo);
            CargarListaInOrden(nodo.Derecha, nodos);
        }

        private void EquilibrarArbol(List<clsNodoArbol> nodos, int inicio, int fin)
        {
            if (inicio > fin) return;
            int medio = (inicio + fin) / 2;
            clsNodoArbol aux = nodos[medio];
            aux.Izquierda = null;
            aux.Derecha = null;
            Agregar(aux);
            EquilibrarArbol(nodos, inicio, medio - 1);
            EquilibrarArbol(nodos, medio + 1, fin);
        }
    }
}

