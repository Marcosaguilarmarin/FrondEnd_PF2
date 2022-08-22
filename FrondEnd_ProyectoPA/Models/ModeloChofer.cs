using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrondEnd_ProyectoPA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FrondEnd_ProyectoPA.Models
{
    public class ModeloChofer
    {
        #region Propiedades

        public int IdChofer { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }



        #endregion

        #region Constructores

        public ModeloChofer()
        {
            IdChofer = 0;
            Nombre = string.Empty;
            CorreoElectronico = string.Empty;
            Clave = string.Empty;
        }

        #endregion


    }
}
