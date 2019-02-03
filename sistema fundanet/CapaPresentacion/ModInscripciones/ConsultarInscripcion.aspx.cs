using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModInscripciones
{
    public partial class ConsultarInscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LMensaje.Text = "";
            if (!IsPostBack)
            {
                InicializarTabla();
            }
        }

        public void InicializarTabla()
        {
            DataTable dtAlumnos = new DataTable();
            dtAlumnos.Columns.Add("CI");
            dtAlumnos.Columns.Add("Nombre");
            dtAlumnos.Columns.Add("Apellido");
            dtAlumnos.Columns.Add("Fecha");
            DataRow dr = dtAlumnos.NewRow();
            dr["CI"] = "-";
            dr["Nombre"] = "-";
            dr["Apellido"] = "-";
            dr["Fecha"] = "-";
            dtAlumnos.Rows.Add(dr);
            GridView1.DataSource = dtAlumnos;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        public void LlenarTabla(List<Persona> lista)
        {
            DataTable dtAlumnos = new DataTable();
            dtAlumnos.Columns.Add("CI");
            dtAlumnos.Columns.Add("Nombre");
            dtAlumnos.Columns.Add("Apellido");
            dtAlumnos.Columns.Add("Fecha");

            foreach (Persona alumno in lista)
            {
                DataRow dr = dtAlumnos.NewRow();
                dr["CI"] = alumno.Cedula;
                dr["Nombre"] = alumno.Nombre;
                dr["Apellido"] = alumno.Apellido;
                dr["Fecha"] = alumno.Correo;
                dtAlumnos.Rows.Add(dr);
            }

            GridView1.DataSource = dtAlumnos;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            ConexionBDSeccion BD1 = new ConexionBDSeccion();
            if ((TBCodigo.Text != "") && (BD1.ExisteSeccion(TBCodigo.Text)))
            {
                ConexionBDInscripcion BD = new ConexionBDInscripcion();
                List<Persona> ListaAlumnos = new List<Persona>();
                ListaAlumnos = BD.ConsultarListaAlumnos(TBCodigo.Text);
                LlenarTabla(ListaAlumnos);

            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "No existen coincidencias";
                InicializarTabla();
            }
        }

    }
}