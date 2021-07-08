using Microsoft.AspNetCore.Mvc;
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
        [Route("Postular", Name = "postular")]
        public IActionResult Postular()
            {
                return View();
            }
        }
    
}
