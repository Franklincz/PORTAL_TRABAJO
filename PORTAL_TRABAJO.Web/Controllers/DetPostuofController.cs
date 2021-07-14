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
  
        public class DetPostuofController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        
       [HttpGet]
        public async Task< IActionResult> Postular(int? id)
            {
            if (SessionHelper.GetValue(User, "Dato") == "CANDIDATO")
            {
                ViewData["IdOferta"] = id;



                return View();


            }
            else
            {
                return RedirectToAction("LoginCandidato", "Cuenta");
            }
           
            }

        [HttpPost]
        public async Task< IActionResult> Grabar(int idPostulante, string Celular,string Email,string Experiencia, int IdOferta)
        {
            int idCand = int.Parse(SessionHelper.GetNameIdentifier(User));
            var postulacion = new Detpostuof()
            {
                CandidatoIdcandidat  = idCand,
                Detalles= "Mi numero de celular es"+ Celular+"Mi Email"+Email + "Mi experiencia"+Experiencia,
                OfertalaboralId=IdOferta,
                Estado="Enviado"


            };
            bool exito = true;
            if (idPostulante == -1)
                exito = await DefpostuRepository.Insertar(postulacion);
            else
            {
                //candidato.Idcandidat = Id;
                //exito = await CandidatoRepository.Actualizar(candidato);
            }


            return Json(exito);




            
        }


    }
    
}
