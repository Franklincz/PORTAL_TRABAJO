using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.ModelsView
{
    public class CandidatoVM
    {

        [Required(ErrorMessage = "Ingrese su correo electronico")]
        //public string Nombres { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "Ingrese su password")]
        public string Contraseña { get; set; }
        [NotMapped]
        public IFormFile foto { get; set; }




    }
}
