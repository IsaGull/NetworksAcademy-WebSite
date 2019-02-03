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
    public partial class ModificarAlumno : System.Web.UI.Page
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
                        TextBoxnombre.Visible = true;
                        TextBoxnombre.Text = MiPersona.Nombre;

                        TextBoxcedula.Visible = true;
                        TextBoxcedula.Text = MiPersona.Cedula;

                        TextBoxcorreo.Visible = true;
                        TextBoxcorreo.Text = MiPersona.Correo;

                        TextBoxtelefono.Visible = true;
                        TextBoxtelefono.Text = MiPersona.Telefono;

                     

                        TextBoxapellido.Visible = true;
                        TextBoxapellido.Text = MiPersona.Apellido;

                     

                        Label9Notificacion.Visible = false;

                    }

                    else
                    {
                        TextBoxnombre.Visible = false;
                        TextBoxcedula.Visible = false;
                        TextBoxcorreo.Visible = false;
                        TextBoxtelefono.Visible = false;
                        
                        TextBoxapellido.Visible = false;
                      
                        Label9Notificacion.Visible = true;
                        Label9Notificacion.Text = "Error, cedula del estudiante no existe en el sistema.";
                    }

                
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                ConexionBDAlumno MiConex2 = new ConexionBDAlumno();
                Persona MiPersona2 = new Persona();

                MiPersona2.Nombre = TextBoxnombre.Text;
                MiPersona2.Apellido = TextBoxapellido.Text;
                MiPersona2.Correo = TextBoxcorreo.Text;
                MiPersona2.Cedula = TextBoxcedula.Text;
       
                MiPersona2.Telefono = TextBoxtelefono.Text;
              

                if (MiConex2.ModificarAlumno(MiPersona2))
                {
                    Label9Notificacion.Visible = true;
                    Label9Notificacion.Text = "Alumno Modificado Correctamente";
                }

            }
        }
    }
}