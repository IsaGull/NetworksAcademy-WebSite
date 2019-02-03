using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos;


namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDAlumno
    {
        #region Existe Alumno

        public bool Existe(Persona MiAlumno)
        {

            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;

            SqlDataReader entrada;


            try
            {

                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("SELECT id FROM persona WHERE cedula='" + MiAlumno.Cedula + "'", conexion);

                entrada = comando.ExecuteReader();


                if (entrada.Read())
                {
                    return true;

                }

                else
                {
                    return false;

                }

            }

            catch
            {
                return false;

            }

            conexion.Close();
        }

        #endregion

        #region Agregar Alumno

        public bool AgregarAlumno(Persona MiAlumno)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;


            try
            {
                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("Insert into persona (nombre,apellido,correo,telefono,tipo,cedula) values ('" + MiAlumno.Nombre + "','" + MiAlumno.Apellido + "','" + MiAlumno.Correo + "','" + MiAlumno.Telefono + "' , '" + "Alumno" + "', '" + MiAlumno.Cedula + "')", conexion);

                entrada = comando.ExecuteReader();
                conexion.Close();

                return true;
            }

            catch
            {
                return false;
            }

        }


        #endregion

        #region Consultar Persona

        public Persona ConsultarAlumno(string cedula)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;


            try
            {
                conexion = new SqlConnection(cadenaConexion);
                Persona MiConsultaPersona = new Persona();
                conexion.Open();
                comando = new SqlCommand("Select nombre,apellido,correo,telefono,cedula from persona where cedula='" + cedula + "'" + "and tipo='Alumno'", conexion);

                entrada = comando.ExecuteReader();

                if (entrada.Read())
                {


                    MiConsultaPersona.Nombre = entrada.GetValue(0).ToString();
                    MiConsultaPersona.Apellido = entrada.GetValue(1).ToString();
                    MiConsultaPersona.Correo = entrada.GetValue(2).ToString();
                    MiConsultaPersona.Telefono = entrada.GetValue(3).ToString();
                    MiConsultaPersona.Cedula = entrada.GetValue(4).ToString();

                    return MiConsultaPersona;
                }

                else
                {

                    return null;

                }

                conexion.Close();


            }

            catch { return null; }



        }


        #endregion

        #region Modificar Persona

        public bool ModificarAlumno(Persona Mipersona2)
        {

            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;

            SqlConnection conexion2;
            SqlCommand comando2;
            SqlDataReader entrada2;



            try
            {
                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("delete from persona where cedula='" + Mipersona2.Cedula + "'" + "and (tipo='Alumno')", conexion);
                entrada = comando.ExecuteReader();
                conexion.Close();


                conexion2 = new SqlConnection(cadenaConexion);
                conexion2.Open();
                string Alumno = "Alumno";
                comando2 = new SqlCommand("Insert into persona (nombre,apellido,correo,telefono,tipo,cedula) values ('" + Mipersona2.Nombre + "','" + Mipersona2.Apellido + "','" + Mipersona2.Correo + "','" + Mipersona2.Telefono + "' , '"+ Alumno+ "', '" + Mipersona2.Cedula + "')", conexion2);
                entrada2 = comando2.ExecuteReader();
                conexion2.Close();


                return true;
            }



            catch
            {
                return false;
            }


        }




        #endregion
    }
}