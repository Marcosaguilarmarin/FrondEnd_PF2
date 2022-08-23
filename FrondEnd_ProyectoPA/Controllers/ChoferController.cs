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

        public async Task<IActionResult> Index()
        {

            Conexiones objconexion = new Conexiones();

            List<Chofer> lstresultados = await objconexion.ConsultarChofer(new Chofer { NombreUsuario = string.Empty });
            return View(lstresultados);

        }

        public IActionResult CrearChofer()
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


    }
}
