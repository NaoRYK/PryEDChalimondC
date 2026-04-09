using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.nombreArchivo = "Clientes.csv";

            // 1. Guardamos los datos nuevos
            x.Guardar(txtCodigo.Text, txtDeuda.Text, txtNombre.Text);

            x.Leer(dgvClientes);
        }
    }
}
