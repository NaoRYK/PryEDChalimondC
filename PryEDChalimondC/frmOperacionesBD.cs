using System;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    public partial class frmOperacionesBD : Form
    {
        clsBaseDatos bd = new clsBaseDatos();
        
        public frmOperacionesBD()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Titulo FROM Libro");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Titulo, Año FROM Libro");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT * FROM Libro WHERE IdAutor = 4");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT * FROM Libro WHERE IdAutor = 3 AND IdIdioma = 3");
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT * FROM Libro WHERE Titulo LIKE '%a%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Nombre FROM Idioma UNION SELECT Nombre FROM Pais");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Idioma.Nombre FROM Idioma INNER JOIN Pais ON Idioma.Nombre = Pais.Nombre");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            bd.Listar(dgvOperaciones, "SELECT Nombre FROM Idioma WHERE Nombre NOT IN (SELECT Nombre FROM Pais)");
        }
    }
}
