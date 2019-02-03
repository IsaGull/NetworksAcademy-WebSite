using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;

namespace Sistema_Fundanet.CapaPresentacion.ModRoles
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        protected void ListarRol_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConexionBDRol EliminarRol = new ConexionBDRol();

            if (EliminarRol.EliminarRol(DropDownList1.SelectedValue))
            
            {
                DropDownList1.Items.Remove(DropDownList1.SelectedItem);

                Label2.Text="Rol Eliminado Correctamente";
                Label2.Visible = true;

            }

            else
            {
                Label2.Text = "Error, Rol no eliminado";
            }
        
        
        }

        
    }
}