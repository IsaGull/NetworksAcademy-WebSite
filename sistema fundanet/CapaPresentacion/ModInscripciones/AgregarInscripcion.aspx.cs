using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModInscripciones
{
    public partial class AgregarInscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LMensaje.Text = "";
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            ConexionBDInscripcion BD1 = new ConexionBDInscripcion();
            if ((TBCI.Text != "") && (BD1.ExisteAlumno(TBCI.Text)))
            {
                Persona alumno = BD1.ConsultarAlumno(TBCI.Text);
                LCI.Text = TBCI.Text;
                LabelNombre.Text = alumno.Nombre + " " + alumno.Apellido;
            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "No existen coincidencias del Alumno";
                Inicializar();
            }

            ConexionBDSeccion BD = new ConexionBDSeccion();
            if ((TBCodigo.Text != "") && (BD.ExisteSeccion(TBCodigo.Text)))
            {
                Seccion miseccion = BD.ConsultarSeccion(TBCodigo.Text);

                LCurso.Text = miseccion.Curso.Nombre;
                LModulo.Text = miseccion.Curso.Modulo;
                LCodigo.Text = miseccion.Codigo;
                LCapacidad.Text = miseccion.Capacidad.ToString();
                LFechaI.Text = miseccion.FechaI;
                LFechaF.Text = miseccion.FechaF;
                LCosto.Text = miseccion.Costo.ToString();
                LHorario.Items.Clear();
                foreach (Horario hor in miseccion.Horario)
                {
                    string clase = hor.Dia + " de " + hor.HoraI + " a " + hor.HoraF + " Salon: " + hor.Salon;
                    LHorario.Items.Add(clase);
                }
            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "No existen coincidencias de la Sección";
                Inicializar();
            }
        }

        public void Inicializar()
        {
            LCurso.Text = "";
            LModulo.Text = "";
            LCodigo.Text = "";
            LCapacidad.Text = "";
            LFechaI.Text = "";
            LFechaF.Text = "";
            LCosto.Text = "";
            LHorario.Items.Clear();
            LabelNombre.Text = "";
        }

        protected void ButtonInscribir_Click(object sender, EventArgs e)
        {
            ConexionBDInscripcion BD = new ConexionBDInscripcion();
            if ((LCodigo.Text != "") && (LCI.Text != ""))
            {
                int idAlumno = BD.idAlumno(LCI.Text);
                int idSeccion = BD.idSeccion(LCodigo.Text);
                if (BD.AgregarInscripcion(idAlumno, idSeccion))
                {
                    LMensaje.ForeColor = System.Drawing.Color.Black;
                    LMensaje.Text = "Se inscribió exitosamente el alumno en la sección";
                }
                else
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "Error con Base de Datos";
                }

            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Indique CI del alumno y codigo de la sección";
            }
        }
        
    }
}