using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }
        public async Task<IActionResult> Listado()
        {
            var empresas = await EmpresaRepository.ListadoAsincrono();
            return PartialView(empresas);
        }

        public async Task<IActionResult> Obtener(int idEmpresa)
        {
            var empresa = await EmpresaRepository.Obtener(idEmpresa);
            return Json(empresa);
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(int idEmpresa)
        {
            bool exito = await EmpresaRepository.Eliminar(idEmpresa);
            return Json(exito);
        }

        [HttpPost]
        public async Task<IActionResult> Grabar(int idEmpresa,
            string ruc, string ubicacion, string email, string industria,
            string telefono, string descripcion, string razonSocial)
        {
            var empresa = new Empresa()
            {
                Ruc = ruc,
                Ubicacion = ubicacion,
                Email = email,
                Industria = industria,
                Telefono = telefono,
                Descripcionempr = descripcion,
                Razonsocial = razonSocial
            };

            bool exito = true;
            if (idEmpresa == -1)
                exito = await EmpresaRepository.Insertar(empresa);
            else
            {
                empresa.Id = idEmpresa;
                exito = await EmpresaRepository.Actualizar(empresa);
            }
            return Json(exito);
        }
    }
}
