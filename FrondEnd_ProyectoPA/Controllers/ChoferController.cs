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
    public class ChoferController : Controller
    {
        [Authorize(Roles = "3")]
        public async Task<IActionResult> Index(string buscar)
        {

            Conexiones objconexion = new Conexiones();
            Chofer objchofer = new Chofer();

            if (!string.IsNullOrEmpty(buscar))
                objchofer.NombreUsuario = buscar;

            List<Chofer> lstresultados = await objconexion.ConsultarChofer(new Chofer { NombreUsuario = string.Empty });
            return View(lstresultados);

        }

        public IActionResult CrearChofer()
        {
            return View();
        }

        public IActionResult ModificarChofer()
        {
            return View();
        }

        public IActionResult EliminarChofer()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> GuardarChofer(IFormCollection colection)
        {

            Chofer usr = new Chofer
            {

                Id_Chofer = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                NombreUsuario = colection["NombreUsuario"].ToString(),
                Contrasena = colection["Contrasena"].ToString(),
                CorreoUsuario = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.AgregarChofer(usr);

            return RedirectToAction("Index", "Chofer");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarChofer(IFormCollection colection)
        {

            Chofer usr = new Chofer
            {

                Id_Chofer = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                NombreUsuario = colection["NombreUsuario"].ToString(),
                Contrasena = colection["Contrasena"].ToString(),
                CorreoUsuario = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.EliminarChofer(usr);

            return RedirectToAction("Index", "Chofer");
        }

        [HttpPost]
        public async Task<IActionResult> ModificarChofer(IFormCollection colection)
        {

            Chofer usr = new Chofer
            {

                Id_Chofer = colection["Id_Chofer"].ToString(),    //Convert.ToInt32(colection["Id_Chofer"].ToString()),
                NombreUsuario = colection["NombreUsuario"].ToString(),
                Contrasena = colection["Contrasena"].ToString(),
                CorreoUsuario = colection["CorreoUsuario"].ToString(),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.ModificarChofer(usr);

            return RedirectToAction("Index", "Chofer");
        }



    }
}
