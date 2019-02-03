using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos;


namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDRol
    {
        #region Existe Rol

        public bool Existe(String nombre)
        {
            
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
           
            SqlDataReader entrada;
            

            try
                {

                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("SELECT id FROM rol WHERE nombre='" + nombre + "'", conexion);

                entrada = comando.ExecuteReader();
             

                        if (entrada.Read())
                        {
                            return false;
                           
                        }

                        else
                        {
                            return true;
                           
                        }

                 }
          
            catch
                {
                return false;
                
                }

            conexion.Close();
             }

        #endregion


        #region Agregar Rol

        List<string> ListaDeFunciones = new List<string>();

        public bool AgregarRol(string nombre, List<string> ListaDeFunciones)
        {

            bool exito = false;
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlCommand comando2;
            SqlCommand comando3;
            SqlCommand comando4;
            SqlDataReader entrada;
            SqlDataReader entrada2;
            SqlDataReader entrada3;
            SqlDataReader entrada4;

            try
            {
                conexion = new SqlConnection(cadenaConexion);

                conexion.Open();
                comando = new SqlCommand("Insert into rol (nombre) values ('" + nombre + "')", conexion);

                entrada = comando.ExecuteReader();
                conexion.Close();

                SqlConnection conexion2 = new SqlConnection(cadenaConexion);
                conexion2.Open();

                comando2 = new SqlCommand("SELECT id FROM rol WHERE nombre='" + nombre + "'", conexion2);

                entrada2 = comando2.ExecuteReader();
                entrada2.Read();
                int rol = Convert.ToInt32(entrada2.GetValue(0));

                conexion2.Close();




                // Insertar en tabla RolFun

                foreach (string i in ListaDeFunciones)
                {
                    SqlConnection conexion3 = new SqlConnection(cadenaConexion);

                    conexion3.Open();

                    string NombreDeFuncion = i;
                    comando3 = new SqlCommand("Select id from funcion where nombre='" + i + "'", conexion3);

                    entrada3 = comando3.ExecuteReader();
                    entrada3.Read();
                    int funcion = Convert.ToInt32(entrada3.GetValue(0));

                    conexion3.Close();


                    SqlConnection conexion4 = new SqlConnection(cadenaConexion);
                    conexion4.Open();

                    comando4 = new SqlCommand("Insert into rolfun (fk_funcion,fk_rol) values (" + funcion + ", " + rol + ")", conexion4);

                    entrada4 = comando4.ExecuteReader();
                    exito = true;

                    conexion4.Close();

                }



                return exito;


            }
            catch
            {
                return exito;
            }


        }
        #endregion


        #region Consultar Rol



        public Rol ConsultarRol(string nombre)
        {
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            Rol MiRol = new Rol();
            SqlConnection conexion;
            SqlCommand comando;
            SqlCommand comando2;
            SqlCommand comando3;
            SqlCommand comando4;
            SqlDataReader entrada;
            SqlDataReader entrada2;
            SqlDataReader entrada3;
            SqlDataReader entrada4;
            List<int> ListaDeFuncionesConsultar = new List<int>();


            SqlConnection conexion2 = new SqlConnection(cadenaConexion);

            conexion2.Open();

            comando2 = new SqlCommand("SELECT id,nombre FROM rol WHERE nombre='" + nombre + "'", conexion2);

            entrada2 = comando2.ExecuteReader();
            entrada2.Read();

            string NombreRol = entrada2.GetValue(1).ToString();
            MiRol.MedotoNombre = NombreRol;

            int IdRol = Convert.ToInt32(entrada2.GetValue(0));

            conexion2.Close();

            //Este Select Viene Con 3 valores.
            SqlConnection conexion3 = new SqlConnection(cadenaConexion);

            conexion3.Open();

            comando3 = new SqlCommand("SELECT fk_funcion FROM rolfun WHERE fk_rol=" + IdRol, conexion3);

            entrada3 = comando3.ExecuteReader();

            /* while (entrada3.HasRows)
             {
                 entrada3.Read();
                 ListaDeFuncionesConsultar.Add(Convert.ToInt32(entrada3.GetValue(0)));
             }*/

            while (entrada3.Read())
            {
                ListaDeFuncionesConsultar.Add(Convert.ToInt32(entrada3.GetValue(0)));
            }

            // Llenar Lista de Funciones, el select de arriba viene con 3 valores

            conexion3.Close();







            foreach (int i in ListaDeFuncionesConsultar)
            {
                SqlConnection conexion4 = new SqlConnection(cadenaConexion);

                conexion4.Open();

                SqlDataReader entrada5;

                comando4 = new SqlCommand("SELECT nombre FROM funcion WHERE id=" + i, conexion4);

                entrada5 = comando4.ExecuteReader();

                entrada5.Read();

                MiRol.MetodoListaDeFunciones.Add(entrada5.GetValue(0).ToString());


                conexion4.Close();
            }

            return MiRol;
        }

        #endregion


        #region Eliminar Rol

        public bool EliminarRol(string nombre)
        {

            bool exito = false;
            string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
            SqlConnection conexion;
            SqlCommand comando;
            SqlCommand comando2;
            SqlCommand comando3;
            SqlCommand comando4;
            SqlDataReader entrada;
            SqlDataReader entrada2;
            SqlDataReader entrada3;
            SqlDataReader entrada4;

            //Hacer un select para saber el id del rol seleccionado

            try
            {
                SqlConnection conexion2 = new SqlConnection(cadenaConexion);

                conexion2.Open();

                comando2 = new SqlCommand("SELECT id FROM rol WHERE nombre='" + nombre + "'", conexion2);

                entrada2 = comando2.ExecuteReader();
                entrada2.Read();

                int IdRol = Convert.ToInt32(entrada2.GetValue(0));

                conexion2.Close();

                //Borrar de rolfun el rol
                SqlConnection conexion3 = new SqlConnection(cadenaConexion);

                conexion3.Open();

                comando3 = new SqlCommand("DELETE FROM rolfun WHERE fk_rol=" + IdRol, conexion3);

                entrada3 = comando3.ExecuteReader();
                conexion3.Close();

                //Borrar Rol
                SqlConnection conexion4 = new SqlConnection(cadenaConexion);

                conexion4.Open();

                comando4 = new SqlCommand("DELETE FROM rol WHERE id=" + IdRol, conexion4);

                entrada4 = comando4.ExecuteReader();
                conexion4.Close();

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