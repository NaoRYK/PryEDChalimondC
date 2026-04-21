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
    public partial class frmCola : Form
    {

        clsCola fila = new clsCola();
        public frmCola()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(fila.Primero != null)
            {

                lblCodigo.Text = Convert.ToString(fila.Primero.Codigo);
                lblNombre.Text = fila.Primero.Nombre;
                lblTextoTramite.Text = fila.Primero.Tramite;
                fila.Eliminar(fila.Primero);
                fila.Recorrer(dgvElementos);
                fila.Recorrer(lstElementos);
            }
             else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTram.Text = "";
                                lblNombre.Text = "";
                                lblCodigo.Text = "";
            }
        }
    }
}
