using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.Objetos;
using Sistema_Fundanet.CapaDatos.ConexionBD;

namespace Sistema_Fundanet.CapaPresentacion.ModInicio
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ConexionBDUsuario MiUsuario = new ConexionBDUsuario();
            Usuario ElUsu = new Usuario();
            ElUsu = MiUsuario.Login(TextBox1.Text);

            if (ElUsu == null)
            {
                Label3.Visible = true;
                Label3.Text = "Error, el Usuario no Existe";
            }

            else 
            {
                if (ElUsu.Contrasena == TextBox2.Text)
                {
                    Response.Redirect("Inicio.aspx");
                }
                
            }

            


            
        }
    }
}