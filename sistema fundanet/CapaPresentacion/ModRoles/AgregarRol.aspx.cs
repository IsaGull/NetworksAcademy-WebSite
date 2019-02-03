using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModRoles
{
    public partial class AgregarRol : System.Web.UI.Page
    {

        List<string> ListaDeRoles = new List<string>();
       

        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario ElUsu = new Usuario();
            Session["loginPersona"] = ElUsu;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConexionBDRol BaseDatos = new ConexionBDRol();
            ConexionBDRol consultarBD = new ConexionBDRol();
            bool validacion = false;

            if ((TextBox1.Text == "") | (ListBox1.Items.Count == 0))
            {
                validacion = false;
            }

            else
            {
                validacion = true;
            }

            for (int i = 0; i <= ListBox1.Items.Count - 1; i++)
            {
                ListaDeRoles.Add(ListBox1.Items[i].Text);
            }

            if (validacion == true)
            {

                if (consultarBD.Existe(TextBox1.Text))
                {

                    if (BaseDatos.AgregarRol(TextBox1.Text, ListaDeRoles))
                    {

                        Label2.Visible = true;
                        Label2.Text = "Rol Agregado correctamente.";

                    }


                    else
                    {
                        Label2.Visible = true;
                        Label2.Text = "Error, el rol no fue agregado al sistema.";

                    }


                }

                else
                {
                    Label2.Visible = true;
                    Label2.Text = "Error, el rol ya existe en el sistema";

                }






            }

            else
            {
                Label2.Visible = true;
                Label2.Text = "Error, campos vacios";
            }
        }
        
                        protected void Button3_Click(object sender, EventArgs e)
                        {
                            ListBox1.Items.Clear();
                        }

                        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
                        {
            

                            ListBox1.Items.Add(DropDownList1.Text);
        
                        }

        

        
         
}
}