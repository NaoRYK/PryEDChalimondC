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
    public partial class frmGrafo : Form
    {
        private clsGrafo grafo = new clsGrafo();

        public frmGrafo()
        {
            InitializeComponent();
            grafo.MostrarTodo(dataGridView1);
            grafo.MostrarCiudades(cmbDesde);
            grafo.MostrarCiudades(cmbHasta);
            grafo.MostrarCiudades(cmbDestinoConsulta);
            grafo.MostrarCiudades(cmbOrigenCarga);
            grafo.MostrarCiudades(cmbOrigenConsulta);
            grafo.MostrarCiudades(cmbOirgenDestino);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigenCarga.SelectedIndex;
            int destino = cmbOirgenDestino.SelectedIndex;

            if (origen == -1 || destino == -1)
            {
                MessageBox.Show("Por favor, seleccione el origen y el destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCarga.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido (mayor o igual a cero).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCarga.Focus();
                return;
            }

            grafo.Agregar(origen, destino, precio);
            grafo.MostrarTodo(dataGridView1);
            txtPrecioCarga.Clear();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea borrar todos los viajes del grafo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                grafo.BorrarTodo();
                grafo.MostrarTodo(dataGridView1);
                label1.Text = "";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigenConsulta.SelectedIndex;
            int destino = cmbDestinoConsulta.SelectedIndex;

            if (origen == -1 || destino == -1)
            {
                MessageBox.Show("Por favor, seleccione el origen y el destino para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal precio = grafo.Consultar(origen, destino);
            label1.Text = precio.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int origen = cmbOrigenConsulta.SelectedIndex;
            int destino = cmbDestinoConsulta.SelectedIndex;

            if (origen == -1 || destino == -1)
            {
                MessageBox.Show("Por favor, seleccione el origen y el destino para eliminar el viaje.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grafo.Eliminar(origen, destino);
            grafo.MostrarTodo(dataGridView1);
            label1.Text = "";
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            int origen = cmbDesde.SelectedIndex;
            if (origen == -1)
            {
                MessageBox.Show("Seleccione una ciudad de origen.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grafo.MostrarDestinos(origen, dataGridView1);
        }

        private void btnListarOrigen_Click(object sender, EventArgs e)
        {
            int destino = cmbHasta.SelectedIndex;
            if (destino == -1)
            {
                MessageBox.Show("Seleccione una ciudad de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grafo.MostrarOrigenes(destino, dataGridView1);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
