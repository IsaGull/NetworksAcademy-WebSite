using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class ListHorario
    {
        List<Horario> Lista = new List<Horario>();
        private static readonly ListHorario instance = new ListHorario();

        private ListHorario() { }

        public static ListHorario Instance
        {
            get
            {
                return instance;
            }
        }


        public List<Horario> _Lista
        {
            get { return Lista; }
            set { Lista = value; }
        }

        public void AddElemento(Horario obj)
        {
            Lista.Add(obj);
        }
    }
}