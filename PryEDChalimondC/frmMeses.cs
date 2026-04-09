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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }
        
        
        private void frmMeses_Load(object sender, EventArgs e)
        {
            
        }

            clsArchivoTexto archivo = new clsArchivoTexto();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            archivo.nombreArchivo = "Meses.csv";
            archivo.Guardar(txtMes.Text);


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstMeses.Items.Clear();
            archivo.nombreArchivo = "Meses.csv";
            
            string meses = archivo.Leer();
            lstMeses.Items.Add(meses);


        }
    }
}
