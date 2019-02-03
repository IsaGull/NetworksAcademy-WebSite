using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModCursos
{
    public partial class ConsultarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LMensaje.Text = "";
            if (!IsPostBack)
            {
                InicializarTabla();
            }
        }

        public void LlenarTabla(List<Curso> lista)
        {
            DataTable dtCursos = new DataTable();
            dtCursos.Columns.Add("Nombre");
            dtCursos.Columns.Add("Módulo");

            foreach (Curso curso in lista)
            {
                DataRow dr = dtCursos.NewRow();
                dr["Nombre"] = curso.Nombre;
                dr["Módulo"] = curso.Modulo;
                dtCursos.Rows.Add(dr);
            }

            GridView1.DataSource = dtCursos;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        public void InicializarTabla()
        {
            DataTable dtCursos = new DataTable();
            dtCursos.Columns.Add("Nombre");
            dtCursos.Columns.Add("Módulo");
            DataRow dr = dtCursos.NewRow();
            dr["Nombre"] = "-";
            dr["Módulo"] = "-";
            dtCursos.Rows.Add(dr);
            GridView1.DataSource = dtCursos;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void BMostrar_Click(object sender, EventArgs e)
        {
            ConexionBDCursos objBD = new ConexionBDCursos();
            List<Curso> ListaCursos = new List<Curso>();
            ListaCursos = objBD.BuscarTodosLosCursos();
            LlenarTabla(ListaCursos);
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            if (TBuscar.Text == "")
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "El campo no puede estar vacío";
                InicializarTabla();
            }
            else
            {
                ConexionBDCursos objBD = new ConexionBDCursos();
                List<Curso> ListaCursos = new List<Curso>();
                ListaCursos = objBD.BuscarCurso(TBuscar.Text);
                if (ListaCursos.Count > 0)
                {
                    LlenarTabla(ListaCursos);
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
}