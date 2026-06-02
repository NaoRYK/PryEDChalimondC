using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace PryEDChalimondC
{
    class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexionBackup = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";




        public void Listar(DataGridView Grilla, String intstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = intstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error al listar datos:\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        public void Listar(DataGridView Grilla, string tabla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];

                conexion.Close();
            }
            catch (Exception)
            {
                try
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                    conexion.ConnectionString = CadenaConexionBackup;
                    conexion.Open();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = tabla;

                    DataSet DS = new DataSet();
                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(DS, tabla);

                    Grilla.DataSource = null;
                    Grilla.DataSource = DS.Tables[tabla];

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos:\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/
    }
}
