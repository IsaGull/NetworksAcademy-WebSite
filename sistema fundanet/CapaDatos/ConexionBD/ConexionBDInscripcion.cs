using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos; 

namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDInscripcion
    {
        #region Variables

        string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader entrada;

        #endregion

        #region Agregar Inscripcion

        public bool ExisteAlumno(String ci)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from persona where cedula = '" + ci + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    exito = true;
                conexion.Close();
            }
            catch { }
            return exito;
        }

        public Persona ConsultarAlumno(String ci)
        {
            Persona alumno = new Persona();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select nombre, apellido from persona where cedula = '" + ci + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    alumno.Nombre = entrada.GetValue(0).ToString();
                    alumno.Apellido = entrada.GetValue(1).ToString();
                }
                conexion.Close();
            }
            catch { }
            return alumno;
        }

        public int idAlumno(String ci)
        {
            int id = 0;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from persona where cedula = '" + ci + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    id = int.Parse(entrada.GetValue(0).ToString());
                conexion.Close();
            }
            catch { }
            return id;
        }

        public int idSeccion(String codigo)
        {
            int id = 0;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from seccion where codigo = '" + codigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    id = int.Parse(entrada.GetValue(0).ToString());
                conexion.Close();
            }
            catch { }
            return id;
        }

        public bool AgregarInscripcion(int idAlumno, int idSeccion)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("Insert into inscripcion (fecha, fk_personaalumno, fk_seccion) values ('2015-03-19'," + idAlumno + ", " + idSeccion + ")", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }

        #endregion


        #region Consultar Inscripcion

        public List<Persona> ConsultarListaAlumnos(String codigo)
        {
            List<Persona> ListaAlumnos = new List<Persona>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select p.cedula, p.nombre, p.apellido, i.fecha from persona p, inscripcion i, seccion s where i.fk_personaalumno=p.id and i.fk_seccion = s.id and s.codigo ='" + codigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Persona alumno = new Persona();
                    alumno.Cedula = entrada.GetValue(0).ToString();
                    alumno.Nombre = entrada.GetValue(1).ToString();
                    alumno.Apellido = entrada.GetValue(2).ToString();
                    alumno.Correo = entrada.GetValue(3).ToString();
                    ListaAlumnos.Add(alumno);
                }
                conexion.Close();
            }
            catch { }
            return ListaAlumnos;
        }


        #endregion 
    }
}