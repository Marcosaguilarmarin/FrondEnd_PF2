using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Clientes
    {
        

        #region Propiedades

        public int IdClientes { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string IdentificacionCliente { get; set; }
        public string IdUsuariocliente { get; set; }
        public string Contrasenacliente { get; set; }
        public int IdDireccionPais { get; set; }
        public int IdDireccionProvincia { get; set; }
        public string Direccionotrassenasclientes { get; set; }
        public string Correocliente { get; set; }
        public string Telefono { get; set; }
        public bool EstadoCliente { get; set; }


        #endregion

        #region Constructores

        public Clientes()
        {
            IdClientes = 0;
            NombreCliente = string.Empty;
            ApellidoCliente = string.Empty;
            IdentificacionCliente = string.Empty;
            IdUsuariocliente = string.Empty;
            Contrasenacliente = string.Empty;
            IdDireccionPais = 0;
            IdDireccionProvincia = 0;
            Direccionotrassenasclientes = string.Empty;
            Correocliente = string.Empty;
            Telefono = string.Empty;
            EstadoCliente = true;
        }

        #endregion

    }
}
