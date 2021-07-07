using Microsoft.EntityFrameworkCore;
using PORTAL_TRABAJO.Web.Helper;
using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PORTAL_TRABAJO.Web.Repository

{


    public class OfertaRepository : IOfertaRepository
    {
        private readonly DBPortaldeEmpleoContext _context ;
        public OfertaRepository(DBPortaldeEmpleoContext context)
        {

            _context = context;
        }


        public async Task<List<Ofertalaboral>> GetTopOfertasAsync(int count)
        {
            return await _context.Ofertalaboral
                  .Select(oferta => new Ofertalaboral()
                  {
                      Id = oferta.Id,
                      Titulooferta = oferta.Titulooferta,
                      Detalleoferta = oferta.Detalleoferta,
                      Perfilcandidato = oferta.Perfilcandidato,
                      Requisitos = oferta.Requisitos,
                      Salario = oferta.Salario,
                      Fechapublicacion = oferta.Fechapublicacion,
                      Fechafin = oferta.Fechafin,
                      Empresa=oferta.Empresa,
                      Jornada=oferta.Jornada,
                      JornadaId = oferta.JornadaId,
                      EmpresaId = oferta.EmpresaId,
                  }).Take(count).ToListAsync();
        }



        public async Task<Ofertalaboral> GetOfertaById(int id)
        {
            return await _context.Ofertalaboral.Where(x => x.Id == id)//aqui iba el includ empresa 
                 .Select(oferta => new Ofertalaboral()
                 {
                     Id = oferta.Id,
                     Titulooferta = oferta.Titulooferta,
                     Detalleoferta = oferta.Detalleoferta,
                     Perfilcandidato = oferta.Perfilcandidato,
                     Requisitos = oferta.Requisitos,
                     Salario = oferta.Salario,
                     Fechapublicacion = oferta.Fechapublicacion,
                     Fechafin = oferta.Fechafin,
                     Jornada=oferta.Jornada,
                     JornadaId = oferta.JornadaId,
                     Empresa = oferta.Empresa,
                     EmpresaId = oferta.EmpresaId,
                     

                 }).FirstOrDefaultAsync();






        }


        public async Task<List<Ofertalaboral>> GetAllOfertas()
        {
            return await _context.Ofertalaboral
                  .Select(oferta => new Ofertalaboral()
                  {
                      Id=oferta.Id,
                      Titulooferta = oferta.Titulooferta,
                      Detalleoferta = oferta.Detalleoferta,
                      Perfilcandidato = oferta.Perfilcandidato,
                      Requisitos = oferta.Requisitos,
                      Salario = oferta.Salario,
                      Fechapublicacion = oferta.Fechapublicacion,
                      Fechafin = oferta.Fechafin,
                      Empresa=oferta.Empresa,
                      Jornada=oferta.Jornada,
                      JornadaId = oferta.JornadaId,
                      EmpresaId = oferta.EmpresaId,
                  }).ToListAsync();
        }



        public async Task<List<Ofertalaboral>> GetSimilarOfertasAsync(int id)
        {
            var ofertaPrsent = await _context.Ofertalaboral.Where(x => x.Id == id).FirstOrDefaultAsync();///aqui va empresa
            //extraemos la catergoria
            var categoriaOEmpresaOferta = ofertaPrsent.Empresa.Industria;


            var OfertaSimilar = await  _context.Ofertalaboral.Include("Jornada").Where(oferta => oferta.Id >= id+1  && oferta.Empresa.Industria== categoriaOEmpresaOferta).ToListAsync();//aqui include Jornada
            //return await _context.Ofertalaboral
            //      .Select(oferta => new Ofertalaboral()
            //      {
            //          Id = oferta.Id,
            //          Titulooferta = oferta.Titulooferta,
            //          Detalleoferta = oferta.Detalleoferta,
            //          Perfilcandidato = oferta.Perfilcandidato,
            //          Requisitos = oferta.Requisitos,
            //          Salario = oferta.Salario,
            //          Fechapublicacion = oferta.Fechapublicacion,
            //          Fechafin = oferta.Fechafin,
            //          JornadaId = oferta.JornadaId,
            //          EmpresaId = oferta.EmpresaId,
            //      }).Take(count).ToListAsync();
            return OfertaSimilar;
        }

        public List<Ofertalaboral> SearchOffer(string offerTitle,  string companyName)
        {


            return _context.Ofertalaboral.Include("Empresa").Where(oferta => oferta.Titulooferta.StartsWith(offerTitle) && oferta.Empresa.Razonsocial == companyName).ToList();


        }



        public async Task<List<Detpostuof>> verPostulantesOferta(int? id , string searchString)
        {
            var idOferta = id ?? 0;

            var _oferta = await _context.Ofertalaboral.FindAsync(idOferta);

            var Oferta = new Ofertalaboral();
            if (_oferta != null)
            {

                Oferta = _oferta;
            }
            //yo muestro todos los candidatos a esa oferta , pasando el id de la oferta
           
            var listapostulaciones= await _context.Detpostuof.Include(x => x.CandidatoIdcandidatNavigation).Where(x => x.OfertalaboralId == idOferta).ToListAsync();

            //yo quiero mostrar el idioma de ese candidadto  ,pasando el id candidato
            //     var idiomCandidato = await _context.Idiomacandid.Include(x => x.Idioma).Where(x => x.CandidatoIdcandidat == 1).ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                //  ofertas = (List<Detpostuof>)ofertas.Where(s => s.CandidatoIdcandidatNavigation.Nombres.Contains(searchString) || s.CandidatoIdcandidatNavigation.Apellidos.Contains(searchString));
                //ofertas= await  Detpostuof(x => x.CandidatoIdcandidatNavigation).Where(x => x.OfertalaboralId == 1).ToListAsync();

                listapostulaciones = await _context.Detpostuof.Include(x => x.CandidatoIdcandidatNavigation).Where(x => x.OfertalaboralId == idOferta && x.CandidatoIdcandidatNavigation.Nombres.Contains(searchString) || x.CandidatoIdcandidatNavigation.Apellidos.Contains(searchString)).ToListAsync();
                //ViewData["cantidad"]=ofertas.le
                Console.WriteLine("-----");
            }




            return listapostulaciones;

        }

        Admiempresa admiempresa = new Admiempresa();
        public  async Task<List<Ofertalaboral>> listOfertPublicadas(int idEmpresa)
        {

            
            
            var lista = await _context.Ofertalaboral.Include("Empresa").Where(x => x.EmpresaId == idEmpresa).ToListAsync();

            return lista;
        }




    }












}