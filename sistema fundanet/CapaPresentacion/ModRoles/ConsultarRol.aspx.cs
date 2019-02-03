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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ConexionBDRol consultarBD = new ConexionBDRol();
            Rol MiRol = new Rol();

            MiRol = consultarBD.ConsultarRol(DropDownList1.SelectedValue);

            Label7.Text = MiRol.MedotoNombre;

            foreach (string i in MiRol.MetodoListaDeFunciones)
                ListBox1.Items.Add(i);
        }
    }
}