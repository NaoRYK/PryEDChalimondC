using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEDChalimondC
{
    public partial class frmCarreras: Form
    {
        // Instancia de la clase sin modificaciones
        clsArchivoTexto objArchivo = new clsArchivoTexto();

        public frmCarreras()
        {
            InitializeComponent();
            objArchivo.nombreArchivo = "Carreras.csv";
        }

  

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            lstCarreras.Items.Clear();

            if (File.Exists(objArchivo.nombreArchivo))
            {
                string contenido = objArchivo.Leer();

                string[] lineas = contenido.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string fila in lineas)
                {
                    lstCarreras.Items.Add(fila);
                }
            }
            else
            {
                MessageBox.Show("El archivo aún no existe.");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text != "")
            {
                objArchivo.Guardar(txtNombreCarrera.Text);

                txtNombreCarrera.Clear();
                txtNombreCarrera.Focus();
                MessageBox.Show("Datos guardados en " + objArchivo.nombreArchivo);
            }
        }
    }
}
