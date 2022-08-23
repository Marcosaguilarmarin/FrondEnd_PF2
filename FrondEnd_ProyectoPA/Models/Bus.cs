using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Bus
    {
        #region Propiedades

        public string Id_Bus { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Id_Estado { get; set; }
        public string Id_Ruta { get; set; }
        public string Id_Chofer { get; set; }

        #endregion


        #region Constructores

        public Bus()
        {
            Id_Bus = string.Empty;
            Placa = string.Empty;
            Marca = string.Empty;
            Id_Estado = string.Empty;
            Id_Ruta = string.Empty;
            Id_Chofer = string.Empty;
        }
        #endregion
        
    }
}
