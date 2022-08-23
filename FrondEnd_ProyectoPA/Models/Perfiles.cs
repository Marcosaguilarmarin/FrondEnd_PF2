using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Perfiles
    {



        #region Propiedades

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        /*
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int CodigoPerfil { get; set; }
        public bool StatusPerfil { get; set; }
        */
        #endregion

        #region Constructores

        public Perfiles()
        {
            Codigo = 0;
            Descripcion = string.Empty;
            Activo = true;
        }

        #endregion

    }
}
