using FrondEnd_ProyectoPA.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "4")]
        public IActionResult Rutas()
        {
            return View();
        }
        [Authorize(Roles = "2")]
        public IActionResult Catalogos()
        {
            return View();
        }
        [Authorize(Roles = "5")]
        public IActionResult Buses()
        {
            return View();
        }
        [Authorize(Roles = "1")]
        public IActionResult Consultas()
        {
            return View();
        }

        [Authorize(Roles = "3")]
        public IActionResult Chofer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
