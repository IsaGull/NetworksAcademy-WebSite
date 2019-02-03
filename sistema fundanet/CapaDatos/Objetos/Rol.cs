using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Rol
    {
        string nombre;
        List<string> ListaDeFunciones;

        public Rol()
        {
            nombre = "";
            ListaDeFunciones = new List<string>();

        }

        public List<string> MetodoListaDeFunciones
        {
            get { return ListaDeFunciones; }
            set { ListaDeFunciones = value; }
        }

        public string MedotoNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}