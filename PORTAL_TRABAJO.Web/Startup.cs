using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PORTAL_TRABAJO.Web.Models;
using PORTAL_TRABAJO.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PORTAL_TRABAJO.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();


            //------------------------------------------------cookiePoliciyOptions
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });

            // identity para periodo de validez de la sesion
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;


            }).AddCookie(options => { options.LoginPath = "/Cuenta/LoginCandidato"; });//ruta a la cual nos envia si no hemos inciado sesion





            //inyeccion DBContext

            services.AddDbContext<DBPortaldeEmpleoContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("DEVConecction"))

             );

            //add interfaces
            services.AddScoped<IOfertaRepository, OfertaRepository>();
            services.AddScoped<IDetPostulacionRepository, DetPostuofRepository>();








        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();





            //para la autenticacion
            app.UseAuthentication();//para que se tome persistente la sesion



            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Candidato}/{action=Index}/{id?}");
            //});


        }
    }
}
