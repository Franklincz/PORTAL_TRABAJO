using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Repository
{
    public interface IOfertaRepository
    {
        
        Task<List<Ofertalaboral>> GetAllOfertas();
        Task<Ofertalaboral> GetOfertaById(int id);
        Task<List<Ofertalaboral>> GetTopOfertasAsync(int count);

        Task<List<Ofertalaboral>> GetSimilarOfertasAsync(int id);

        Task<List<Detpostuof>> verPostulantesOferta(int? id, string searchString);

         Task<List<Ofertalaboral>> listOfertPublicadas(int idEmpresa);
        List<Ofertalaboral> SearchOffer(string offerTitle, string companyName);
    }
}
