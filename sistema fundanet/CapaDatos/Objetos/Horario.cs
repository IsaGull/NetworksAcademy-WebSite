using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Fundanet.CapaDatos.Objetos
{
    public class Horario
    {
        #region Variables
        int id;
        string dia;
        TimeSpan horaI;
        TimeSpan horaF;
        int salonId;
        string salon; 
        #endregion

        #region Metodo Set Get 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public TimeSpan HoraI
        {
            get { return horaI; }
            set { HoraI = value; }
        }
        public TimeSpan HoraF
        {
            get { return horaF; }
            set { horaF = value; }
        }
        public int SalonId
        {
            get { return salonId; }
            set { salonId = value; }
        }
        public string Salon
        {
            get { return salon; }
            set { salon = value; }
        }
        #endregion 
        
        #region Constructor
        public Horario(int Id, String Dia, TimeSpan HoraI, TimeSpan HoraF)
        {
            id = Id;
            dia = Dia;
            horaI = HoraI;
            horaF = HoraF;
        }
        public Horario(String Dia, TimeSpan HoraI, TimeSpan HoraF, int SalonId)
        {
            dia = Dia;
            horaI = HoraI;
            horaF = HoraF;
            salonId = SalonId; 
        }
        public Horario(String Dia, TimeSpan HoraI, TimeSpan HoraF, string Salon)
        {
            dia = Dia;
            horaI = HoraI;
            horaF = HoraF;
            salon = Salon;
        }
        #endregion
    }
    
}