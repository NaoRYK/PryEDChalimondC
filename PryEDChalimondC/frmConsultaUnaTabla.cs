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
    public partial class frmConsultaUnaTabla : Form
    {
        private clsBaseDatos baseDatos;

        public frmConsultaUnaTabla()
        {
            InitializeComponent();
            baseDatos = new clsBaseDatos();
        }

        private void frmConsultaUnaTabla_Load(object sender, EventArgs e)
        {
            // Populate the combobox with table names
            cboTablas.Items.Clear();
            cboTablas.Items.Add("Autor");
            cboTablas.Items.Add("Libro");
            cboTablas.Items.Add("Idioma");
            cboTablas.Items.Add("Pais");
            
            // Set default selection
            cboTablas.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cboTablas.SelectedItem != null)
            {
                string tablaSeleccionada = cboTablas.SelectedItem.ToString();
                baseDatos.Listar(dgvGrilla, "SELECT * FROM " + tablaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una tabla para listar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
