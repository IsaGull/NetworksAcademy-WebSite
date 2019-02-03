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
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ConexionBDUsuario LaConex = new ConexionBDUsuario();

            string resultado= LaConex.EliminarUsuario(LabelBuscar.Text);

            LabelNotificacion.Visible = true;
            LabelNotificacion.Text = resultado;

        }
    }
}