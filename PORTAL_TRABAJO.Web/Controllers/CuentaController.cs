
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PORTAL_TRABAJO.Web.Helper;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class CuentaController : Controller
    {


        private readonly DBPortaldeEmpleoContext context;
        public CuentaController(DBPortaldeEmpleoContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginCandidato()
        {
          
            return View();

        }
        [BindProperty]
        public CandidatoVM Candidato { get; set; }
        public async Task<IActionResult> IniciarSesionCandidato()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new JObject()
                {


                      {"StatusCode",400},
                       {"Message","El usuario ya existe , seleccione otro"}

                });
            }
            else
            {

                var result = await context.Candidato.Where(x => x.Correo == Candidato.Correo).SingleOrDefaultAsync();
                if (result == null)
                {

                    return BadRequest(new JObject()
                {


                      {"StatusCode",404},
                       {"Message","Usuario no encontrado"}

                });




                }
                else
                {

                    if (HashHelper.CheckHash(Candidato.Contraseña, result.Contraseña, result.SalCandidato))
                    {

                        //para la validacion de periodo de
                        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, result.Idcandidat.ToString()));//id candidato
                        identity.AddClaim(new Claim(ClaimTypes.Name,( result.Nombres + result.Apellidos)));
                        identity.AddClaim(new Claim(ClaimTypes.Email, result.Correo));
                        identity.AddClaim(new Claim(ClaimTypes.Email, result.Correo));
                        identity.AddClaim(new Claim("Dato", "CANDIDATO"));//Dato:es mi clave , y el result.Correo.ToString() es lo que muestro
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                         new AuthenticationProperties { ExpiresUtc = DateTime.Now.AddDays(1), IsPersistent = true });





                        //cambios
                        return Ok(result);
                        
                    }
                    else
                    {

                        var response = new JObject()
                        {
                         {"StatusCode",403},
                       {"Message","Usuario no encontrado"}
                        };

                        return StatusCode(403, response);//error parecido al 403
                    }



                }

            }


             

        }














        public IActionResult LoginAdEmpresa()
        {



            return View();
        }

        [BindProperty]
        public AdmiEmpresaVM AdmiEmpresa { get; set; }
        public async Task<IActionResult> IniciarSesionAdmiEmpresa()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new JObject()
                {


                      {"StatusCode",400},
                       {"Message","El usuario ya existe , seleccione otro"}

                });
            }
            else
            {

                var result = await context.Admiempresa.Where(x => x.Correo == AdmiEmpresa.Correo).SingleOrDefaultAsync();
                if (result == null)
                {

                    return BadRequest(new JObject()
                {


                      {"StatusCode",404},
                       {"Message","Usuario no encontrado"}

                });




                }
                else
                {

                    if (HashHelper.CheckHash(AdmiEmpresa.Contraseña, result.Contraseña, result.SalAdmiEmpresa))
                    {

                        //para la validacion de periodo de
                        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                        identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));
                        identity.AddClaim(new Claim(ClaimTypes.Name, (result.Nombre + result.Apellidos)));
                        identity.AddClaim(new Claim(ClaimTypes.Email, result.Correo));
                        identity.AddClaim(new Claim("ID_EMPRESA", result.EmpresaId.ToString()));//id empresa a la cual administra
                        identity.AddClaim(new Claim("Dato", "ADMIEMPRESA"));//Dato:es mi clave , y el result.Correo.ToString() es lo que muestro
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                           new AuthenticationProperties { ExpiresUtc = DateTime.Now.AddDays(1), IsPersistent = true });
                        




                        //cambios
                        return Ok(result);
                    }
                    else
                    {

                        var response = new JObject()
                        {
                         {"StatusCode",403},
                       {"Message","Usuario no encontrado"}
                        };

                        return StatusCode(403, response);//error parecido al 403
                    }



                }

            }




        }




        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }






    













    }
}
