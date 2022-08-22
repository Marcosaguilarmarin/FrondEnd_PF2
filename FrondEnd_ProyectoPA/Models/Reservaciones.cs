using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Reservaciones
    {


        #region Propiedades

        public int IdReservaciones { get; set; }
        public int CodigoReservacion { get; set; }
        public int CantidadAdultos { get; set; }
        public int Cantidadninos { get; set; }
        public int IdUsuario { get; set; }
        public int IdClientes { get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaReservacion { get; set; }
        public DateTime Fechaestadiainicial { get; set; }
        public DateTime Fechaestadiafinal { get; set; }

        public int ValorEstadia { get; set; }


        #endregion

        #region Constructores

        public Reservaciones()
        {
            IdReservaciones = 0;
            CodigoReservacion = 0;
            CantidadAdultos = 0;
            Cantidadninos = 0;
            IdUsuario = 0;
            IdClientes = 0;
            IdHabitacion = 0;
            FechaReservacion = DateTime.Now;
            Fechaestadiainicial = DateTime.Now;
            Fechaestadiafinal = DateTime.Now;
        }


        #endregion

    }
}
