using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos; 

namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDCursos
    {

        #region Variables

        string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader entrada;

        #endregion

        #region Agregar curso

        public bool ExisteCurso(Curso curso)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from curso where nombre = '" + curso.Nombre + "' and modulo = " + curso.Modulo, conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    exito = true;
                conexion.Close();
            }
            catch { }
            return exito;
        }

        public bool AgregarCurso(Curso curso)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("Insert into curso (nombre, modulo) values ('" + curso.Nombre + "', " + curso.Modulo + ")", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }

        #endregion

        #region Modificar Curso

        public List<String> ConsultarListaCursos()
        {
            List<String> ListaCursos = new List<String>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select distinct nombre from curso", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    ListaCursos.Add(entrada.GetValue(0).ToString());
                }
                conexion.Close();
            }
            catch { }
            return ListaCursos;
        }

        public List<Curso> BuscarModulosDeCurso(String NombreCurso)
        {
            List<Curso> ListaModulos = new List<Curso>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id, modulo from curso where nombre='" + NombreCurso + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Curso micurso = new Curso(Int32.Parse(entrada.GetValue(0).ToString()), entrada.GetValue(1).ToString());
                    ListaModulos.Add(micurso);
                }
                conexion.Close();
            }
            catch { }
            return ListaModulos;
        }

        public bool ModificarCurso(Curso curso)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("UPDATE curso SET  nombre = '" + curso.Nombre + "', modulo = " + curso.Modulo + " WHERE id = " + curso.Id, conexion);

                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }


        #endregion

        #region Eliminar Curso

        public bool EliminarCurso(int id)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("delete from curso where id =" + id, conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }

        #endregion

        #region Consultar Curso

        public List<Curso> BuscarTodosLosCursos()
        {
            List<Curso> ListaModulos = new List<Curso>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id, nombre, modulo from curso", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Curso micurso = new Curso(Int32.Parse(entrada.GetValue(0).ToString()), entrada.GetValue(1).ToString(), entrada.GetValue(2).ToString());
                    ListaModulos.Add(micurso);
                }
                conexion.Close();
            }
            catch { }
            return ListaModulos;
        }

        public List<Curso> BuscarCurso(String nombre)
        {
            List<Curso> ListaModulos = new List<Curso>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id, nombre, modulo from curso where nombre='" + nombre + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Curso micurso = new Curso(Int32.Parse(entrada.GetValue(0).ToString()), entrada.GetValue(1).ToString(), entrada.GetValue(2).ToString());
                    ListaModulos.Add(micurso);
                }
                conexion.Close();
            }
            catch { }
            return ListaModulos;
        }

        #endregion 


    }
}