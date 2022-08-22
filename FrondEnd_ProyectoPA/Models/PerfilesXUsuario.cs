using FrondEnd_ProyectoPA.ConexionesApis;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class PerfilesXUsuario
    {


        #region Propiedades

        public int IdPerfilesUsuario { get; set; }
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public bool StatusPerfilesUsuario { get; set; }


        #endregion

        #region Constructores

        public PerfilesXUsuario()
        {
            IdPerfilesUsuario = 0;
            IdUsuario = 0;
            IdPerfil = 0;
            StatusPerfilesUsuario = true;
        }

        #endregion

        

    }
}
