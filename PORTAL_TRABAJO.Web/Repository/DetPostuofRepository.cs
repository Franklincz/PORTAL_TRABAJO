using Microsoft.EntityFrameworkCore;
using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Repository
{
    public class DetPostuofRepository:IDetPostulacionRepository
    {
        private readonly DBPortaldeEmpleoContext _context;
        public DetPostuofRepository(DBPortaldeEmpleoContext context)
        {

            _context = context;
        }
        public async Task<List<Detpostuof>> postulacionesCandidato(int id)
        {
            var list = await _context.Detpostuof.Include(c=>c.Ofertalaboral.Empresa).Where(x=>x.CandidatoIdcandidat==id).ToListAsync();
            //
          //  var listapostulaciones = await _context.Detpostuof.Include(x => x.Ofertalaboral).Include("Empresa").Where(x => x.CandidatoIdcandidat == id).ToListAsync();



            return list;
        }


      
    }
}
