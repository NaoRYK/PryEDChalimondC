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

        clsGrafo grafo = new clsGrafo();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
