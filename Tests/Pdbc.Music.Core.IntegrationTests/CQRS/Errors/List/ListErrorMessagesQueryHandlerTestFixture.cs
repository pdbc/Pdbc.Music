using System;
using System.Threading;
using NUnit.Framework;
using Pdbc.Music.Core.CQRS.Errors.List;
using Microsoft.Extensions.DependencyInjection;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Integration.Tests;
using Pdbc.Music.Integration.Tests.Errors.Get;
using Pdbc.Music.Integration.Tests.Errors.List;
using Pdbc.Music.UnitTests.Base;


namespace Pdbc.Music.Core.IntegrationTests.CQRS.Errors.List
{
    public class ListErrorMessagesQueryHandlerTestFixture : MusicIntegrationCqrsRequestTestFixture
    {
        protected override IIntegrationTest CreateIntegrationTest()
        {
            var service = ServiceProvider.GetService<IErrorMessagesService>();
            return new ListErrorMessagesTest(service, base.Context);
        }
    }
}

//[TestCase("NL")]
//        [TestCase("FR")]
//        public void Verify_errors_returned(String language)
//        {
//            var service = ServiceProvider.GetService<IErrorMessagesService>();
//            var response = service.ListErrorMessages(new ListErrorMessagesRequest()
//            {
//                Language = language
//            })
//                .GetAwaiter()
//                .GetResult();
            
//            response.Resources.Count.ShouldBeGreaterThan(0);
//        }
//    }
//}
