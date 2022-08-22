using FrondEnd_ProyectoPA.ConexionesApis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Habitaciones
    {
    
        #region Propiedades

        public int IdHabitaciones { get; set; }
        public string TipoHabitacion { get; set; }
        public string NombreHabitacion { get; set; }
        public int CapacidadHabitacion { get; set; }
        public decimal Precionochepersona { get; set; }
        public int Numerohabitacion { get; set; }
        public bool Estadohabitacion { get; set; }

        #endregion


        #region Constructores

        public Habitaciones()
        {
            IdHabitaciones = 0;
            TipoHabitacion = string.Empty;
            NombreHabitacion = string.Empty;
            CapacidadHabitacion = 0;
            Precionochepersona = 0;
            Numerohabitacion = 0;
            Estadohabitacion = true;
        }
        #endregion


    }
}
