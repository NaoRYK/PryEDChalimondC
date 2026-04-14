using System;
using System.IO;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    public partial class frmDatosAlumno : Form
    {
        // Instancia para manejar los archivos
        clsArchivoTexto objArchivo = new clsArchivoTexto();

        public frmDatosAlumno()
        {
            InitializeComponent();
        }


        private void frmDatosAlumno_Load_1(object sender, EventArgs e)
        {
            CargarComboCarreras();
            ListarAlumnos();
        }

        private void CargarComboCarreras()
        {
            string rutaEjecucion = AppDomain.CurrentDomain.BaseDirectory;
            objArchivo.nombreArchivo = "Carreras.csv";

            if (File.Exists(objArchivo.nombreArchivo))
            {
                string contenido = objArchivo.Leer();


                string[] lineas = contenido.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);


                cboCarrera.Items.Clear();
                if (lineas.Length > 0)
                {
                    cboCarrera.Items.AddRange(lineas);
                }
          
            }
            else
            {
                // 4. Si entra aquí, el archivo no está donde crees
                MessageBox.Show($"¡ERROR! El archivo no existe en:\n{rutaEjecucion}Carreras.csv", "DEBUG - Ruta");
            }
        }


        private void ListarAlumnos()
        {
            objArchivo.nombreArchivo = "Alumnos.csv";
            if (File.Exists(objArchivo.nombreArchivo))
            {
                // Usamos el método de tu clase que recibe el DataGridView
                objArchivo.Leer(dgvAlumnos);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // Cambiamos el destino al archivo de alumnos
            objArchivo.nombreArchivo = "Alumnos.csv";

            if (txtCodigo.Text != "" && txtNombre.Text != "" && cboCarrera.SelectedIndex != -1)
            {
                // Usamos la sobrecarga de 3 parámetros de tu clase
                objArchivo.Guardar(txtCodigo.Text, txtNombre.Text, cboCarrera.Text);

                // Limpieza y actualización
                txtCodigo.Clear();
                txtNombre.Clear();
                cboCarrera.SelectedIndex = -1;
                txtCodigo.Focus();

                ListarAlumnos();
                MessageBox.Show("Alumno grabado correctamente.");
            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarAlumnos();

        }

    }
}