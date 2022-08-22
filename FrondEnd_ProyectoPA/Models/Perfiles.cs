using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Perfiles
    {


        #region Propiedades

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int CodigoPerfil { get; set; }
        public bool StatusPerfil { get; set; }

        #endregion

        #region Constructores

        public Perfiles()
        {
            IdPerfil = 0;
            NombrePerfil = string.Empty;
            CodigoPerfil = 0;
            StatusPerfil = true;
        }

        #endregion

    }
}
