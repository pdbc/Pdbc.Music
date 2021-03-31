using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Pdbc.Music.Api.Common.Extensions;

namespace Pdbc.Music.Api.Backend
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(options =>
                {
                    options.RegisterProducesTypes();
                    options.Filters.Add(new AuthorizeFilter());
                    options.ReturnHttpNotAcceptable = true;
                    options.SetOutputFormatters();
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen();

            services.AddControllers();
        }

        //private static void SetOutputFormatters(MvcOptions options)
        //{
        //    options.OutputFormatters.Add(new XmlSerializerOutputFormatter());

        //    var jsonOutputFormatter = options.OutputFormatters
        //        .OfType<Microsoft.AspNetCore.Mvc.Formatters.Json.JsonOutputFormatter>().FirstOrDefault();

        //    if (jsonOutputFormatter != null)
        //    {
        //        // remove text/json as it isn't the approved media type
        //        // for working with JSON at API level
        //        if (jsonOutputFormatter.SupportedMediaTypes.Contains("text/json"))
        //        {
        //            jsonOutputFormatter.SupportedMediaTypes.Remove("text/json");
        //        }
        //    }
        //}

        private static void NewMethod(MvcOptions setupAction)
        {
            setupAction.Filters.Add(
                new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
            setupAction.Filters.Add(
                new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));
            setupAction.Filters.Add(
                new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
            setupAction.Filters.Add(
                new ProducesDefaultResponseTypeAttribute());
            setupAction.Filters.Add(
                new ProducesResponseTypeAttribute(StatusCodes.Status401Unauthorized));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();


            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
