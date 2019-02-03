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
    public partial class AgregarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Persona MiAlumno = new Persona();
            ConexionBDAlumno MiConex = new ConexionBDAlumno();

            if ((Label1Telefono.Text == "") | (Label1Nombre.Text == "") | (Label1Apellido.Text == "") | (Label1Correo.Text == "") | (Label1Cedula.Text == ""))
            {
                Label1Notificacion.Visible = true;
                Label1Notificacion.Text = "Error, Campos Vacios.";
            }

            else
            {



                MiAlumno.Nombre = Label1Nombre.Text;
                MiAlumno.Apellido = Label1Apellido.Text;
                MiAlumno.Correo = Label1Correo.Text;
                MiAlumno.Telefono = Label1Telefono.Text;
                MiAlumno.Cedula = Label1Cedula.Text;
                MiAlumno.Tipo = "Estudiante";

                if (!MiConex.Existe(MiAlumno))
                {

                    if (MiConex.AgregarAlumno(MiAlumno))
                    {
                        Label1Notificacion.Visible = true;
                        Label1Notificacion.Text = "Persona Agregada Correctamente.";
                    }

                    else
                    {
                        Label1Notificacion.Visible = true;
                        Label1Notificacion.Text = "Error, la persona no puedo ser agregada al sistema.";
                    }
                }

                else
                {
                    Label1Notificacion.Visible = true;
                    Label1Notificacion.Text = "Error, La Persona ya existe.";
                }


            }
        }
    }
}