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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Curso micurso; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BAceptar_Click(object sender, EventArgs e)
        {
            if ((TBNombre.Text == "") || (TBModulo.Text == ""))
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Los campos no pueden estar vacíos";
            }
            else
            {
                micurso = new Curso(TBNombre.Text, TBModulo.Text);
                ConexionBDCursos objBD = new ConexionBDCursos();
                if (objBD.ExisteCurso(micurso))
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "El curso y módulo ya existen";
                }
                else
                {
                    if (objBD.AgregarCurso(micurso))
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Black;
                        LMensaje.Text = "Se agrego exitosamente";
                    }
                    else
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Error con Base de Datos, no se pudo agregar el curso";
                    }
                } 
                
            }
        }

        public Curso getCurso()
        {
            return micurso;
        }

    }
}