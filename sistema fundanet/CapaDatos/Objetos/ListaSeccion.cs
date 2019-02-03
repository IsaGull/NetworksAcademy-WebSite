using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class ListaSeccion
    {
        List<Seccion> Lista = new List<Seccion>();
        private static readonly ListaSeccion instance = new ListaSeccion();

        private ListaSeccion() { }

        public static ListaSeccion Instance
        {
            get
            {
                return instance;
            }
        }

        public List<Seccion> _Lista
        {
            get { return Lista; }
            set { Lista = value; }
        }

        public void AddElemento(Seccion obj)
        {
            Lista.Add(obj);
        }
    }
}