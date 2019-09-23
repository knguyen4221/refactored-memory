using System;
using System.IO;
using System.Reflection;
using BridgePayService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XMLApiProject.Services.Services;
using XMLApiProject.Services.Services.Factories;
using XMLApiProject.Services.Services.Interfaces;

namespace XMLApiProject.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            CredentialsConfig = configuration.GetSection("Credentials");
        }

        public IConfiguration Configuration { get; }
        public IConfiguration CredentialsConfig { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "BridgePay API Facade", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddHttpClient();
            services.AddSingleton<IHasBaseRequest>(new BaseRequestFactory(Configuration));
            services.AddSingleton<IRequestHandlerService, RequestHandlerService>();
            services.AddSingleton<IRequestHandlerRepository, RequestHandlerRepository>();
            services.AddSingleton<IRequestHandler, RequestHandlerClient>();
            services.AddSingleton<IConfiguration>(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes => {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PepeGasp Api");
                c.RoutePrefix = String.Empty;
            });

        }
    }
}
