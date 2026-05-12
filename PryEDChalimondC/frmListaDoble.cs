using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
            radioAsc.Checked = true;    
        }

        clsListaDoble lista = new clsListaDoble();

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lista.Primero != null)
            {

                lblCodigo.Text = Convert.ToString(lista.Primero.Codigo);
                lblNombre.Text = lista.Primero.Nombre;
                lblTramite.Text = lista.Primero.Tramite;
                //lista.Eliminar(lista.Primero);
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTextoTramite.Text = "";
                lblNombre.Text = "";
                lblCodigo.Text = "";
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // 1. Intentar la conversión de forma segura
            if (!int.TryParse(txtCodigoAdd.Text, out int codigoValidado))
            {
                // 2. Manejo del error
                MessageBox.Show("Por favor, ingrese un número entero válido en el código.",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoAdd.Focus();
                return; // Detiene la ejecución
            }

            // 3. Si pasó la validación, continuar con la lógica
            clsNodo n = new clsNodo();
            n.Codigo = codigoValidado; // Usamos el valor ya convertido
            n.Nombre = txtNameAdd.Text;
            n.Tramite = txtTramAdd.Text;

            lista.Agregar(n);
            lista.Recorrer(dgvElementos);
            lista.Recorrer(lstElementos);

            // Limpieza
            txtCodigoAdd.Clear();
            txtNameAdd.Clear();
            txtTramAdd.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lista.Primero != null)
            {

                lblCodigo.Text = Convert.ToString(lista.Primero.Codigo);
                lblNombre.Text = lista.Primero.Nombre;
                lblTextoTramite.Text = lista.Primero.Tramite;
                lista.Eliminar(lista.Primero);
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTextoTramite.Text = "";
                lblNombre.Text = "";
                lblCodigo.Text = "";
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            lista.Recorrer();
        }

        private void dgvElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Recorrer(lstElementos.Text, lstElementos, cmbSeleccionado);
        }

        private void radioAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAsc.Checked)
            {
                lista.Recorrer(dgvElementos);
                lista.Recorrer(lstElementos);
            }
            else
            {
                lista.RecorrerDesc(dgvElementos);
                lista.RecorrerDesc(lstElementos);
            }
        }
    }



}
