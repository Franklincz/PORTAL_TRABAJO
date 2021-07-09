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
    public class EmpresaRepository
    {

        public static async Task<IEnumerable<Empresa>> ListadoAsincrono()
        {

            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync("http://localhost:41565/api/Empresa/GetEmpresas");
            string apiResponse = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<IEnumerable<Empresa>>(apiResponse);


            return customers;
        }

        public static async Task<Empresa> Obtener(int id)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync("http://localhost:41565/api/Empresa/GetEmpresaById/" + id);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<Empresa>(apiResponse);

            return customers;
        }


        public static async Task<bool> Insertar(Empresa empresa,Admiempresa admiempresa)
        {
            //bool exito = true;

            //var json = JsonConvert.SerializeObject(empresa);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //using var httpClient = new HttpClient();
            //using var response = await httpClient
            //    .PostAsync("http://localhost:41565/api/Empresa/RegistrarEmpresa", data);
            //string apiResponse = await response.Content.ReadAsStringAsync();
            //var customers = JsonConvert.DeserializeObject<Empresa>(apiResponse);
            //if (customers == null)
            //    exito = false;
           
            //return exito;




            bool exito = true;

            try
            {


                using var data = new DBPortaldeEmpleoContext();
                data.Empresa.Add(empresa);
               
                await data.SaveChangesAsync();


                
            }
            catch (Exception)
            {
                exito = false;
            }
            var id = empresa.Id;

            using var data2 = new DBPortaldeEmpleoContext();

            admiempresa.EmpresaId =id;
            data2.Admiempresa.Add(admiempresa);

            await data2.SaveChangesAsync();
            admiempresa.SalAdmiEmpresa = "";
            return exito;


        }







      































        public static async Task<bool> Actualizar(Empresa empresa)
        {
            bool exito = true;

            try
            {
                //Se obtiene el customer por ID 
                using var httpClient = new HttpClient();
                using var response = await httpClient
                    .GetAsync("http://localhost:41565/api/Empresa/GetEmpresaById/" + empresa.Id);
                string apiResponse = await response.Content.ReadAsStringAsync();
                var customerByID = JsonConvert.DeserializeObject<Empresa>(apiResponse);

                //Se realizar la actualización del customer

                var json = JsonConvert.SerializeObject(empresa);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using var responsePut = await httpClient
                    .PutAsync("http://localhost:41565/api/Empresa/ActualizarEmpresa", data);

                string apiResponsePut = await responsePut.Content.ReadAsStringAsync();
                var customerResponse = JsonConvert.DeserializeObject<Empresa>(apiResponsePut);
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
                ////Obtener el customer by ID
                using var httpClient = new HttpClient();


                using var responseDelete = await httpClient
                  .DeleteAsync("http://localhost:41565/api/Empresa/EliminarEmpresa/" + id);
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
