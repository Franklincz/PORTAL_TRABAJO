using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PORTAL_TRABAJO.Web.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class OfertalaboralController : Controller
    {


        private readonly IOfertaRepository _ofertaRepository ;
        private readonly DBPortaldeEmpleoContext _context;

        public OfertalaboralController(IOfertaRepository ofertaRepository , DBPortaldeEmpleoContext context)
        {
            _ofertaRepository = ofertaRepository;
            _context = context;
        }


       

        public List<Ofertalaboral> SearchOffers(string offerTitle, string companyName)
        {
            return _ofertaRepository.SearchOffer(offerTitle, companyName);
        }


        [Route("postulantes-details/{id:int:min(1)}", Name = "VerPostulantesOferta")]
        public async Task<IActionResult> verPostulantesOferta(int? id, string searchString /*int? pageSize, int? page */)//int? id
        {

           
            var listasPostulantes = await _ofertaRepository.verPostulantesOferta(id,searchString);
       


          
            ViewData["CurrentFilter"] = searchString;


            

            return View(listasPostulantes);

        }
      

        public async Task<IActionResult> GetAllOfertas()
        {
            var data = await _ofertaRepository.GetAllOfertas();
            return View(data);
        }







        //add
        public IActionResult Principal()
        {

            ViewData["EstadocivilIdestciv"] = new SelectList(_context.Jornada, "Id", "Descripcion");
            return View();
        }





        [HttpPost]

        public IActionResult Crear(int idRegistro, string Titulo, string Descripcionpuesto, string Detalle, string Perfil,
              string Requisitos, string Beneficios, string Lugar, int Jornada, decimal Salario, string Modalidad , DateTime FechaInicio,DateTime FechaFin)
        {
            var oferta = new Ofertalaboral()
            {
                Titulooferta = Titulo,
                Descripcionpuesto = Descripcionpuesto,
                Detalleoferta = Detalle,
                Perfilcandidato = Perfil,
                Requisitos = Requisitos,
                Fechafin=FechaFin,
                Fechapublicacion=FechaInicio,
                EmpresaId = int.Parse(SessionHelper.GetValue(User, "ID_EMPRESA")),//int.Parse(SessionHelper.GetValue(User, "ID_EMPRESA")),
                JornadaId =Jornada,
                Salario = Salario,
                
            };



            bool exito = true;
            if (idRegistro == -1)
            {
                exito = OfertaRepository.Insertar(oferta);

            }
            else
            {
                oferta.Id = idRegistro;
                exito = OfertaRepository.Insertar(oferta);

            }
            return Json(exito);
        }

        public async Task<IActionResult> MisOfertas()
        {


            int idEmpresa = int.Parse(SessionHelper.GetValue(User, "ID_EMPRESA"));//obtener el id de la persona logueada


            var misOfertaspublicadas = await _ofertaRepository.listOfertPublicadas(idEmpresa);

            return PartialView(misOfertaspublicadas);
        }




















    }
}
