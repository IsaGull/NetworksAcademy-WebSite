using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Sistema_Fundanet.CapaDatos.ConexionBD;
using Sistema_Fundanet.CapaDatos.Objetos;

namespace Sistema_Fundanet.CapaPresentacion.ModSecciones
{
    public partial class EliminarSeccion : System.Web.UI.Page
    {
        ListaSeccion lista = ListaSeccion.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {
            LMensaje.Text = "";
            if (!IsPostBack)
            {
                InicializarTabla();
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

        public void InicializarTabla()
        {
            DataTable dtCursos = new DataTable();
            dtCursos.Columns.Add("Curso");
            dtCursos.Columns.Add("Módulo");
            dtCursos.Columns.Add("Código");
            dtCursos.Columns.Add("Inicio");
            DataRow dr = dtCursos.NewRow();
            dr["Código"] = "-";
            dr["Curso"] = "-";
            dr["Módulo"] = "-";
            dr["Inicio"] = "-";
            dtCursos.Rows.Add(dr);
            GridView1.DataSource = dtCursos;
            GridView1.DataBind();
            GridView1.Visible = true;

            LCurso.Text = "";
            LModulo.Text = "";
            LCodigo.Text = "";
            LCapacidad.Text = "";
            LFechaI.Text = "";
            LFechaF.Text = "";
            LCosto.Text = "";
            LHorario.Items.Clear();
        }

        public void LlenarTabla()
        {
            if (lista._Lista.Count == 0)
            {
                InicializarTabla();
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "No existen coincidencias";
            }
            else
            {
                DataTable dtCursos = new DataTable();
                dtCursos.Columns.Add("Curso");
                dtCursos.Columns.Add("Módulo");
                dtCursos.Columns.Add("Código");
                dtCursos.Columns.Add("Inicio");

                foreach (Seccion secc in lista._Lista)
                {
                    DataRow dr = dtCursos.NewRow();
                    dr["Código"] = secc.Codigo;
                    dr["Curso"] = secc.Curso.Nombre;
                    dr["Módulo"] = secc.Curso.Modulo;
                    dr["Inicio"] = secc.FechaI;
                    dtCursos.Rows.Add(dr);
                }

                GridView1.DataSource = dtCursos;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            lista._Lista.Clear();
            InicializarTabla();
            ConexionBDSeccion BD = new ConexionBDSeccion();
            if ((TBCodigo.Text != "") && (BD.ExisteSeccion(TBCodigo.Text)))
            {
                Seccion miseccion = BD.ConsultarSeccion(TBCodigo.Text);
                lista._Lista.Add(miseccion);
                LlenarTabla();
            }
            else
            {
                if (DDLCurso.SelectedIndex != 0)
                {
                    if (DDLModulo.SelectedIndex != 0)
                    {
                        if (TBFechaI.Text != "")
                        {
                            //6 consultar con curso mod y fecha 
                            string query = "Select cu.nombre, cu.modulo, se.id, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo from seccion se, curso cu where cu.nombre='" + DDLCurso.SelectedItem.Text + "' and cu.modulo=" + DDLModulo.SelectedItem.Text + " and se.fecha_ini = '" + TBFechaI.Text + "' and se.fk_curso = cu.id ";
                            lista._Lista = BD.ConsultarListaSecciones(query);
                            foreach (Seccion secc in lista._Lista)
                            {
                                secc.Horario = BD.ConsultarHorario(secc.Id);
                            }
                            LlenarTabla();
                        }
                        else
                        {
                            //3 consultar con curso y mod
                            string query = "Select cu.nombre, cu.modulo, se.id, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo from seccion se, curso cu where cu.nombre='" + DDLCurso.SelectedItem.Text + "' and cu.modulo=" + DDLModulo.SelectedItem.Text + " and se.fk_curso = cu.id ";
                            lista._Lista = BD.ConsultarListaSecciones(query);
                            foreach (Seccion secc in lista._Lista)
                            {
                                secc.Horario = BD.ConsultarHorario(secc.Id);
                            }
                            LlenarTabla();
                        }
                    }
                    else
                    {
                        if (TBFechaI.Text != "")
                        {
                            //5 consultar con curso  y fecha 
                            string query = "Select cu.nombre, cu.modulo, se.id, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo from seccion se, curso cu where cu.nombre='" + DDLCurso.SelectedItem.Text + "' and se.fecha_ini = '" + TBFechaI.Text + "' and se.fk_curso = cu.id";
                            lista._Lista = BD.ConsultarListaSecciones(query);
                            foreach (Seccion secc in lista._Lista)
                            {
                                secc.Horario = BD.ConsultarHorario(secc.Id);
                            }
                            LlenarTabla();
                        }
                        else
                        {
                            //2 consultar con curso 
                            string query = "Select cu.nombre, cu.modulo, se.id, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo from seccion se, curso cu where cu.nombre='" + DDLCurso.SelectedItem.Text + "' and se.fk_curso = cu.id ";
                            lista._Lista = BD.ConsultarListaSecciones(query);
                            foreach (Seccion secc in lista._Lista)
                            {
                                secc.Horario = BD.ConsultarHorario(secc.Id);
                            }
                            LlenarTabla();
                        }
                    }
                }
                else
                {
                    if (TBFechaI.Text != "")
                    {
                        //4 consultar con  fecha 
                        string query = "Select cu.nombre, cu.modulo, se.id, se.codigo, se.capacidad, Convert(varchar(10), se.fecha_ini, 103), Convert(varchar(10), se.fecha_fin, 103), se.costo from seccion se, curso cu where se.fecha_ini = '" + TBFechaI.Text + "' and se.fk_curso = cu.id ";
                        lista._Lista = BD.ConsultarListaSecciones(query);
                        foreach (Seccion secc in lista._Lista)
                        {
                            secc.Horario = BD.ConsultarHorario(secc.Id);
                        }
                        LlenarTabla();
                    }
                    else
                    {
                        InicializarTabla();
                        LMensaje.ForeColor = System.Drawing.Color.Red;
                        LMensaje.Text = "No existen coincidencias";
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GridView1.SelectedIndex;
            LCurso.Text = lista._Lista[i].Curso.Nombre;
            LModulo.Text = lista._Lista[i].Curso.Modulo;
            LCodigo.Text = lista._Lista[i].Codigo;
            LCapacidad.Text = lista._Lista[i].Capacidad.ToString();
            LFechaI.Text = lista._Lista[i].FechaI;
            LFechaF.Text = lista._Lista[i].FechaF;
            LCosto.Text = lista._Lista[i].Costo.ToString();
            LHorario.Items.Clear();
            foreach (Horario hor in lista._Lista[i].Horario)
            {
                string clase = hor.Dia + " de " + hor.HoraI + " a " + hor.HoraF + " Salon: " + hor.Salon;
                LHorario.Items.Add(clase);
            }
        }


        protected void BEliminar_Click(object sender, EventArgs e)
        {
            ConexionBDSeccion BD = new ConexionBDSeccion();
            if (BD.EliminarClase(LCodigo.Text))
            {
                LMensaje.ForeColor = System.Drawing.Color.Black;
                LMensaje.Text = "Se eliminó exitosamente";
                InicializarTabla();
            }
            else
            {
                LMensaje.ForeColor = System.Drawing.Color.Red;
                LMensaje.Text = "Error con Base de Datos, no se pudo eliminar la sección";
            }
        }
  
    }
}