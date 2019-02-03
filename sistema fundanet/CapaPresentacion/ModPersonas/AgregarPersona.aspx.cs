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
    public partial class AgregarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListTipo.Items.Clear();
                DropDownListTipo.Items.Add("Seleccionar");
                DropDownListTipo.Items.Add("Administrativo");
                DropDownListTipo.Items.Add("Instructor");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Persona MiPersona = new Persona();
             ConexionBDPersona MiConex = new ConexionBDPersona();

            if ((LabelTelefono.Text == "") | (Label1Nombre.Text == "") | (LabelApellido.Text == "") | (LabelCorreo.Text == "") | (LabelCedula.Text == "") | (DropDownListTipo.SelectedValue == "Seleccionar"))
            {
                LabelNotificacion.Visible = true;
                LabelNotificacion.Text = "Error, Campos Vacios.";
            }

            else
            {
                
               

                        MiPersona.Nombre = Label1Nombre.Text;
                        MiPersona.Apellido = LabelApellido.Text;
                        MiPersona.Correo = LabelCorreo.Text;
                        MiPersona.Telefono = LabelTelefono.Text;
                        MiPersona.Cedula = LabelCedula.Text;
                        MiPersona.Tipo = DropDownListTipo.SelectedValue;

                        if (!MiConex.Existe(MiPersona))
                        {

                                if (MiConex.AgregarPersona(MiPersona))
                                {
                                    LabelNotificacion.Visible = true;
                                    LabelNotificacion.Text = "Persona Agregada Correctamente.";
                                    LabelTelefono.Text = "";
                                    LabelCorreo.Text = "";
                                    LabelCedula.Text = "";
                                    Label1Nombre.Text = "";
                                    LabelApellido.Text = "";
                                }

                                else
                                {
                                    LabelNotificacion.Visible = true;
                                    LabelNotificacion.Text = "Error, la persona no puedo ser agregada al sistema.";
                                }
                        }

                        else
                
                        {
                            LabelNotificacion.Visible = true;
                            LabelNotificacion.Text = "Error, La Persona ya existe.";
                        }

                    
                }
            }
      }
 }
