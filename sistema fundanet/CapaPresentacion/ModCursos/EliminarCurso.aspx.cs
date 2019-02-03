using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModCursos
{
    public partial class EliminarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConexionBDCursos objBD = new ConexionBDCursos();
                List<String> ListaCursos = new List<String>();
                ListaCursos = objBD.ConsultarListaCursos();
                DDLCurso.Items.Insert(0, new ListItem("Seleccione", "0"));
                int i = 1;
                foreach (String curso in ListaCursos)
                {
                    DDLCurso.Items.Insert(i, new ListItem(curso, curso));
                    i++;
                }
            }
        }

        protected void BEliminar_Click(object sender, EventArgs e)
        {
            ConexionBDCursos objBD = new ConexionBDCursos();
            if (objBD.EliminarCurso(int.Parse(DDLModulo.SelectedValue)))
            {
                LMensaje.ForeColor = System.Drawing.Color.Black;
                LMensaje.Text = "Se eliminó exitosamente";
            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Error con Base de Datos, no se pudo eliminar el curso";
            }
        }

        protected void DDLCurso_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DDLModulo.Items.Clear();
            ConexionBDCursos objBD = new ConexionBDCursos();
            List<Curso> ListaModulos = new List<Curso>();
            ListaModulos = objBD.BuscarModulosDeCurso(DDLCurso.SelectedValue.ToString());
            DDLModulo.Items.Insert(0, new ListItem("Seleccione", "0"));
            int i = 1;
            foreach (Curso mod in ListaModulos)
            {
                DDLModulo.Items.Insert(i, new ListItem(mod.Modulo, mod.Id.ToString()));
                i++;
            }
        }

        protected void DDLModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNombre.Text = DDLCurso.SelectedItem.Text;
            LModulo.Text = DDLModulo.SelectedItem.Text;

        }
   
    }
}