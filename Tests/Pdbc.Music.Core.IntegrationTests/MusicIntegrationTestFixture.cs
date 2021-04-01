using System;
using System.Data.Common;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Pdbc.Music.Data;
using Pdbc.Music.UnitTest.Helpers.Base;

namespace Pdbc.Music.Core.IntegrationTests
{
    public class MusicIntegrationTestFixture : BaseSpecification
    {
        protected MusicDbContext Context;

        protected IConfiguration Configuration { get; private set; }

        protected virtual bool ShouldLoadTestObjects { get; set; } = true;

        protected ServiceProvider ServiceProvider;

        //protected TestCaseService TestCaseService { get; private set; }
        protected DateTime TestStartedDatTime;

        protected override void Establish_context()
        {
            LoadConfiguration();

            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            
            try
            {
                var dir = TestContext.CurrentContext.TestDirectory;
                Directory.SetCurrentDirectory(dir);

                SetupServiceProvider();
                
                //Context = ServiceProvider.GetService<MusicDbContext>();

                TestStartedDatTime = DateTime.Now;
                base.Establish_context();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void SetupServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddSingleton(Configuration);
            services.AddLogging();

            MusicIntegrationTestBootstrap.BootstrapContainer(services, Configuration);

            ServiceProvider = services.BuildServiceProvider();
        }

        private  void LoadConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.WithFunctionalityDomainConfiguration(action =>
            //{
            //    action.EnableCiaServiceAgent();
            //});

            Configuration = configurationBuilder.Build();

        }

        protected override void Dispose_context()
        {
            RunWithoutException(CleanupActionsAfterTest);
            RunWithoutException(() => Context.SaveChanges());
            RunWithoutException(() => Context?.Dispose());
        }

        private void RunWithoutException(Action action)
        {
            try
            {
                action();
            }
            catch (Exception)  {  }
        }

        protected override void Because()
        {
            //Context.SaveChanges();
            base.Because();
            //Context.SaveChanges();
        }

        protected virtual void CleanupActionsAfterTest() { }
    }
}