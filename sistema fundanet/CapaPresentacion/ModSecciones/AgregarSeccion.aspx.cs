using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModSecciones
{
    public partial class AgregarSeccion : System.Web.UI.Page
    {
        ListHorario ListaHorario = ListHorario.Instance;

        #region inicializacion DropdonwList
        protected void Page_Load(object sender, EventArgs e)
        {
            LMensaje.Text = "";
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

                ConexionBDSeccion objBD2 = new ConexionBDSeccion();
                List<String> ListaSedes = new List<String>();
                ListaSedes = objBD2.ConsultarNombreSedes();
                DDLSede.Items.Insert(0, new ListItem("Seleccione", "0"));
                int i2 = 1;
                foreach (String sede in ListaSedes)
                {
                    DDLSede.Items.Insert(i2, new ListItem(sede, sede));
                    i2++;
                }

                LlenarListaDias();
            }
        }

        private void LlenarListaDias()
        {
            DDLDia.Items.Insert(0, new ListItem("Seleccione", "0"));
            DDLDia.Items.Insert(1, new ListItem("Lunes", "1"));
            DDLDia.Items.Insert(2, new ListItem("Martes", "2"));
            DDLDia.Items.Insert(3, new ListItem("Miércoles", "3"));
            DDLDia.Items.Insert(4, new ListItem("Jueves", "4"));
            DDLDia.Items.Insert(5, new ListItem("Viernes", "5"));
            DDLDia.Items.Insert(6, new ListItem("Sabado", "6"));
        }
        #endregion

        #region Llenar DropDownList Secundarios
        protected void DDLCurso_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void DDLSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            DDLSalon.Items.Clear();
            ConexionBDSeccion objBD = new ConexionBDSeccion();
            List<Salon> ListaSalones = new List<Salon>();
            ListaSalones = objBD.BuscarSalonesDeSede(DDLSede.SelectedValue.ToString());
            DDLSalon.Items.Insert(0, new ListItem("Seleccione", "0"));
            int i = 1;
            foreach (Salon salon in ListaSalones)
            {
                DDLSalon.Items.Insert(i, new ListItem(salon.Numero, salon.Id.ToString()));
                i++;
            }
        }
        #endregion

        #region Crear Lista Horario
        protected void BAgregarHor_Click(object sender, EventArgs e)
        {
            if (validarHorario())
            {
                String dia = DDLDia.SelectedItem.ToString();
                TimeSpan horaI = TimeSpan.Parse(TBHoraI.Text);
                TimeSpan horaF = TimeSpan.Parse(TBHoraF.Text);
                Horario mihorario = new Horario(dia, horaI, horaF, int.Parse(DDLSalon.SelectedItem.Value));
                ListaHorario._Lista.Add(mihorario);
                LBHorario.Items.Add(dia + " de " + horaI.Hours + ":" + horaI.Minutes + " a " + horaF.Hours + ":" + horaF.Minutes + " Salon: " + DDLSalon.SelectedItem.Text);
            }
        }

        protected void BBorrar_Click(object sender, EventArgs e)
        {
            LBHorario.Items.Clear();
            ListaHorario._Lista.Clear();
        }

        private bool validarHorario()
        {
            bool bandera = false;
            if ((DDLSede.SelectedIndex == 0) || (DDLSalon.SelectedIndex == 0))
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Seleccione Sede y Salon";
            }
            else
            {
                if (DDLDia.SelectedIndex == 0)
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "Seleccione el día";
                }
                else
                {
                    TimeSpan hora0 = new TimeSpan(0, 0, 0);
                    if ((TBHoraI.Text == "") || (TimeSpan.Parse(TBHoraI.Text) == hora0) || (TBHoraF.Text == "") || (TimeSpan.Parse(TBHoraF.Text) == hora0))
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Seleccione hora de inicio y fin";
                    }
                    else
                    {
                        if (TimeSpan.Parse(TBHoraI.Text) >= TimeSpan.Parse(TBHoraF.Text))
                        {
                            LMensaje.ForeColor = System.Drawing.Color.Red;
                            LMensaje.Text = "La hora de inicio debe ser menor a la hora fin";
                        }
                        else
                        {
                            bandera = true;
                        }
                    }
                }
            }
            return bandera;
        }
        #endregion

        #region crear Seccion

        public bool validarSeccion()
        {
            bool bandera = false;
            if ((DDLCurso.SelectedIndex == 0) || (DDLModulo.SelectedIndex == 0))
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Seleccione Curso y Módulo";
            }
            else
            {
                if ((TBCodigo.Text == "") || (TBcapacidad.Text == "") || (TBCosto.Text == ""))
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "Los campos código, capacidad y costo no pueden estar vacíos";
                }
                else
                {
                    if ((TBFechaI.Text == "") || (TBFechaF.Text == ""))
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Seleccione Fechas de inicio y fin";
                    }
                    else
                    {
                        if (DateTime.Parse(TBFechaI.Text) >= DateTime.Parse(TBFechaF.Text))
                        {
                            LMensaje.ForeColor = System.Drawing.Color.Red;
                            LMensaje.Text = "La fecha de inicio debe ser menor a la fecha fin";
                        }
                        else
                        {
                            if (LBHorario.Items.Count == 0)
                            {
                                LMensaje.ForeColor = System.Drawing.Color.Red;
                                LMensaje.Text = " Ingrese Horario de la Sección ";

                            }
                            else
                            {
                                bandera = true;
                            }
                        }
                    }
                }
            }
            return bandera;
        }

        protected void BAgregarSecc_Click(object sender, EventArgs e)
        {
            if (validarSeccion())
            {
                ConexionBDSeccion BD = new ConexionBDSeccion();
                if (BD.ExisteSeccion(TBCodigo.Text))
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "Ya existe una sección con ese código";
                }
                else
                {
                    Seccion miseccion = new Seccion(TBCodigo.Text, int.Parse(TBcapacidad.Text), TBFechaI.Text, TBFechaF.Text, double.Parse(TBCosto.Text), int.Parse(DDLModulo.SelectedValue));
                    if (BD.AgregarSeccion(miseccion))
                    {
                        int id = BD.BuscarIDSeccion(TBCodigo.Text);
                        if (AgregarClase(id))
                        {
                            LMensaje.ForeColor = System.Drawing.Color.Black;
                            LMensaje.Text = "Se agrego exitosamente";
                        }
                    }
                    else
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Error con Base de Datos, no se pudo agregar la seccion";
                    }
                }
            }
        }

        public bool AgregarClase(int idSeccion)
        {
            LMensaje.Text = "";
            foreach (Horario hor in ListaHorario._Lista)
            {
                int idHor = 0;
                ConexionBDSeccion BD = new ConexionBDSeccion();
                if (BD.ExisteHorario(hor))
                {
                    idHor = BD.BuscarIDHorario(hor);
                }
                else
                {
                    if (BD.AgregarHorario(hor))
                    {
                        idHor = BD.BuscarIDHorario(hor);
                    }
                    else
                    {
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "Error con Base de Datos, no se pudo agregar El Horario";
                        return false;
                    }
                }
                if (BD.AgregarClase(hor.SalonId, idHor, idSeccion))
                {
                }
                else
                {
                    LMensaje.ForeColor = System.Drawing.Color.Red;
                    LMensaje.Text = "Error con Base de Datos, no se pudo agregar la clase";
                    return false;
                }
            }
            return true;
        }

        #endregion 

    }
}