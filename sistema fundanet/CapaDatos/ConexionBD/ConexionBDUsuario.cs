using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDUsuario
    {

        #region Agregar Usario

        public bool AgregarUsuario(Usuario MiUsuario)
        {


            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;
            bool existe;

            SqlConnection conexion2;
            SqlCommand comando2;
            SqlDataReader entrada2;


            try
            {
                existe = false;
                conexion2 = new SqlConnection(cadenaConexion);

                conexion2.Open();
                comando2 = new SqlCommand("Select id from usuario where fk_persona="+ MiUsuario.FkPersona, conexion2);

                entrada2 = comando2.ExecuteReader();
               

                if (entrada2.Read())
                {
                    existe = true;
                }

                
            }

            catch
            {
                return false;
            }

            conexion2.Close();


            if (existe == false)
            {
                try
                {
                    conexion = new SqlConnection(cadenaConexion);

                    conexion.Open();
                    comando = new SqlCommand("Insert into usuario (nombre,contrasena,preguntasecreta,respuesta,fk_rol,fk_persona) values ('" + MiUsuario.Nombre + "','" + MiUsuario.Contrasena + "','" + MiUsuario.Pregunta + "','" + MiUsuario.Respuesta + "' , " + MiUsuario.FkRol + ", " + MiUsuario.FkPersona + ")", conexion);

                    entrada = comando.ExecuteReader();
                    conexion.Close();

                    return true;
                }

                catch
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
            
        }

        #endregion

        #region Consultar Usuario

        public Usuario ConsultarUsuario(string nombre)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;

            string cadenaConexion2 = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion2;
            SqlCommand comando2;
            SqlDataReader entrada2;

            string cadenaConexion3 = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion3;
            SqlCommand comando3;
            SqlDataReader entrada3;


            Usuario MiUsuario = new Usuario();
            string nombreUsuario;
            string preguntaUsuario;
            string nombrePersona;
            string respuesta;
            int fkPersona;
            int fkRol;
            string contrasena;

            try
            {
                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("Select nombre,preguntasecreta,fk_rol,fk_persona,respuesta,contrasena from usuario where nombre='"+ nombre + "'", conexion);

                entrada = comando.ExecuteReader();

                entrada.Read();

                nombreUsuario = entrada.GetValue(0).ToString();
                preguntaUsuario = entrada.GetValue(1).ToString();
                fkPersona = Convert.ToInt32(entrada.GetValue(3));
                fkRol = Convert.ToInt32(entrada.GetValue(2));
                respuesta = entrada.GetValue(4).ToString();
                contrasena = entrada.GetValue(5).ToString();

                conexion.Close();

               
            }

            catch
            {
                return null;
            }

            try
            {
                conexion2 = new SqlConnection(cadenaConexion2);

                conexion2.Open();
                comando2 = new SqlCommand("Select nombre from persona where id="+ fkPersona.ToString() , conexion2);

                entrada2 = comando2.ExecuteReader();
                entrada2.Read();

              nombrePersona = entrada2.GetValue(0).ToString();

                conexion2.Close();

                
            }

            catch
            {
                return null;
            }


            try
            {
                conexion3 = new SqlConnection(cadenaConexion3);

                conexion3.Open();
                comando3 = new SqlCommand("Select nombre from rol where id="+ fkRol , conexion3);

                entrada3 = comando3.ExecuteReader();
                entrada3.Read();
                string nombreRol = entrada3.GetValue(0).ToString();

                conexion3.Close();

                MiUsuario.Nombre = nombreUsuario;
                MiUsuario.Pregunta = preguntaUsuario;
                MiUsuario.NombreRol = nombreRol;
                MiUsuario.NombrePersona = nombrePersona;
                MiUsuario.Respuesta = respuesta;
                MiUsuario.Contrasena = contrasena;

                return MiUsuario;

            }

            catch
            {
                return null;
            }
        
        
        
        }


        #endregion

        #region Eliminar Usario

        public string EliminarUsuario(string nombre)
        {


            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion2;
            SqlCommand comando2;
            SqlDataReader entrada2;
            string resultado;

            try
            {
                
                conexion2 = new SqlConnection(cadenaConexion);
                conexion2.Open();
                comando2 = new SqlCommand("Delete from usuario where nombre='"+ nombre +"'", conexion2);
                entrada2 = comando2.ExecuteReader();
               

                
                int rows = entrada2.RecordsAffected;
                
                if (rows ==1)
                {
                    resultado = "Usuario Eliminado Correctamente.";
                    conexion2.Close();
                    return resultado;
                }
                

                
                else
                {
                resultado = "El usuario no existe.";
                conexion2.Close();
                return resultado;
                }
                

            }

            catch
            {

                return "Error de conexion con la Base de Datos.";
            }

            


        }

        #endregion

        #region Modificar Usuario

        public Boolean ModificarUsuario(Usuario MiUsuario)
        {
          
            
            return true;

        }
     
        #endregion


        #region Login

        public Usuario Login(string nombre)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlDataReader entrada;



            Usuario MiUsuario = new Usuario();
            string nombreUsuario;
            string preguntaUsuario;
            string respuesta;
            int fkPersona;
            int fkRol;
            string contrasena;

            try
            {
                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("Select nombre,preguntasecreta,fk_rol,fk_persona,respuesta,contrasena from usuario where nombre='" + nombre + "'", conexion);

                entrada = comando.ExecuteReader();

                entrada.Read();

                nombreUsuario = entrada.GetValue(0).ToString();
                preguntaUsuario = entrada.GetValue(1).ToString();
                fkPersona = Convert.ToInt32(entrada.GetValue(3));
                fkRol = Convert.ToInt32(entrada.GetValue(2));
                respuesta = entrada.GetValue(4).ToString();
                contrasena = entrada.GetValue(5).ToString();

                conexion.Close();

                MiUsuario.Nombre = nombreUsuario;
                MiUsuario.Contrasena = contrasena;

                return MiUsuario;


            }

            catch
            {
                return null;
            }

          



        }


        #endregion
    }

    


}