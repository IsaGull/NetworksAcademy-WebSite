using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.Cursos;

namespace Sistema_Fundanet.CapaPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BAceptar_Click(object sender, EventArgs e)
        {
            ConexionBDCursos objBD = new ConexionBDCursos();
            if (objBD.AgregarCurso(TBNombre.Text, TBModulo.Text))
            {
                LMensaje.Text = "se agrego exitosamente";
            }
            else
            {
                LMensaje.Text = "Error";

            }
        }
    }
}