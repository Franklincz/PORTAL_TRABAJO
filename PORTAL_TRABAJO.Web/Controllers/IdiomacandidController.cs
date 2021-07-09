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
    public class IdiomacandidController : Controller
    {
        private readonly DBPortaldeEmpleoContext _context;

       
            

            public IdiomacandidController(DBPortaldeEmpleoContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult IndexIdioma()
            {
                ViewData["IdiomaId"] = new SelectList(_context.Idioma, "Id", "Descripcion");
                ViewData["NiveloralidiId"] = new SelectList(_context.Niveloralidi, "Id", "Descripcion");
                ViewData["NivescridId"] = new SelectList(_context.Nivescrid, "Id", "Descripcion");
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Eliminar(int id)
            {
                bool exito = await IdiomacandidRepository.Eliminar(id);
                return Json(exito);
            }
            public async Task<IActionResult> ListadoIdioma()
            {
                var portalEmpleo4Context = _context.Idiomacandid.Include(i => i.CandidatoIdcandidatNavigation).Include(i =>
                i.Idioma).Include(i => i.Niveloralidi).Include(i => i.Nivescrid).Where(x => x.CandidatoIdcandidat == int.Parse(SessionHelper.GetNameIdentifier(User)));

                return PartialView(await portalEmpleo4Context.ToListAsync());
            }

            public async Task<IActionResult> Obtener(int id)
            {
                var idiomacand = await IdiomacandidRepository.Obtener(id);
                //ViewData["IdiomaId"] = new SelectList(_context.Idioma, "Id", "Descripcion", idiomacandid.IdiomaId);
                //ViewData["NiveloralidiId"] = new SelectList(_context.Niveloralidi, "Id", "Descripcion", idiomacandid.Niveloralidi);
                //ViewData["NivescridId"] = new SelectList(_context.Nivescrid, "Id", "Descripcion", idiomacandid.NivescridId);

                return Json(idiomacand);
            }

            public IActionResult NewIdioma()
            {

                return View();
            }
            [HttpPost]
            public async Task<IActionResult> IndexIdioma(int id,
                int idioma, int NivOral, int NivEscr
                )
            {
                int idCandidato = int.Parse(SessionHelper.GetNameIdentifier(User));
                var idiomacandid = new Idiomacandid()
                {
                    CandidatoIdcandidat = idCandidato,
                    IdiomaId = idioma,
                    NiveloralidiId = NivOral,
                    NivescridId = NivEscr


                };
                ViewData["IdiomaId"] = new SelectList(_context.Idioma, "Id", "Descripcion", idiomacandid.IdiomaId);
                ViewData["NiveloralidiId"] = new SelectList(_context.Niveloralidi, "Id", "Descripcion", idiomacandid.Niveloralidi);
                ViewData["NivescridId"] = new SelectList(_context.Nivescrid, "Id", "Descripcion", idiomacandid.NivescridId);


                bool exito = true;
                if (id == -1)
                    exito = await IdiomacandidRepository.Insertar(idiomacandid);
                else
                {
                    idiomacandid.Ididioma = id;
                    exito = await IdiomacandidRepository.Actualizar(idiomacandid);
                }
                return Json(exito);


            }
        }
    }
