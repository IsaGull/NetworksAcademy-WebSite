using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Usuario
    {

        string nombre;
        string contrasena;
        string pregunta;
        string respuesta;
        int fkRol;
        int fkPersona;
        string nombrePersona;
        string nombreRol;

        public Usuario()
        {
            nombre = "";
            contrasena = "";
            pregunta = "";
            respuesta = "";
            fkRol = 0;
            fkPersona = 0;
            NombrePersona = "";
            NombreRol = "";


        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }

        public int FkRol
        {
            get { return fkRol; }
            set { fkRol = value; }
        }

        public int FkPersona
        {
            get { return fkPersona; }
            set { fkPersona = value; }
        }

        public string NombrePersona
        {
            get { return nombrePersona; }
            set { nombrePersona = value; }
        }

        public string NombreRol
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }


    }
}