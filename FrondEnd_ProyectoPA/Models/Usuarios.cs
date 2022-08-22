using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Usuarios
    {


        #region Propiedades

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string IdentificacionUsuario { get; set; }
        public string IdLogueo { get; set; }
        public string Contrasena { get; set; }
        public int IdDireccionPais { get; set; }
        public int IdDireccionProvincia { get; set; }
        public string Direccionotrassenasusuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public List<Perfiles> Perfiles { get; set; }

        #endregion

        #region Constructores

        public Usuarios()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            ApellidoUsuario = string.Empty;
            IdentificacionUsuario = string.Empty;
            IdLogueo = string.Empty;
            Contrasena = string.Empty;
            IdDireccionPais = 0;
            IdDireccionProvincia = 0;
            Direccionotrassenasusuario = string.Empty;
            CorreoUsuario = string.Empty;
            TelefonoUsuario = string.Empty;
            EstadoUsuario = true;
            Perfiles = new List<Perfiles>();
        }

        #endregion




    }
}
