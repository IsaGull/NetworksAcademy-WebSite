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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Label1Nombre.Text != "" & LabelPregunta.Text != "" & LabelPregunta.Text != "" & LabelRespuesta.Text != "")
            {
                Usuario MiUsuario = new Usuario();
                ConexionBDUsuario Miconex = new ConexionBDUsuario();

                MiUsuario.Nombre = Label1Nombre.Text;
                MiUsuario.Contrasena = TextBoxpassword.Text;
                MiUsuario.Pregunta = LabelPregunta.Text;
                MiUsuario.Respuesta = LabelRespuesta.Text;
                MiUsuario.FkRol = Convert.ToInt32(DropDownRol.SelectedValue);
                MiUsuario.FkPersona = Convert.ToInt32(DropDownPersona.SelectedValue);


                if (Miconex.AgregarUsuario(MiUsuario))
                {
                    LabelNotificacion.Visible = true;
                    LabelNotificacion.Text = "Usuario Agregado Correctamente.";
                }
                else
                {
                    LabelNotificacion.Visible = true;
                    LabelNotificacion.Text = "Error, el usuario no pudo ser agregado.";
                }
            }

            else
            {
                LabelNotificacion.Visible = true;
                LabelNotificacion.Text = "Error, Campos Vacios.";
            }

                




        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}