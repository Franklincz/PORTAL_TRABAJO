using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Repository
{
    public interface IDetPostulacionRepository
    {
        Task<List<Detpostuof>> postulacionesCandidato(int id);


    }
}
