using PORTAL_TRABAJO.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web.Repository
{
    public class DefpostuRepository
    {




  


public static async Task<bool> Insertar(Detpostuof postulacion)
{
    //    bool exito = true;

    //    var json = JsonConvert.SerializeObject(Candidato);
    //    var data = new StringContent(json, Encoding.UTF8, "application/json");

    //    using var httpClient = new HttpClient();
    //    using var response = await httpClient
    //        .PostAsync("http://localhost:62992/api/Candidato/PostCandidato", data);
    //    string apiResponse = await response.Content.ReadAsStringAsync();
    //    var candidato = JsonConvert.DeserializeObject<Candidato>(apiResponse);

    //    if (candidato == null)
    //        exito = false;


    bool exito = true;

    try
    {


        using var data = new DBPortaldeEmpleoContext();
        data.Detpostuof.Add(postulacion);
        await data.SaveChangesAsync();
       
    }
    catch (Exception)
    {
        exito = false;
    }

    return exito;



}







    }
}
