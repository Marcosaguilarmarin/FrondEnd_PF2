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
        /// <param name="P_Entidad">Entidad de tipo Modelo Usuarios</param>
        /// <returns>Entidad lista de tipo modelo usuarios</returns>
        public async Task<List<ModeloChofer>> ConsultarChofer(ModeloChofer P_Entidad)
        {
            List<ModeloChofer> lista = new List<ModeloChofer>();

            InicializarCliente();
            string urlConsultarChofer = "api/Seguridad/ConsultarChofer";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarChofer);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<ModeloChofer>>(convertirAstring);
            }

            return lista;
        }


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



        /// <summary>
        /// Metodo para agregar nuevas habitaciones
        /// </summary>
        /// <param name="P_Entidad">Entidad de tipo Modelo Habitaciones</param>
        /// <returns>Respuesta de ejecución</returns>
        public async Task<bool> AgregarHabitacion(Habitaciones P_Entidad)
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
        public async Task<List<Habitaciones>> ConsultarHabitacion(Habitaciones P_Entidad)
        {
            List<Habitaciones> lista = new List<Habitaciones>();

            InicializarCliente();
            string urlConsultarHabitacion = "api/Seguridad/ConsultarHabitacion";
            HttpResponseMessage resultado = await Cliente.GetAsync(urlConsultarHabitacion);

            if (resultado.IsSuccessStatusCode)
            {
                var convertirAstring = await resultado.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<Habitaciones>>(convertirAstring);
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
        }

        #endregion


        #endregion

    }
}
