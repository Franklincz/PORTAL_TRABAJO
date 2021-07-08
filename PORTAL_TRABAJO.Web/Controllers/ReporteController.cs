using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class ReporteController : Controller
    {
        public class ReporteEController : Controller
        {
            private readonly DBPortaldeEmpleoContext _context;

            public ReporteEController(DBPortaldeEmpleoContext context)
            {
                _context = context;
            }

            // GET: ReporteE
            public async Task<IActionResult> Index()
            {
                return View(await _context.Empresa.ToListAsync());
            }

            // GET: ReporteE/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var empresa = await _context.Empresa
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (empresa == null)
                {
                    return NotFound();
                }

                return View(empresa);
            }

            // GET: ReporteE/Create
            public IActionResult Create()
            {
                return View();
            }

         
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,Ruc,Ubicacion,Email,Industria,Telefono,Descripcionempr,Razonsocial,Logoempresa")] Empresa empresa)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(empresa);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(empresa);
            }

            // GET: ReporteE/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var empresa = await _context.Empresa.FindAsync(id);
                if (empresa == null)
                {
                    return NotFound();
                }
                return View(empresa);
            }

           
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Ruc,Ubicacion,Email,Industria,Telefono,Descripcionempr,Razonsocial,Logoempresa")] Empresa empresa)
            {
                if (id != empresa.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(empresa);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!EmpresaExists(empresa.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(empresa);
            }

            // GET: ReporteE/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var empresa = await _context.Empresa
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (empresa == null)
                {
                    return NotFound();
                }

                return View(empresa);
            }

            // POST: ReporteE/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var empresa = await _context.Empresa.FindAsync(id);
                _context.Empresa.Remove(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool EmpresaExists(int id)
            {
                return _context.Empresa.Any(e => e.Id == id);
            }
        }
    
}
}
