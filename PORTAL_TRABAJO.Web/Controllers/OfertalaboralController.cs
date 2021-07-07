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
namespace PORTAL_TRABAJO.Web.Controllers
{
    public class OfertalaboralController : Controller
    {
       //in this controller not reference context

        private readonly IOfertaRepository _ofertaRepository ;


        public OfertalaboralController(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }


        public IActionResult Index()
        {
            return View();
        }


        public List<Ofertalaboral> SearchOffers(string offerTitle, string companyName)
        {
            return _ofertaRepository.SearchOffer(offerTitle, companyName);
        }

        //public async Task<IActionResult> verPostulantesOferta(int? id)//int? id
        //{


        //    var ofertas= await _ofertaRepository.verPostulantesOferta(1);
        //    //ViewData["cantidad"]=ofertas.le

        //    return View(ofertas);

        //}

        public async Task<IActionResult> verPostulantesOferta(int? id, string searchString /*int? pageSize, int? page */)//int? id
        {

           
            var listasPostulantes = await _ofertaRepository.verPostulantesOferta(id,searchString);
       


            //pageSize = (pageSize ?? 10);
            //page = (page ?? 1);
            ViewData["CurrentFilter"] = searchString;


            

            return View(listasPostulantes);

        }
        public async Task<IActionResult> MisOfertas()
        {


            var idEmpresa = int.Parse(SessionHelper.GetValue(User, "ID_EMPRESA"));


            var misOfertaspublicadas = await _ofertaRepository.listOfertPublicadas(idEmpresa);

            return View(  misOfertaspublicadas);
        }

        public async Task<IActionResult> GetAllOfertas()
        {
            var data = await _ofertaRepository.GetAllOfertas();
            return View(data);
        }


       



    }
}
