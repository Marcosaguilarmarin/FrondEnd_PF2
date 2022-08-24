using FrondEnd_ProyectoPA.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.ConexionesApis
{
    public class Conexiones
    {

        #region Atributos

        private HttpClient Cliente = new HttpClient();

        #endregion

        #region Metodos

        #region Privados

        private void InicializarCliente()
        {
            Cliente.BaseAddress = new Uri("https://localhost:44331/");
            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add
                (

                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
        }

        #endregion

        #region Publicos

        /// <summary>
        /// Metodo para agregar nuevos usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Usuarios</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> Agregar(Usuarios P_Entidad)
        {
            InicializarCliente();
            string urlAgregar = "api/Seguridad/Agregar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregar, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /// <summary>
        /// Metodo para Modificar nuevos usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Usuarios</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> Modificar(Usuarios P_Entidad)
        {
            InicializarCliente();
            string urlModificar = "api/Seguridad/Modificar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlModificar, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para eliminar nuevos usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Usuarios</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> Eliminar(Usuarios P_Entidad)
        {
            InicializarCliente();
            string urlEliminar = "api/Seguridad/Eliminar";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlEliminar, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /// <summary>
        /// Metodo para listar nuevos usuarios
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Usuarios</param>
        /// <returns>Entidad lista de tipo modelo usuarios</returns>
        public async Task<List<Usuarios>> Consultar(Usuarios P_Entidad)
        {
            List<Usuarios> lista = new List<Usuarios>();

            InicializarCliente();
            string urlConsultar = "api/Seguridad/Consultar";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultar);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Usuarios>>(convertirAstring);
            }

            return lista;
        }

        /// <summary>
        /// Metodo para listar nuevos choferes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo choferes</param>
        /// <returns>Entidad lista de tipo modelo choferes</returns>
        public async Task<List<Chofer>> ConsultarChofer(Chofer P_Entidad)
        {
            List<Chofer> lista = new List<Chofer>();

            InicializarCliente();
            string urlConsultarChofer = "api/Seguridad/ConsultarChofer";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarChofer);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Chofer>>(convertirAstring);
            }

            return lista;
        }

        /// <summary>
        /// Metodo para agregar nuevos choferes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo chofer</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarChofer(Chofer P_Entidad)   
        {
            InicializarCliente();
            string urlAgregarChofer = "api/Seguridad/AgregarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarChofer, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para Modificar nuevos choferes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo choferes</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> ModificarChofer(Chofer P_Entidad)
        {
            InicializarCliente();
            string urlModificarChofer = "api/Seguridad/ModificarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlModificarChofer, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para eliminar nuevos choferes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo choferes</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> EliminarChofer(Chofer P_Entidad)
        {
            InicializarCliente();
            string urlEliminarChofer = "api/Seguridad/EliminarChofer";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlEliminarChofer, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }
        
        /// <summary>
        /// Metodo para listar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Entidad lista de tipo modelo choferes</returns>
        public async Task<List<Ruta>> ConsultarRuta(Ruta P_Entidad)
        {
            List<Ruta> lista = new List<Ruta>();

            InicializarCliente();
            string urlConsultarRuta = "api/Seguridad/ConsultarRuta";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarRuta);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Ruta>>(convertirAstring);
            }

            return lista;
        }

        /// <summary>
        /// Metodo para agregar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarRuta(Ruta P_Entidad)
        {
            InicializarCliente();
            string urlAgregarRuta = "api/Seguridad/AgregarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarRuta, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para Modificar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> ModificarRuta(Ruta P_Entidad)
        {
            InicializarCliente();
            string urlModificarRuta = "api/Seguridad/ModificarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlModificarRuta, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para eliminar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> EliminarRuta(Ruta P_Entidad)
        {
            InicializarCliente();
            string urlEliminarRuta = "api/Seguridad/EliminarRuta";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlEliminarRuta, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /// <summary>
        /// Metodo para listar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Entidad lista de tipo modelo choferes</returns>
        public async Task<List<Bus>> ConsultarBus(Bus P_Entidad)
        {
            List<Bus> lista = new List<Bus>();

            InicializarCliente();
            string urlConsultarBus = "api/Seguridad/ConsultarBus";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarBus);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Bus>>(convertirAstring);
            }

            return lista;
        }

        /// <summary>
        /// Metodo para agregar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarBus(Bus P_Entidad)
        {
            InicializarCliente();
            string urlAgregarBus = "api/Seguridad/AgregarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarBus, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para Modificar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> ModificarBus(Bus P_Entidad)
        {
            InicializarCliente();
            string urlModificarBus = "api/Seguridad/ModificarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlModificarBus, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }

        /// <summary>
        /// Metodo para eliminar nuevos Ruta
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Ruta</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> EliminarBus(Bus P_Entidad)
        {
            InicializarCliente();
            string urlEliminarBus = "api/Seguridad/EliminarBus";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlEliminarBus, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /*
        /// <summary>
        /// Metodo para agregar nuevas reservaciones
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Reservaciones</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarReserva(Reservaciones P_Entidad)
        {
            InicializarCliente();
            string urlAgregarReserva = "api/Seguridad/AgregarReserva";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarReserva, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /// <summary>
        /// Metodo para consultar reservaciones existentes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo modelo reservaciones</param>
        /// <returns>Lista con reservaciones</returns>
        public async Task<List<Reservaciones>> ConsultarReserva(Reservaciones P_Entidad)
        {
            List<Reservaciones> lista = new List<Reservaciones>();

            InicializarCliente();
            string urlConsultarReserva = "api/Seguridad/ConsultarReserva";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarReserva);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Reservaciones>>(convertirAstring);
            }

            return lista;
        }

        /*

        /// <summary>
        /// Metodo para agregar nuevas habitaciones
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Habitaciones</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarHabitacion(Ruta P_Entidad)
        {
            InicializarCliente();
            string urlAgregarHabitacion = "api/Seguridad/AgregarHabitacion";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarHabitacion, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }


        /// <summary>
        /// Metodo para consultar habitaciones existentes
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo modelo habitaciones</param>
        /// <returns>Lista con habitaciones</returns>
        public async Task<List<Ruta>> ConsultarHabitacion(Ruta P_Entidad)
        {
            List<Ruta> lista = new List<Ruta>();

            InicializarCliente();
            string urlConsultarHabitacion = "api/Seguridad/ConsultarHabitacion";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarHabitacion);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Ruta>>(convertirAstring);
            }

            return lista;
        }

        public async Task<List<PerfilesXUsuario>> ConsultarPXU(PerfilesXUsuario P_Entidad)
        {
            List<PerfilesXUsuario> lista = new List<PerfilesXUsuario>();

            InicializarCliente();
            string urlConsultarPXU = "api/Seguridad/ConsultarPXU";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarPXU);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<PerfilesXUsuario>>(convertirAstring);
            }

            return lista;
        }
        

        public async Task<bool> AgregarClientes(Clientes P_Entidad)
        {
            InicializarCliente();
            string urlAgregarClientes = "api/Seguridad/AgregarClientes";
            HttpResponseMessage resultado = await Cliente.PostAsJsonAsync(urlAgregarClientes, P_Entidad);
            return resultado.IsSuccessStatusCode;
        }



        public async Task<List<Clientes>> ConsultarClientes(Clientes P_Entidad)
        {
            List<Clientes> lista = new List<Clientes>();

            InicializarCliente();
            string urlConsultarClientes = "api/Seguridad/ConsultarClientes";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarClientes);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Clientes>>(convertirAstring);
            }

            return lista;
        }*/

        #endregion


        #endregion

    }
}
