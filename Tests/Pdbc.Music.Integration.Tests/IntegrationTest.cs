using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Data;
using System;
using System.Transactions;

namespace Pdbc.Music.Integration.Tests
{
    public abstract class IntegrationTest<TResult> : IIntegrationTest<TResult> where TResult : MusicResponse
    {
        protected DateTime TestStartDateTime { get; set; }
        protected MusicDbContext DbContext { get; set; }

        protected IntegrationTest(MusicDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual void Setup()
        {

        }

        public virtual void Run()
        {
            TestStartDateTime = DateTime.Now;
            RunDirectTest();
        }

        private void RunDirectTest()
        {
            TResult result;

            using (var transaction = new TransactionScope())
            {
                result = PerformAction();
                transaction.Complete();
            }

            ResetContext();

            VerifyResponse(result);

            // Verify immediate results
            //Assert.IsTrue(CheckActionHasSucceeded()); // Immediate
        }
        public abstract void Cleanup();

        public abstract TResult PerformAction();

        public abstract void VerifyResponse(TResult response);

        private Boolean CheckActionHasSucceeded()
        {
            CheckActionSucceeded();
            return true;
        }

        public virtual void CheckActionSucceeded()
        {

        }


        public virtual void CheckActionAfterNsbHandlingSucceeded()
        {

        }

        //public void VerifyResultWithNotification(TResult result, string errorCode)
        //{
        //    result.Notifications.ExpectErrorWithCode(errorCode);
        //}


        private void ResetContext()
        {
            //DbContext = new IdentityStoreDbContext(null, null, null, null);
            //ClearContext();
            //ReloadAllItems();
        }

    }
}