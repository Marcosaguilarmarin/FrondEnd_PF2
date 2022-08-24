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
    public class RutaController : Controller
    {
        [Authorize(Roles = "4")]
        public async Task<IActionResult> Index()
        {

            Conexiones objconexion = new Conexiones();

            List<Ruta> lstresultados = await objconexion.ConsultarRuta(new Ruta { Nombre = string.Empty });
            return View(lstresultados);

        }

        public IActionResult CrearRuta()
        {
            return View();
        }

        public IActionResult ModificarRuta()
        {
            return View();
        }

        public IActionResult EliminarRuta()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> GuardarRuta(IFormCollection colection)
        {

            Ruta usr = new Ruta
            {

                Id_Ruta = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Nombre = colection["NombreUsuario"].ToString(),
                MontoEstimado = colection["Contrasena"].ToString(),
                MontoRecibido = colection["CorreoUsuario"].ToString(),

    };

            Conexiones objconexion = new Conexiones();
            await objconexion.AgregarRuta(usr);

            return RedirectToAction("Index", "Ruta");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarRuta(IFormCollection colection)
        {

            Ruta usr = new Ruta
            {

                Id_Ruta = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Nombre = colection["NombreUsuario"].ToString(),
                MontoEstimado = colection["Contrasena"].ToString(),
                MontoRecibido = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.EliminarRuta(usr);

            return RedirectToAction("Index", "Ruta");
        }

        [HttpPost]
        public async Task<IActionResult> ModificarRuta(IFormCollection colection)
        {

            Ruta usr = new Ruta
            {

                Id_Ruta = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                Nombre = colection["NombreUsuario"].ToString(),
                MontoEstimado = colection["Contrasena"].ToString(),
                MontoRecibido = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.ModificarRuta(usr);

            return RedirectToAction("Index", "Ruta");
        }

    }
}
