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
    public partial class frmArbol : Form
    {
        private clsArbolBinario arbol = new clsArbolBinario();

        public frmArbol()
        {
            InitializeComponent();
        }

        private void RefreshViews()
        {
            // Refresh TreeView
            arbol.Recorrer(trvArbol);

            // Refresh ComboBox with codes
            arbol.InOrden(cmbCodigo);
            if (cmbCodigo.Items.Count > 0)
            {
                cmbCodigo.SelectedIndex = 0;
            }
            else
            {
                cmbCodigo.Text = "";
                cmbCodigo.SelectedIndex = -1;
            }

            // Refresh DataGridView based on selected order option
            RefreshGrid();

            // Clear Input fields
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        private void RefreshGrid()
        {
            if (optInOrden.Checked)
            {
                arbol.InOrden(dgvArbol);
            }
            else if (optPreOrden.Checked)
            {
                arbol.PreOrden(dgvArbol);
            }
            else if (optPostOrden.Checked)
            {
                arbol.PostOrden(dgvArbol);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido en el código.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTramite.Text))
            {
                MessageBox.Show("Por favor, ingrese un trámite.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTramite.Focus();
                return;
            }

            // Check if code already exists in the tree
            if (arbol.Buscar(codigo) != null)
            {
                MessageBox.Show("El código ingresado ya existe en el árbol.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }

            clsNodoArbol nuevo = new clsNodoArbol();
            nuevo.Codigo = codigo;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;

            arbol.Agregar(nuevo);
            RefreshViews();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un código para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
            arbol.Eliminar(codigo);
            RefreshViews();
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                MessageBox.Show("El árbol está vacío. No hay elementos para equilibrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            arbol.Equilibrar();
            RefreshViews();
        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                RefreshGrid();
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                RefreshGrid();
            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
            {
                RefreshGrid();
            }
        }
    }
}
