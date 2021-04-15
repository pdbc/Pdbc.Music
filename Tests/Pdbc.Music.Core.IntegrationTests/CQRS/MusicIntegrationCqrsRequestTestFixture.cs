using System;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Pdbc.Music.Integration.Tests;

namespace Pdbc.Music.Core.IntegrationTests.CQRS
{
    public abstract class MusicIntegrationCqrsRequestTestFixture : MusicIntegrationTestFixture
    {
        protected IIntegrationTest IntegrationTest;

        protected override void Establish_context()
        {
            base.Establish_context();

            IntegrationTest = CreateIntegrationTest();
            var strategy = Context.Database.CreateExecutionStrategy();
            strategy.Execute(() =>
            {
                using var transaction = Context.Database.BeginTransaction();

                IntegrationTest.Setup();
                Context.SaveChanges();
                transaction.Commit();
            });

            //using (var transaction = new TransactionScope())
            //{
            //    IntegrationTest.Setup();
            //    transaction.Complete();
            //}
            
            // Set the name in the setup
            TestExecutionContext.CurrentContext.CurrentTest.Name = $"{IntegrationTest.GetType().Name}.Execute_Test";
        }

        protected abstract IIntegrationTest CreateIntegrationTest();
        
        [Test]
        public void Execute_Test()
        {
            TestExecutionContext.CurrentContext.OutWriter.WriteLine($"{DateTime.Now:hh:mm:ss.fffffff}: Running {TestExecutionContext.CurrentContext.CurrentTest.FullName}");
            IntegrationTest.Run();
            TestExecutionContext.CurrentContext.OutWriter.WriteLine($"{DateTime.Now:hh:mm:ss.fffffff}: Finished {TestExecutionContext.CurrentContext.CurrentTest.FullName}");
        }

        protected override void CleanupActionsAfterTest()
        {
            IntegrationTest.Cleanup();
        }
    }
}