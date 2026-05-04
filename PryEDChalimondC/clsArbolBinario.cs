using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
