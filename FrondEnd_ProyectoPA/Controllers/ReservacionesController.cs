using FrondEnd_ProyectoPA.ConexionesApis;
using FrondEnd_ProyectoPA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FrondEnd_ProyectoPA.Controllers
{
    public class ReservacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]

        public async Task<IActionResult> GuardarReserva(IFormCollection colection)
        {
            Reservaciones reserv = new Reservaciones
            {

                IdReservaciones = Convert.ToInt32(colection["IdReservaciones"].ToString()),
                CodigoReservacion = Convert.ToInt32(colection["CodigoReservacion"].ToString()),
                CantidadAdultos = Convert.ToInt32(colection["CantidadAdultos"].ToString()),
                Cantidadninos = Convert.ToInt32(colection["Cantidadninos"].ToString()),
                IdUsuario = Convert.ToInt32(colection["IdUsuario"].ToString()),
                IdClientes =Convert.ToInt32(colection["IdClientes"].ToString()),
                IdHabitacion = Convert.ToInt32(colection["IdHabitacion"].ToString()),
                FechaReservacion = DateTime.Now,
                Fechaestadiainicial = Convert.ToDateTime(colection["Fechaestadiainicial"].ToString()),
                Fechaestadiafinal = Convert.ToDateTime(colection["Fechaestadiafinal"].ToString())

            };

            Conexiones objconexion = new Conexiones();
            await objconexion.AgregarReserva(reserv);

            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> ConsultaReserva()
        {
            Conexiones objconexion = new Conexiones();

            List<Reservaciones> lstresultados = await objconexion.ConsultarReserva(new Reservaciones { CodigoReservacion = 0 });
            return View(lstresultados);

        }


    }
}
