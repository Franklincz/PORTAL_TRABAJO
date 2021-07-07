using Microsoft.AspNetCore.Mvc;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Components
{
    public class TopOfertasViewComponent:ViewComponent
    {
        private readonly IOfertaRepository _ofertaRepository;

        public TopOfertasViewComponent(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var books = await _ofertaRepository.GetTopOfertasAsync(count);
            return View(books);
        }





    }
}
