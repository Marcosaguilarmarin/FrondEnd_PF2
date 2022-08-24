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
    public class Chofer
    {
        #region Propiedades

        public string Id_Chofer { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string CorreoUsuario { get; set; }



        #endregion

        #region Constructores

        public Chofer()
        {
            Id_Chofer = string.Empty;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            CorreoUsuario = string.Empty;
        }

        #endregion

        /*
        public List<Chofer> ConsultarChofer(Chofer P_entidad = null)
        {
            List<Chofer> lstresutados = new List<Chofer>();

            if (P_entidad == null)
            {
                lstresutados = new List<Chofer>();

            }

            lstresutados = lstresutados.Where(x => x.NombreUsuario.Contains(P_entidad.NombreUsuario)).ToList();
        }
        */
        

    }
}
