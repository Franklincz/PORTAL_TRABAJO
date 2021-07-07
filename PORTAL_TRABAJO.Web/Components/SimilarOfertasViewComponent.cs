using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Components
{
    public class SimilarOfertasViewComponent: ViewComponent
    {
        private readonly IOfertaRepository _ofertaRepository;

        public SimilarOfertasViewComponent(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var ofertas = await _ofertaRepository.GetSimilarOfertasAsync(id);
            return View(ofertas);
        }

    }
}
