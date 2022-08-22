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
    public class UsuariosFEController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Conexiones objconexion = new Conexiones();

            List<Usuarios> lstresultados = await objconexion.Consultar(new Usuarios { NombreUsuario = string.Empty });
            return View(lstresultados);

        }


        public IActionResult CrearUsuario()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Guardar(IFormCollection colection)
        {

            Usuarios usr = new Usuarios
            {

                IdUsuario = Convert.ToInt32(colection["IdUsuario"].ToString()),
                NombreUsuario = colection["NombreUsuario"].ToString(),
                ApellidoUsuario = colection["ApellidoUsuario"].ToString(),
                IdentificacionUsuario = colection["IdentificacionUsuario"].ToString(),
                IdLogueo = colection["IdLogueo"].ToString(),
                Contrasena = colection["Contrasena"].ToString(),
                IdDireccionPais = Convert.ToInt32(colection["IdDireccionPais"].ToString()),
                IdDireccionProvincia = Convert.ToInt32(colection["IdDireccionProvincia"].ToString()),
                Direccionotrassenasusuario = colection["Direccionotrassenasusuario"].ToString(),
                CorreoUsuario = colection["CorreoUsuario"].ToString(),
                TelefonoUsuario = colection["TelefonoUsuario"].ToString(),
                EstadoUsuario = Convert.ToBoolean(colection["EstadoUsuario"].ToString()),
            };

            Conexiones objconexion = new Conexiones();
            await objconexion.Agregar(usr);

            return RedirectToAction("Index", "UsuariosFE");
        }


    }
}
