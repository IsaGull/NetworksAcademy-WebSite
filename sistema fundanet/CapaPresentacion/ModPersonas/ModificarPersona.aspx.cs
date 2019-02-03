using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.Objetos;
using Sistema_Fundanet.CapaDatos.ConexionBD;

namespace Sistema_Fundanet.CapaPresentacion.ModPersonas
{
    public partial class ModificarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ConexionBDPersona MiConex2 = new ConexionBDPersona();
            Persona MiPersona2 = new Persona();

            MiPersona2.Nombre = TextBoxnombre.Text;
            MiPersona2.Apellido = TextBoxapellido.Text;
            MiPersona2.Correo = TextBoxcorreo.Text;
            MiPersona2.Cedula = TextBoxcedula.Text;
            MiPersona2.Estatus = TextBoxestatus.Text;
            MiPersona2.Telefono = TextBoxtelefono.Text;
            MiPersona2.Tipo = TextBoxtipodepersona.Text;

            if (MiConex2.ModificarPersona(MiPersona2))
            {
                Label9Notificacion.Visible=true;
                Label9Notificacion.Text = "Persona Modificada Correctamente";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {

                ConexionBDPersona MiConex = new ConexionBDPersona();
                Persona MiPersona = new Persona();

                if (MiConex.ConsultarPersona(TextBox1cedula.Text) != null)
                {
                    MiPersona = MiConex.ConsultarPersona(TextBox1cedula.Text);
                    TextBoxnombre.Visible = true;
                    TextBoxnombre.Text = MiPersona.Nombre;

                    TextBoxcedula.Visible = true;
                    TextBoxcedula.Text = MiPersona.Cedula;

                    TextBoxcorreo.Visible = true;
                    TextBoxcorreo.Text = MiPersona.Correo;

                    TextBoxtelefono.Visible = true;
                    TextBoxtelefono.Text = MiPersona.Telefono;

                    TextBoxtipodepersona.Visible = true;
                    TextBoxtipodepersona.Text = MiPersona.Tipo;

                    TextBoxapellido.Visible = true;
                    TextBoxapellido.Text = MiPersona.Apellido;

                    TextBoxestatus.Visible = true;
                    TextBoxestatus.Text = MiPersona.Estatus;

                    Label9Notificacion.Visible = false;

                }

                else
                {
                    TextBoxnombre.Visible = false;
                    TextBoxcedula.Visible = false;
                    TextBoxcorreo.Visible = false;
                    TextBoxtelefono.Visible = false;
                    TextBoxtipodepersona.Visible = false;
                    TextBoxapellido.Visible = false;
                    TextBoxestatus.Visible = false;
                    Label9Notificacion.Visible = true;
                    Label9Notificacion.Text = "Error, cedula del personal no existe en el sistema.";
                }

            }
        }
    }
}