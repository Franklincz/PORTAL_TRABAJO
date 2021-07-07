using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PORTAL_TRABAJO.Web.Helper;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Controllers
{
    public class CandidatoController : Controller
    {



        private readonly IDetPostulacionRepository _postulacionRepository;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly DBPortaldeEmpleoContext _context;
       
        public CandidatoController(DBPortaldeEmpleoContext context, IWebHostEnvironment hostEnvironment , IDetPostulacionRepository postulacionRepository)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _postulacionRepository=postulacionRepository;
        }
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult PerfilCandidato()
        {

            int id = int.Parse(SessionHelper.GetNameIdentifier(User));//obtengo el id del usuario logueado
            var candidato = _context.Candidato.Where(x => x.Idcandidat == id).FirstOrDefault();
            return View(candidato);
        }



        public IActionResult ListadoHabilidades()
        {
            return PartialView();
        }
        public IActionResult Create()
        {

            return View();

        }
        public async Task<IActionResult> Listado()
        {
            var candidato = await CandidatoRepository.ListadoAsincrono();
            return PartialView(candidato);
        }
        [HttpPost]
        public async Task<IActionResult> EliminarAsync(int idCandidato)
        {
            bool exito = await CandidatoRepository.Eliminar(idCandidato);
            return Json(exito);
        }
        public IActionResult NewCandidato()
        {

            var estado = _context.Estadocivil.ToList();
            ViewData["EstadocivilIdestciv"] = new SelectList(_context.Estadocivil, "Idestciv", "Descripcion");
            ViewData["GeneroIdgenero"] = new SelectList(_context.Genero, "Idgenero", "Descripcion");
            return View();
        }



        [HttpPost]   
        public async Task<IActionResult> NewCandidato(IFormFile file , int Id ,string Nombres,
            string Apellidos , string Dni , DateTime FechaNacimiento , string Telefono , string Descripcion , 
            string Correo , string Contraseña, int Genero , int EstadoCivil)
        {

            
            bool exito = true;
            string nombreArchivo=null;
            List<string> errors = new List<string>(); // added this just to return something
            var hash = HashHelper.Hash(Contraseña);
            if (file != null)
            {
                string folder = "Images/pdf/";
                   nombreArchivo = await UploadImage(folder, file);
               

            }
            var candidato = new Candidato()
            {
                Nombres = Nombres,
                Apellidos = Apellidos,
                Fechanacim = FechaNacimiento,
                EstadocivilIdestciv = EstadoCivil,
                Dni = Dni,
                Dochojavida = nombreArchivo,
                Telefono = Telefono,
                Correo = Correo,
                GeneroIdgenero = Genero,
                Descrpperfil = Descripcion,
                Contraseña = hash.Password,//le asigno el valor que me devuelve
                SalCandidato = hash.Salt


            };
            if (Id == -1)
                exito = await CandidatoRepository.Insertar(candidato);
            else
            {
                candidato.Idcandidat = Id;
                exito = await CandidatoRepository.Actualizar(candidato);
            }


            return Json(exito);


        }


        

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_hostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }


        public async Task <IActionResult> verMisPostulaciones()
        {

            var mispostulaciones = await _postulacionRepository.postulacionesCandidato(int.Parse(SessionHelper.GetNameIdentifier(User)));

            return View(mispostulaciones);
        }

    }
}
