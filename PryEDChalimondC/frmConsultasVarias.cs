using System;
using System.Data;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    public partial class frmConsultasVarias : Form
    {
        private clsBaseDatos bd = new clsBaseDatos();

        public frmConsultasVarias()
        {
            InitializeComponent();
        }

        private void frmConsultasVarias_Load(object sender, EventArgs e)
        {
            cboOperaciones.Items.Add("Todos los libros");
            cboOperaciones.Items.Add("Título y precio");
            cboOperaciones.Items.Add("Libros de más de 100");
            cboOperaciones.Items.Add("Libros con su autor");
            
            cboOperaciones.SelectedIndex = 0;
        }

        private string GetSQLQuery(string option)
        {
            switch (option)
            {
                case "Todos los libros":
                    return "SELECT * FROM Libro";
                case "Título y precio":
                    return "SELECT Titulo, Precio FROM Libro";
                case "Libros de más de 100":
                    return "SELECT * FROM Libro WHERE Precio > 100";
                case "Libros con su autor":
                    return "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                default:
                    return "";
            }
        }

        private void cboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperaciones.SelectedItem != null)
            {
                lblSql.Text = GetSQLQuery(cboOperaciones.SelectedItem.ToString());
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cboOperaciones.SelectedItem != null)
            {
                string sql = GetSQLQuery(cboOperaciones.SelectedItem.ToString());
                bd.Listar(dgvResultados, sql);
            }
        }
    }
}
