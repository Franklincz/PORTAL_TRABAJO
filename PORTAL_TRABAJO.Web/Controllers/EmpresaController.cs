using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Helper;
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

        private readonly IOfertaRepository _ofertaRepository;

        public EmpresaController(IOfertaRepository ofertaRepository )
        {
            _ofertaRepository = ofertaRepository;
        }

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
            string telefono, string descripcionempr, string razonsocial,string  nombre,string apellidos,string correo,string contraseña,string telefonoAdmi,string direccionAdmi)
        {




            var empresa = new Empresa()
            {
                Ruc = ruc,
                Ubicacion = ubicacion,
                Email = email,
                Industria = industria,
                Telefono = telefono,
                Descripcionempr = descripcionempr,
                Razonsocial = razonsocial
            };

            var hash = HashHelper.Hash(contraseña);//hasheo paass adminEmpresa




            var admi = new Admiempresa()
            {
                Nombre = nombre,
               Apellidos = apellidos,
               Correo = correo,
                Direccion   =direccionAdmi,
                Contraseña = hash.Password,
                Telefono = telefonoAdmi,
               SalAdmiEmpresa=hash.Salt




            };

            bool exito = true;
            if (idEmpresa == -1)
            {
                exito = await EmpresaRepository.Insertar(empresa ,admi);
              
             
            }



            else
            {
                empresa.Id = idEmpresa;
                exito = await EmpresaRepository.Actualizar(empresa);
            }


           

            return Json(exito);
        }




        //para ver mis ofertas
        public async Task<IActionResult> MisOfertas()
        {


            int idEmpresa = int.Parse(SessionHelper.GetValue(User, "ID_EMPRESA"));//obtener el id de la persona logueada


            var misOfertaspublicadas = await _ofertaRepository.listOfertPublicadas(idEmpresa);

            return View(misOfertaspublicadas);
        }





    }
}
