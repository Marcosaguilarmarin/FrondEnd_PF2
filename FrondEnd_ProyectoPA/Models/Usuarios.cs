using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Models
{
    public class Usuarios
    {


        #region Propiedades

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public bool Activo { get; set; }

        public bool Bloqueado { get; set; }

        public List<Perfiles> Perfiles { get; set; }
        /*
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
        */
        #endregion

        #region Constructores

        public Usuarios()
        {
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            Activo = true;
            Bloqueado = false;
            Perfiles = new List<Perfiles>();


            /*
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
            */
        }

        public Usuarios ValidarUsuariosSimulado()
        {
            List<Usuarios> lstUsuariosRegistrados = new List<Usuarios>
            {
                new Usuarios{ NombreUsuario = "admin", Contrasena= "admin", Activo = true, Bloqueado = false, 
                    Perfiles = new List<Perfiles>{
                        new Perfiles { Codigo = 1, Descripcion = "Consultas", Activo = true},
                        new Perfiles { Codigo = 2, Descripcion = "Catalogos", Activo = true},
                        new Perfiles { Codigo = 3, Descripcion = "Choferes", Activo = true},
                        new Perfiles { Codigo = 4, Descripcion = "Rutas", Activo = true},
                        new Perfiles { Codigo = 5, Descripcion = "Buses", Activo = true},

                     } },
                new Usuarios{ NombreUsuario = "chofer", Contrasena= "chofer", Activo = true, Bloqueado = false,
                    Perfiles = new List<Perfiles>{

                        new Perfiles { Codigo = 1, Descripcion = "Consultas", Activo = true},

                     } },
                new Usuarios{ NombreUsuario = "empleado", Contrasena= "empleado", Activo = true, Bloqueado = false,
                    Perfiles = new List<Perfiles>{

                        new Perfiles { Codigo = 2, Descripcion = "Catalogos", Activo = true},
                        new Perfiles { Codigo = 3, Descripcion = "Choferes", Activo = true},
                        new Perfiles { Codigo = 4, Descripcion = "Rutas", Activo = true},
                        new Perfiles { Codigo = 5, Descripcion = "Buses", Activo = true},

                     } },


            };

            Usuarios encontrado = lstUsuariosRegistrados.Find(x => x.NombreUsuario.ToUpper().Trim().Equals(this.NombreUsuario.ToUpper().Trim()) &&
                                                              x.Contrasena.Trim().Equals(this.Contrasena.Trim()) &&
                                                              x.Activo &&
                                                              !x.Bloqueado);

            return encontrado;

        }



        #endregion

    }
}
