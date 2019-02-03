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
    public partial class ModificarUsuario : System.Web.UI.Page
    {

        Usuario MiUsuario = new Usuario();
        Usuario Elusuario = new Usuario();
        ConexionBDUsuario LaConex2 = new ConexionBDUsuario();
        ConexionBDUsuario LaConex3 = new ConexionBDUsuario();
        ConexionBDUsuario LaConex = new ConexionBDUsuario();


        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxpassword.Visible = false;
            LabelPregunta.Visible = false;
            LabelRespuesta.Visible = false;
            DropDownRol.Visible = false;
            DropDownPersona.Visible = false;
            Label1Nombre.Visible = false;

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

                LaConex2.EliminarUsuario(TextBox1.Text);


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



       /*

           if (notificacion == true) { LabelNotificacion.Text = "El usuario fue modificado correctamente"; }

            else
            { 
                LabelNotificacion.Text = "El usuario no pudo ser modificado";
            
            }

            */

        }

        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {


            TextBoxpassword.Visible = true;
            LabelPregunta.Visible = true;
            LabelRespuesta.Visible = true;
            DropDownRol.Visible = true;
            DropDownPersona.Visible = true;
            Label1Nombre.Visible = true;

            MiUsuario = LaConex.ConsultarUsuario(TextBox1.Text);

            if (MiUsuario != null)
            {


               
                Label1Nombre.Text = MiUsuario.Nombre;
                LabelPregunta.Text = MiUsuario.Pregunta;
                LabelRespuesta.Text = MiUsuario.Respuesta;
                TextBoxpassword.Text = MiUsuario.Contrasena;

               
            }

            if (MiUsuario == null)
            {
                LabelNotificacion.Visible = false;
                LabelNotificacion.Visible = true;
                LabelNotificacion.Text = "Error, usuario no existente";

            }


            
        }
    }
}