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
    }
}
