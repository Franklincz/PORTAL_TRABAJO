using Newtonsoft.Json;
using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Repository
{
    public class ExplabcandRepository
    {



        public static async Task<IEnumerable<Explabcand>> ListadoAsincrono()
        {
            //using var data = new SalesContext();
            //var customers = await data.Customer.ToListAsync();

            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync("http://localhost:41565/api/Explabcand/GetExplabcand");
            string apiResponse = await response.Content.ReadAsStringAsync();
            var explabcands = JsonConvert.DeserializeObject<IEnumerable<Explabcand>>(apiResponse);


            return explabcands;
        }



        public static async Task<Explabcand> Obtener(int id)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync("http://localhost:41565/api/Explabcand/GetExplabcandById/" + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var explabcands = JsonConvert.DeserializeObject<Explabcand>(apiResponse);


            return explabcands;
        }


        public static async Task<bool> Insertar(Explabcand explabcand)
        {
            bool exito = true;

            var json = JsonConvert.SerializeObject(explabcand);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var httpClient = new HttpClient();
            using var response = await httpClient
              .PostAsync("http://localhost:41565/api/Explabcand/PostExplabcand", data);
        string apiResponse = await response.Content.ReadAsStringAsync();
           var explabcands = JsonConvert.DeserializeObject<Explabcand>(apiResponse);

            //try
            //{


            //    using var data = new DBPortaldeEmpleoContext();
            //    data.Explabcand.Add(explabcand);
            //    await data.SaveChangesAsync();
                
            //}
            //catch (Exception)
            //{
            //    exito = false;
            //}



            if (explabcands == null)
                  exito = false;






            return exito;
        }


        public static async Task<bool> Actualizar(Explabcand explabcand)
        {
            bool exito = true;

            try
            {

                using var httpClient = new HttpClient();
                using var response = await httpClient
                    .GetAsync("http://localhost:41565/api/Explabcand/GetExplabcandById/" + explabcand.Idexplabcand);
                string apiResponse = await response.Content.ReadAsStringAsync();
                var customerByID = JsonConvert.DeserializeObject<Explabcand>(apiResponse);

                //Se realizar la actualización del customer

                var json = JsonConvert.SerializeObject(explabcand);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using var responsePut = await httpClient
                    .PutAsync("http://localhost:41565/api/Explabcand/PutExplabcand/", data);

                string apiResponsePut = await responsePut.Content.ReadAsStringAsync();
                var customerResponse = JsonConvert.DeserializeObject<Explabcand>(apiResponsePut);
                if (customerResponse == null)
                    exito = false;


            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        public static async Task<bool> Eliminar(int id)
        {
            bool exito = true;

            try
            {

                using var httpClient = new HttpClient();



                using var responseDelete = await httpClient
                  .DeleteAsync("http://localhost:41565/api/Explabcand/DeleteExplabcand/" + id);
                string apiResponseDelete = await responseDelete.Content.ReadAsStringAsync();
                if ((int)responseDelete.StatusCode == 404)
                    exito = false;


            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }
    }








}

