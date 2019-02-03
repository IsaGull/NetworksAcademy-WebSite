using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Seccion
    {
        #region variables
        int id;
        string codigo;
        int capacidad;
        string fechaI;
        string fechaF;
        double costo;
        int idcurso;
        Curso curso;
        List<Horario> horario;
        #endregion

        #region Metodo Set y Get
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdCurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string FechaI
        {
            get { return fechaI; }
            set { fechaI = value; }
        }
        public string FechaF
        {
            get { return fechaF; }
            set { fechaF = value; }
        }
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public List<Horario> Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        #endregion

        #region constructor
        public Seccion()
        {
        }
        public Seccion(string Codigo, int Capacidad, string FechaI, string FechaF, double Costo)
        {
            codigo = Codigo;
            capacidad = Capacidad;
            fechaI = FechaI;
            fechaF = FechaF;
            costo = Costo;
        }
        public Seccion(string Codigo, int Capacidad, string FechaI, string FechaF, double Costo, int IdCurso)
        {
            codigo = Codigo;
            capacidad = Capacidad;
            fechaI = FechaI;
            fechaF = FechaF;
            costo = Costo;
            idcurso = IdCurso;
        }
        public Seccion(string Codigo, int Capacidad, string FechaI, string FechaF, double Costo, Curso Curso, List<Horario> Horario)
        {
            codigo = Codigo;
            capacidad = Capacidad;
            fechaI = FechaI;
            fechaF = FechaF;
            costo = Costo;
            curso = Curso;
            horario = Horario;
        }
        #endregion

        #region metodos
        public void NuevaSeccion(string Codigo, int Capacidad, string FechaI, string FechaF, double Costo)
        {
            codigo = Codigo;
            capacidad = Capacidad;
            fechaI = FechaI;
            fechaF = FechaF;
            costo = Costo;
        }

        public void NuevaSeccion(int Id, string Codigo, int Capacidad, string FechaI, string FechaF, double Costo)
        {
            id = Id;
            codigo = Codigo;
            capacidad = Capacidad;
            fechaI = FechaI;
            fechaF = FechaF;
            costo = Costo;
        }
        #endregion 

    }
}