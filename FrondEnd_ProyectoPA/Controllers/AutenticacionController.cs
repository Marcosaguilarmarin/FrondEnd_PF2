using FrondEnd_ProyectoPA.ConexionesApis;
using FrondEnd_ProyectoPA.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FrondEnd_ProyectoPA.Controllers
{
    public class AutenticacionController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AccesoDenegado()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IniciarSesion(Usuarios _usuario)
        {
            Usuarios objValidacion = _usuario.ValidarUsuariosSimulado();

            if (objValidacion != null)
            {
                var claims = new List<Claim>()
                            {
                                new Claim(ClaimTypes.Name, objValidacion.NombreUsuario),
                                new Claim("Usuarios", objValidacion.NombreUsuario)
                            };

                foreach (Perfiles item in objValidacion.Perfiles)
                    claims.Add(new Claim(ClaimTypes.Role, item.Codigo.ToString()));

                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));

                return RedirectToAction("Index", "Home");
        }

            return RedirectToAction("Index");

            
          
        }

        [HttpGet]
        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Autenticacion");
        }





        /*
                public async Task<IActionResult>CargarPerfiles()
                {
                    Conexiones objconexion = new Conexiones();

                    List<PerfilesXUsuario> lstPXU = await objconexion.ConsultarPXU(new PerfilesXUsuario { IdPerfilesUsuario = 0 });
                    return (IActionResult)lstPXU;
                }



                [HttpPost]
                public async Task<IActionResult> IniciarSesionAsync(Usuarios _usuario)
                {
                    Conexiones objconexion = new Conexiones();

                    List<Usuarios> lstresultados = await objconexion.Consultar(new Usuarios {IdLogueo = _usuario.IdLogueo });


                    if (lstresultados != null)
                    {


                        var rev = lstresultados.Find(x => x.IdLogueo.ToUpper().Trim().Equals(_usuario.IdLogueo.ToUpper().Trim())
                                                     && x.Contrasena.Trim().Equals(_usuario.Contrasena.Trim())
                                                     && x.EstadoUsuario == true);


                        if (rev != null)
                        {

                            var claims = new List<Claim>()
                            {
                                new Claim(ClaimTypes.Name, rev.NombreUsuario),
                                new Claim("Usuarios", rev.NombreUsuario)
                            };



                            foreach (Perfiles item in rev.Perfiles)
                                claims.Add(new Claim(ClaimTypes.Role, item.IdPerfil.ToString()));

                            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));

                            return RedirectToAction("Index", "Home");
                        }
                        return RedirectToAction("Index", "Autenticacion");

                    }

                    return RedirectToAction("Index", "Autenticacion");

                }

                [HttpGet]

                public async Task<IActionResult> CerrarSesiónAsync()
                {
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    return RedirectToAction("Index", "Autenticacion");
                }
        */

    }
}
