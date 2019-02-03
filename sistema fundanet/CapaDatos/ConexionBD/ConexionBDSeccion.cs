using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Sistema_Fundanet.CapaDatos.Objetos; 

namespace Sistema_Fundanet.CapaDatos.ConexionBD
{
    public class ConexionBDSeccion
    {
        #region Variables

        string cadenaConexion = "Data Source=localhost;Initial Catalog=Fundanet;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader entrada;

        #endregion

        #region consultas

        public List<String> ConsultarNombreSedes()
        {
            List<String> ListaSedes = new List<String>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select nombre from sede", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    ListaSedes.Add(entrada.GetValue(0).ToString());
                }
                conexion.Close();
            }
            catch { }
            return ListaSedes;
        }

        public List<Salon> BuscarSalonesDeSede(String NombreSede)
        {
            List<Salon> ListaSalones = new List<Salon>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(" Select salon.id, salon.numero from salon, sede where salon.fk_sede=sede.id and sede.nombre='" + NombreSede + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Salon misalon = new Salon(Int32.Parse(entrada.GetValue(0).ToString()), entrada.GetValue(1).ToString());
                    ListaSalones.Add(misalon);
                }
                conexion.Close();
            }
            catch { }
            return ListaSalones;
        }


        #endregion

        #region Agregar Seccion

        public bool ExisteSeccion(String codigo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from seccion where codigo = '" + codigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    exito = true;
                conexion.Close();
            }
            catch { }
            return exito;
        }

        public bool AgregarSeccion(Seccion seccion)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("Insert into seccion (codigo, capacidad, fecha_ini, fecha_fin, costo, fk_curso) values ('" + seccion.Codigo + "'," + seccion.Capacidad + ", '" + seccion.FechaI + "', '" + seccion.FechaF + "', " + seccion.Costo + "," + seccion.IdCurso + ")", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }

        public int BuscarIDSeccion(String codigo)
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

        public bool ExisteHorario(Horario horario)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from horario where dia = '" + horario.Dia + "' and hora_inicio='" + horario.HoraI + "' and hora_fin='" + horario.HoraF + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    exito = true;
                conexion.Close();
            }
            catch { }
            return exito;
        }

        public int BuscarIDHorario(Horario horario)
        {
            int idHor = 0;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select id from horario where dia = '" + horario.Dia + "' and hora_inicio='" + horario.HoraI + "' and hora_fin='" + horario.HoraF + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    idHor = Int32.Parse(entrada.GetValue(0).ToString());
                conexion.Close();
            }
            catch { }
            return idHor;
        }

        public bool AgregarHorario(Horario horario)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(" Insert into horario ( dia, hora_inicio, hora_fin) values ( '" + horario.Dia + "', '" + horario.HoraI + "', '" + horario.HoraF + "')", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch
            {
            }

            return exito;
        }

        public bool AgregarClase(int idSalon, int idHor, int idSecc)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("Insert into clase( fk_salon, fk_horario, fk_seccion) values (" + idSalon + "," + idHor + "," + idSecc + ")", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch
            {
            }
            return exito;
        }


        #endregion

        #region Consultar Seccion

        public Seccion ConsultarSeccion(String Codigo)
        {
            Curso elcurso = new Curso();
            List<Horario> ListaHorario = new List<Horario>();
            Seccion laseccion = new Seccion();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("Select cu.nombre, cu.modulo, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo, ho.dia, ho.hora_inicio, ho.hora_fin, sa.numero from seccion se, curso cu, clase cl, horario ho, salon sa where se.codigo= '" + Codigo + "' and se.fk_curso = cu.id and cl.fk_seccion = se.id and cl.fk_horario = ho.id and cl.fk_salon = sa.id", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    elcurso.NuevoCurso(entrada.GetValue(0).ToString(), entrada.GetValue(1).ToString());
                    laseccion.NuevaSeccion(entrada.GetValue(2).ToString(), int.Parse(entrada.GetValue(3).ToString()), entrada.GetValue(4).ToString(), entrada.GetValue(5).ToString(), double.Parse(entrada.GetValue(6).ToString()));
                    Horario elhorario = new Horario(entrada.GetValue(7).ToString(), TimeSpan.Parse(entrada.GetValue(8).ToString()), TimeSpan.Parse(entrada.GetValue(9).ToString()), entrada.GetValue(10).ToString());
                    ListaHorario.Add(elhorario);
                }
                laseccion.Horario = ListaHorario;
                laseccion.Curso = elcurso;
                conexion.Close();
            }
            catch { }
            return laseccion;
        }

        public List<Seccion> ConsultarListaSecciones(String query)
        {
            List<Seccion> ListaSecciones = new List<Seccion>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(query, conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Seccion laseccion = new Seccion();
                    Curso elcurso = new Curso();
                    elcurso.NuevoCurso(entrada.GetValue(0).ToString(), entrada.GetValue(1).ToString());
                    laseccion.NuevaSeccion(int.Parse(entrada.GetValue(2).ToString()), entrada.GetValue(3).ToString(), int.Parse(entrada.GetValue(4).ToString()), entrada.GetValue(5).ToString(), entrada.GetValue(6).ToString(), double.Parse(entrada.GetValue(7).ToString()));
                    laseccion.Curso = elcurso;
                    ListaSecciones.Add(laseccion);
                }
                conexion.Close();
            }
            catch { }
            return ListaSecciones;
        }

        public List<Horario> ConsultarHorario(int idSecc)
        {
            List<Horario> ListaHorario = new List<Horario>();
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(" Select ho.dia, ho.hora_inicio, ho.hora_fin, sa.numero from clase cl, horario ho, salon sa where cl.fk_seccion = " + idSecc + " and cl.fk_horario = ho.id and cl.fk_salon = sa.id", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                while (entrada.Read())
                {
                    Horario elhorario = new Horario(entrada.GetValue(0).ToString(), TimeSpan.Parse(entrada.GetValue(1).ToString()), TimeSpan.Parse(entrada.GetValue(2).ToString()), entrada.GetValue(3).ToString());
                    ListaHorario.Add(elhorario);
                }
                conexion.Close();
            }
            catch { }
            return ListaHorario;
        }

        #endregion

        #region Eliminar Seccion

        public bool EliminarClase(string codigo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("delete cl from clase cl, seccion se where cl.fk_seccion = se.id and se.codigo ='" + codigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            if (EliminarSeccion(codigo))
            {
                exito = true;
            }
            else
            {
                exito = false;
            }
            return exito;
        }

        public bool EliminarSeccion(string codigo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("delete from seccion where codigo ='" + codigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }



        #endregion 
    }
}