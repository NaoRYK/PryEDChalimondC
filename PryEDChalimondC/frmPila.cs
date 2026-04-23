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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila fila = new clsPila();
   




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigoAdd.Text);
            n.Nombre = txtNameAdd.Text;
            n.Tramite = txtTramAdd.Text;
            fila.Agregar(n);
            fila.Recorrer(dgvElementos);
            fila.Recorrer(lstElementos);

            txtCodigoAdd.Clear();
            txtNameAdd.Clear();
            txtTramAdd.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {

                lblCodigo.Text = Convert.ToString(fila.Primero.Codigo);
                lblNombre.Text = fila.Primero.Nombre;
                lblTramite.Text = fila.Primero.Tramite;
                fila.Eliminar(fila.Primero);
                fila.Recorrer(dgvElementos);
                fila.Recorrer(lstElementos);
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTramite.Text = "";
                lblNombre.Text = "";
                lblCodigo.Text = "";
            }
        }
    }
}
