using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Salon
    {
        #region Variables
        int id;
        String numero;
        #endregion

        #region Metodo Set y Get
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Constructor

        public Salon(int Id, string Numero)
        {
            id = Id;
            numero = Numero;
        }

        #endregion 
    }
}