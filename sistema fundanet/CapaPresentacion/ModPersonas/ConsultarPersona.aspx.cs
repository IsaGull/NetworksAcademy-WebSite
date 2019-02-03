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
    public partial class ConsultarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ConexionBDPersona MiConex = new ConexionBDPersona();
            Persona MiPersona = new Persona();

            if (MiConex.ConsultarPersona(TextBox1cedula.Text)!=null)
            {
                MiPersona = MiConex.ConsultarPersona(TextBox1cedula.Text);
                Labelnombre.Visible = true;
                Labelnombre.Text = MiPersona.Nombre;

                Label1cedula.Visible = true;
                Label1cedula.Text = MiPersona.Cedula;

                Label1correo.Visible = true;
                Label1correo.Text = MiPersona.Correo;

                Label1telefono.Visible = true;
                Label1telefono.Text = MiPersona.Telefono;

                Label1tipo.Visible = true;
                Label1tipo.Text = MiPersona.Tipo;

                Label1apellido.Visible = true;
                Label1apellido.Text = MiPersona.Apellido;

                Labelestatus.Visible = true;
                Labelestatus.Text = MiPersona.Estatus;

                Label9Notificacion.Visible = false;

            }

            else
            {
                Labelnombre.Visible = false;
                Label1cedula.Visible = false;
                Label1correo.Visible = false;
                Label1telefono.Visible = false;
                Label1tipo.Visible = false;
                Label1apellido.Visible = false;
                Labelestatus.Visible = false;
                Label9Notificacion.Visible = true;

                Label9Notificacion.Text = "Error, cedula del personal no existe en el sistema.";
            }

        }
    }
}