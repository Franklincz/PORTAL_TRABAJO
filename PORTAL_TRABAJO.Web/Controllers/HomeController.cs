using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PORTAL_TRABAJO.Web.Helper;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOfertaRepository _ofertaRepository ;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IOfertaRepository ofertaRepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _ofertaRepository = ofertaRepository;
        }

        public IActionResult Index()
        {


            //if (SessionHelper.GetValue(User, "Dato") == "ADMIEMPRESA")
            //{

            //    return RedirectToAction("MisOfertas", "Empresa");
            //}
            //


            if (SessionHelper.GetValue(User, "Dato") == "ADMIEMPRESA")
            {
                return RedirectToAction("MisOfertas", "Empresa");
               
            }
            if (SessionHelper.GetValue(User, "Dato") == "CANDIDATO")
            {
                return RedirectToAction("GetAllOfertas", "Ofertalaboral");
            }
                    else
                    {
                return View();
            }
          
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [Route("oferta-details/{id:int:min(1)}", Name = "ofertaDetailsRoute")]
        public async Task<ViewResult> GetOferta(int id)
        {
            var data = await _ofertaRepository.GetOfertaById(id);

            return View(data);













        }
    }
}