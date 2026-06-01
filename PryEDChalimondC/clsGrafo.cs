using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDChalimondC
{
    internal class clsGrafo
    {

        private String[] Ciudades = new string[] { "Córdoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };
        private Decimal[,] Precio = new decimal[5, 5];


        public void Agregar(int f, int c, Decimal p)
        {
            Precio[f,c] = p;
        }

        public void Eliminar(int f, int c)
        {
            Precio[f, c] = 0;
        }
        public Decimal Consultar(int f, int c) { return Precio[f, c]; }


        public void BorrarTodo()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Precio[c, f] = 0;
                }
            }
        }


        public void MostrarDestinos(int f, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("Col1", "Destino");
            grid.Columns.Add("Col2", "Precio");
            grid.Columns[0].Width = 200;
            grid.Columns[1].Width = 200;

            grid.Rows.Clear();
            for (int c = 0; c < 5; c++)
            {
                if (Precio[f,c] > 0)
                {
                    grid.Rows.Add(Ciudades[c], Precio[f,c]);
                }
            }
        }
        public void MostrarOrigenes(int c, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            grid.Columns.Add("Col1", "Origen");
            grid.Columns.Add("Col2", "Precio");
            grid.Columns[0].Width = 200;
            grid.Columns[1].Width = 200;

            grid.Rows.Clear();
            for (int f = 0;f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    grid.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }

        public void MostrarTodo(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.Columns.Add("NomOrigen", "Origen");
            for(int i =0; i<5; i++)
            {
                grid.Columns.Add("Destino" + i.ToString(), Ciudades[i]);

            }
            for(int f = 0; f<5; f++)
            {
                grid.Rows.Add(Ciudades[f]);
                for(int c = 0; c < 5; c++)
                {
                    grid.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}
