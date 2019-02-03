using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Fundanet.CapaDatos.Cursos
{
    public class ConexionBDCursos
    {
        #region Agregar curso
        public bool AgregarCurso(string nombre, string modulo)
        {
            bool exito = false;
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;
           
            try
            {
                conexion = new SqlConnection(cadenaConexion);

                int mod = int.Parse(modulo);
                comando = new SqlCommand("Insert into curso (nombre, modulo) values ('" + nombre + "', " + modulo + ")", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();

                conexion.Close();
                exito = true;
                return exito;

            }
            catch
            {
                return exito;
            }
        }
        #endregion

    }
}