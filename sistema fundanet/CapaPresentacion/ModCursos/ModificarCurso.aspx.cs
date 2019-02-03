using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModCursos
{
    public partial class ModificarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConexionBDCursos objBD = new ConexionBDCursos();
                List<String> ListaCursos = new List<String>();
                ListaCursos = objBD.ConsultarListaCursos();
                DDLCurso.Items.Insert(0, new ListItem("Seleccione", "0"));
                int i = 1;
                foreach (String curso in ListaCursos)
                {
                    DDLCurso.Items.Insert(i, new ListItem(curso, curso));
                    i++;
                }

            }
        }



        protected void BModificar_Click(object sender, EventArgs e)
        {
            if ((TBNombre.Text == "") || (TBModulo.Text == ""))
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Los campos no pueden estar vacíos";
            }
            else
            {
                Curso micurso = new Curso(int.Parse(DDLModulo.SelectedValue), TBNombre.Text, TBModulo.Text);
                ConexionBDCursos objBD = new ConexionBDCursos();
                if (objBD.ExisteCurso(micurso))
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "El curso y módulo ya existen";
                }
                else
                {
                    if (objBD.ModificarCurso(micurso))
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Black;
                        LMensaje.Text = "Se modificó exitosamente";
                    }
                    else
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Error con Base de Datos, no se pudo modificar el curso";
                    }
                }
            }
        }



        protected void DDLCurso_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DDLModulo.Items.Clear();
            ConexionBDCursos objBD = new ConexionBDCursos();
            List<Curso> ListaModulos = new List<Curso>();
            ListaModulos = objBD.BuscarModulosDeCurso(DDLCurso.SelectedValue.ToString());
            DDLModulo.Items.Insert(0, new ListItem("Seleccione", "0"));
            int i = 1;
            foreach (Curso mod in ListaModulos)
            {
                DDLModulo.Items.Insert(i, new ListItem(mod.Modulo, mod.Id.ToString()));
                i++;
            }
        }

        protected void DDLModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBNombre.Text = DDLCurso.SelectedItem.Text;
            TBModulo.Text = DDLModulo.SelectedItem.Text;
        }

    }
}