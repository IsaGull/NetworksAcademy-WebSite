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
    public partial class ModificarRol : System.Web.UI.Page
    {

        List<string> ListaDeRoles;

        Boolean bandera;
        
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!Page.IsPostBack)
            {
               
               
            }

        
            
        
        }

        protected void ListarRol_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ConexionBDRol consultarBD = new ConexionBDRol();
            Rol MiRol = new Rol();

            MiRol = consultarBD.ConsultarRol(DropDownList1.SelectedValue);

            TextBox1.Text = MiRol.MedotoNombre;

            foreach (string i in MiRol.MetodoListaDeFunciones)
            {
                ListBox1.Items.Add(i);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListaDeRoles = new List<string>();

            ConexionBDRol EliminarRol = new ConexionBDRol();
            ConexionBDRol consultarBD = new ConexionBDRol();
            bool validacion = false;

            if ((TextBox1.Text == "") | (ListBox1.Items.Count == 0))
            {
                validacion = false;
            }

            else
                validacion = true;

            if (validacion == true)
            {
                if ((consultarBD.Existe(TextBox1.Text)))
                {

                    if (EliminarRol.EliminarRol(DropDownList1.SelectedValue))
                    {
                        DropDownList1.Items.Remove(DropDownList1.SelectedItem);

                        ConexionBDRol BaseDatos = new ConexionBDRol();

                        for (int i = 0; i <= ListBox1.Items.Count - 1; i++)
                        {
                            ListaDeRoles.Add(ListBox1.Items[i].Text);
                        }


                        if (BaseDatos.AgregarRol(TextBox1.Text, ListaDeRoles))
                        {

                            Label2.Visible = true;
                            Label2.Text = "Rol Modificado correctamente.";

                        }


                        else
                        {
                            Label2.Visible = true;
                            Label2.Text = "Error, el rol no fue modificado en el sistema.";

                        }



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
                Label2.Text = "Error, Campos vacios";

            }

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {




            int contador=0;

            for (int i = 0; i <= ListBox1.Items.Count - 1; i++)
            {
                if (DropDownList2.Text == ListBox1.Items[i].Text)
                {
                    contador++;
                }
            
            }

            if (contador ==0)
            {
                ListBox1.Items.Add(DropDownList2.Text);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }

        
    }
}