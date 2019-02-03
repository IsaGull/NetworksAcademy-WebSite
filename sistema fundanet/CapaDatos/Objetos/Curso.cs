using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Curso
    {
        #region Variables
        int id;
        String nombre;
        String modulo;
        #endregion

        #region Metodo Set y Get
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Constructor
        public Curso()
        {
        }

        public Curso(int Id, string Nombre, string Modulo)
        {
            id = Id;
            nombre = Nombre;
            modulo = Modulo;
        }

        public Curso(int Id, string Modulo)
        {
            id = Id;
            modulo = Modulo;
        }

        public Curso(string Nombre, string Modulo)
        {
            nombre = Nombre;
            modulo = Modulo;
        }
        #endregion

        #region metodos
        public void NuevoCurso(string Nombre, string Modulo)
        {
            nombre = Nombre;
            modulo = Modulo;
        }
        #endregion 




    }
}