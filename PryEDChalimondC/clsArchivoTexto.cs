using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PryEDChalimondC
{
    internal class clsArchivoTexto
    {

        public string nombreArchivo = "Colores.csv";

        public void Guardar(string codigo, string nombre)
        {
            StreamWriter sw = new StreamWriter(nombreArchivo, true);
            sw.Write(codigo+";");
            sw.WriteLine(nombre);
            sw.Close();
        }
        public void Guardar(string texto)
        {
            StreamWriter sw = new StreamWriter(nombreArchivo, true);
            sw.WriteLine(texto);
            sw.Close();
        }
        public string Leer()
        {
            StreamReader sr = new StreamReader(nombreArchivo);
            string texto = sr.ReadToEnd();
            sr.Close();
            return texto;
        }
    }
}
