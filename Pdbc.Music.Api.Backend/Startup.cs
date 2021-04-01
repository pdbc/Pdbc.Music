using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Pdbc.Music.Api.Common.Authentication;
using Pdbc.Music.Api.Common.Controllers;
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
                    options.RegisterProducesResponseTypes();
                     //options.ReturnHttpNotAcceptable = true;
                    options.SetOutputFormatters();

                    //options.Filters.Add(new AuthorizeFilter());

                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            //services.Configure<ApiBehaviorOptions>(options =>
            //{
            //    options.SetInvalidModelStateResponse();
            //});

            //services.AddVersionedApiExplorer(setupAction =>
            //{
            //    setupAction.SetVersionApiExplorer();
            //});

            //services.AddApiVersioning(a => { a.SetVersion(); });

            //services.AddAuthentication("Basic").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("Basic", null);

            var serviceProvider = services.BuildServiceProvider(); //.GetService<IApiVersionDescriptionProvider>();
            services.AddSwaggerGen(options =>
            {
                options.ConfigureSwaggerDocument("PDBC.Music API",
                    "v1",
                    "API for maintaining songs, artists & playlists");

                options.ConfigureSwaggerDocumentationAssemblies(new[]
                {
                    Assembly.GetExecutingAssembly(),
                    Assembly.GetAssembly(typeof(HealthCheckController)),
                });

                // TODO Common somewhere - Add filters to fix enums
                //options.AddEnumsWithValuesFixFilters();

                //options.ConfigureOauthFlow(swaggerApiConfiguration.IdpBaseUrl, new Dictionary<string, string>()
                //{
                //    {
                //        IdpScopes.ActionsScope, "Access to protected controllers of the FunctionalityDomain Actions Api"
                //    }
                //});


                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line

                //a.ConfigureSwaggerAuthentication();
            });

            services.AddControllers();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //, IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();


            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pdbc.Music");

                c.DefaultModelExpandDepth(2);
                c.DefaultModelRendering(Swashbuckle.AspNetCore.SwaggerUI.ModelRendering.Model);
                c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                c.EnableDeepLinking();
                c.DisplayOperationId();

                //foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
                //{
                //    c.SwaggerEndpoint($"/swagger/" +
                //                                $"PDBC.Music - {description.GroupName}/swagger.json",
                //        description.GroupName.ToUpperInvariant());
                //}
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
