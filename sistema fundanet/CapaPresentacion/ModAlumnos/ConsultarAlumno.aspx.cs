using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.Objetos;
using Sistema_Fundanet.CapaDatos.ConexionBD;

namespace Sistema_Fundanet.CapaPresentacion.ModAlumnos
{
    public partial class ConsultarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ConexionBDAlumno MiConex = new ConexionBDAlumno();
            Persona MiPersona = new Persona();

            if (MiConex.ConsultarAlumno(TextBox1cedula.Text) != null)
            {
                MiPersona = MiConex.ConsultarAlumno(TextBox1cedula.Text);
                Labelnombre.Visible = true;
                Labelnombre.Text = MiPersona.Nombre;

                Label1cedula.Visible = true;
                Label1cedula.Text = MiPersona.Cedula;

                Label1correo.Visible = true;
                Label1correo.Text = MiPersona.Correo;

                Label1telefono.Visible = true;
                Label1telefono.Text = MiPersona.Telefono;


                Label1apellido.Visible = true;
                Label1apellido.Text = MiPersona.Apellido;

            }

            else
            {
                Labelnombre.Visible = false;
                Label1cedula.Visible = false;
                Label1correo.Visible = false;
                Label1telefono.Visible = false;
             
                Label1apellido.Visible = false;

                Label9Notificacion.Visible = true;

                Label9Notificacion.Text = "Error, cedula de estudiante no existente en el sistema.";
            }

        }
    }
}