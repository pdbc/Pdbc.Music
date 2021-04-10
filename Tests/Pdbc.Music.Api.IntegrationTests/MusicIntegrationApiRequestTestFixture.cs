using System;

using NUnit.Framework;
using NUnit.Framework.Internal;
using Pdbc.Music.Core.IntegrationTests.CQRS;
using Pdbc.Music.Integration.Tests;
using Microsoft.EntityFrameworkCore;
using Pdbc.Music.Core.IntegrationTests;

namespace Pdbc.Music.Api.IntegrationTests
{
    /// <inheritdoc />
    public abstract class MusicIntegrationApiRequestTestFixture : MusicIntegrationTestFixture
    {
        protected IIntegrationTest IntegrationTest;

        protected abstract IIntegrationTest CreateIntegrationTest();

        [Test]
        public void Execute_Test()
        {
            TestExecutionContext.CurrentContext.OutWriter.WriteLine($"{DateTime.Now:hh:mm:ss.fffffff}: Running {TestExecutionContext.CurrentContext.CurrentTest.FullName}");

            IntegrationTest = CreateIntegrationTest();
            EditApiTest();

            var strategy = Context.Database.CreateExecutionStrategy();
            strategy.Execute(() =>
            {
                using var transaction = Context.Database.BeginTransaction();

                IntegrationTest.Setup();
                Context.SaveChanges();
                transaction.Commit();
            });

            IntegrationTest.Run();
            IntegrationTest.Cleanup();

            // Save changes after cleanup
            Context.SaveChanges();

            TestExecutionContext.CurrentContext.OutWriter.WriteLine($"{DateTime.Now:hh:mm:ss.fffffff}: Finished {TestExecutionContext.CurrentContext.CurrentTest.FullName}");
        }

        protected virtual void EditApiTest()
        {

        }

        protected override void CleanupActionsAfterTest()
        {
            if (IntegrationTest != null)
            {
                try
                {
                    IntegrationTest.Cleanup();
                    Context.SaveChanges();
                }
                catch (Exception)
                {
                    //Ignore fails because if the setup fails, this might as well fail.
                }
            }
        }

    }

}
