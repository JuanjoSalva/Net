using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjectServicesToControllers.Services;

namespace InjectServicesToControllers
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Ejemplo con ID (injección de dependencias con servicios básicos
            //services.AddSingleton<IMyService, MyServices>();
            //Ejemplo con servicios y lifeTime
            //services.AddSingleton<IRandomService, RandomService>();
            //services.AddSingleton<IRandomWrapper, RandomWrapper>();
            //services.AddScoped<IRandomService, RandomService>();
            //services.AddScoped<IRandomWrapper, RandomWrapper>();
            services.AddTransient<IRandomService, RandomService>();
            services.AddTransient<IRandomWrapper, RandomWrapper>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Página no encontrada");
            });
        }
    }
}
