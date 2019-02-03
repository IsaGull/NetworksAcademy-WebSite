using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.Objetos;
using Sistema_Fundanet.CapaDatos.ConexionBD;


namespace Sistema_Fundanet.CapaPresentacion.ModUsuarios
{
    public partial class ConsultarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario MiUsuario = new Usuario();

            ConexionBDUsuario MiConex = new ConexionBDUsuario();

            MiUsuario = MiConex.ConsultarUsuario(LabelBuscar.Text);
            LabelNotificacion.Visible = false;

            if (MiUsuario!= null)
            {
                

                LabelNombre.Text = MiUsuario.Nombre;
                LabelPregunta.Text = MiUsuario.Pregunta;
                LabelRol.Text = MiUsuario.NombreRol;
                LabelPersona.Text = MiUsuario.NombrePersona;
            }

            if (MiUsuario == null)
            {
                LabelNotificacion.Visible = true;
                LabelNotificacion.Text = "Error, usuario no existente";

            }


        }
    }
}