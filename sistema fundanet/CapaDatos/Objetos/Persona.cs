using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Persona
    {
        string nombre;
        string apellido;
        string correo;
        string telefono;
        string cedula;
        string tipo;
        string estatus;

        public Persona()
        {
            nombre= "";
            apellido = "";
            correo = "";
            telefono = "";
            cedula = "";
            tipo = "";
            estatus = null;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
     

    }
}