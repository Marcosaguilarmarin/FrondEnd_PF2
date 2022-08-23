using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Ruta
    {
        #region Propiedades

        public string Id_Ruta { get; set; }
        public string Nombre { get; set; }
        public string MontoEstimado { get; set; }
        public string MontoRecibido { get; set; }

        #endregion


        #region Constructores

        public Ruta()
        {
            Id_Ruta = string.Empty;
            Nombre = string.Empty;
            MontoEstimado = string.Empty;
            MontoRecibido = string.Empty;
        }
        #endregion
    }
}
