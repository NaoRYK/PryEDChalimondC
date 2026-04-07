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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnCargarColor_Click(object sender, EventArgs e)
        {
            clsArchivoTexto archivo = new clsArchivoTexto();
            archivo.Guardar(txtColor.Text);
            MessageBox.Show("Color guardado correctamente.");

        }
    }
}
