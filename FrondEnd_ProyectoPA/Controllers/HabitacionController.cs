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
    public class HabitacionController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {

            Conexiones objconexion = new Conexiones();

            List<Habitaciones> lstresultados = await objconexion.ConsultarHabitacion(new Habitaciones { NombreHabitacion = string.Empty });
            return View(lstresultados);

        }

        public IActionResult CrearHabitacion()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> GuardarHabitacion(IFormCollection colection)
        {

            Habitaciones habita = new Habitaciones
            {
                IdHabitaciones = Convert.ToInt32(colection["IdHabitaciones"].ToString()),
                TipoHabitacion = colection["TipoHabitacion"].ToString(),
                NombreHabitacion = colection["NombreHabitacion"].ToString(),
                CapacidadHabitacion = Convert.ToInt32(colection["CapacidadHabitacion"].ToString()),
                Precionochepersona = Convert.ToDecimal(colection["Precionochepersona"].ToString()),
                Numerohabitacion = Convert.ToInt32(colection["Numerohabitacion"].ToString()),
                Estadohabitacion = Convert.ToBoolean(colection["Estadohabitacion"].ToString())
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.AgregarHabitacion(habita);

            return RedirectToAction("Index", "Habitacion");
        }

    }
}
