using FrondEnd_ProyectoPA.ConexionesApis;
using FrondEnd_ProyectoPA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FrondEnd_ProyectoPA.Controllers
{
    public class BusController : Controller
    {
        [Authorize(Roles = "5")]
        public async Task<IActionResult> Index()
        {

            Conexiones objconexion = new Conexiones();

            List<Bus> lstresultados = await objconexion.ConsultarBus(new Bus { Marca = string.Empty });
            return View(lstresultados);

        }

        public IActionResult CrearBus()
        {
            return View();
        }

        public IActionResult ModificarBus()
        {
            return View();
        }

        public IActionResult EliminarBus()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AgregarBus(IFormCollection colection)
        {

            Bus usr = new Bus
            {

                Id_Bus = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Placa = colection["NombreUsuario"].ToString(),
                Marca = colection["Contrasena"].ToString(),
                Id_Estado = colection["CorreoUsuario"].ToString(),
                Id_Ruta = colection["CorreoUsuario"].ToString(),
                Id_Chofer = colection["CorreoUsuario"].ToString(),


    };

            Conexiones objconexion = new Conexiones();
            await objconexion.AgregarBus(usr);

            return RedirectToAction("Index", "Bus");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarBus(IFormCollection colection)
        {

            Bus usr = new Bus
            {

                Id_Bus = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Placa = colection["NombreUsuario"].ToString(),
                Marca = colection["Contrasena"].ToString(),
                Id_Estado = colection["CorreoUsuario"].ToString(),
                Id_Ruta = colection["CorreoUsuario"].ToString(),
                Id_Chofer = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.EliminarBus(usr);

            return RedirectToAction("Index", "Bus");
        }

        [HttpPost]
        public async Task<IActionResult> ModificarBus(IFormCollection colection)
        {

            Bus usr = new Bus
            {

                Id_Bus = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Placa = colection["NombreUsuario"].ToString(),
                Marca = colection["Contrasena"].ToString(),
                Id_Estado = colection["CorreoUsuario"].ToString(),
                Id_Ruta = colection["CorreoUsuario"].ToString(),
                Id_Chofer = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.ModificarBus(usr);

            return RedirectToAction("Index", "Ruta");
        }
    }
}
