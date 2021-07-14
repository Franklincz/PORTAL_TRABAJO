using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PORTAL_TRABAJO.Web.Helper;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class FormaccandController : Controller
    {
        private readonly DBPortaldeEmpleoContext _context;
        public FormaccandController(DBPortaldeEmpleoContext context)
        {
            _context = context;
        }
        public IActionResult IndexFormAcademic()
        {
            ViewData["AreaestudioId"] = new SelectList(_context.Areaestudio, "Id", "Descripcion");
            ViewData["CandidatoIdcandidat"] = new SelectList(_context.Candidato, "Idcandidat", "Idcandidat");
            ViewData["PaisId"] = new SelectList(_context.Pais, "Id", "Descripcion");
            ViewData["TipoestudioId"] = new SelectList(_context.Tipoestudio, "Id", "Descripcion");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool exito = await FormaccandRepository.Eliminar(id);
            return Json(exito);
        }
        public async Task<IActionResult> ListadoFormAcad()
        {
            var portalEmpleo4Context = _context.Formaccand.Include(f => f.Areaestudio).Include(f => f.CandidatoIdcandidatNavigation).Include(f => f.Pais).Include(f => f.Tipoestudio).Where(x => x.CandidatoIdcandidat == int.Parse(SessionHelper.GetNameIdentifier(User)));
            return PartialView(await portalEmpleo4Context.ToListAsync());
        }
        [HttpPost]
    
        public async Task<IActionResult> IndexFormAcademic(int id,
           string CentroEduc, int TipoEstudio, string TituloCarrera, int AreaEst,
           DateTime FechIn, DateTime FechTerm, int Pais)
        {
            int idCandidato = int.Parse(SessionHelper.GetNameIdentifier(User));
            var formaccand = new Formaccand()
            {
                CandidatoIdcandidat = idCandidato,
                Nombrecentroed = CentroEduc,
                Fechainicio = FechIn,
                Fechafin = FechTerm,
                TipoestudioId = TipoEstudio,
                PaisId = Pais,
                AreaestudioId = AreaEst,
                Titulocarrera = TituloCarrera,


            };
            ViewData["AreaestudioId"] = new SelectList(_context.Areaestudio, "Id", "Descripcion", formaccand.AreaestudioId);
            ViewData["CandidatoIdcandidat"] = new SelectList(_context.Candidato, "Idcandidat", "Idcandidat", formaccand.CandidatoIdcandidat);
            ViewData["PaisId"] = new SelectList(_context.Pais, "Id", "Descripcion", formaccand.PaisId);
            ViewData["TipoestudioId"] = new SelectList(_context.Tipoestudio, "Id", "Descripcion", formaccand.TipoestudioId);

            bool exito = true;
            if (id == -1)
                exito = await FormaccandRepository.Insertar(formaccand);
            else
            {
                formaccand.Idformacadem = id;
                exito = await FormaccandRepository.Actualizar(formaccand);
            }
            return Json(exito);




        }



    }
}
