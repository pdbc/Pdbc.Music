using System;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Core.IntegrationTests.CQRS.Errors.Get
{
    public class GetErrorMessageQueryHandlerTestFixture : MusicIntegrationTestFixture
    {
        [TestCase("NL")]
        [TestCase("FR")]
        public void Verify_error_message_returned(String language)
        {
            var service = ServiceProvider.GetService<IErrorMessagesService>();
            var response = service.GetErrorMessage(new GetErrorMessageRequest()
            {
                Language = language,
                Key = "ErrorCode_Sample"
            })
                .GetAwaiter()
                .GetResult();
            
            response.Message.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }

        [Test]
        public void Verify_error_code_returned_when_language_not_given()
        {
            var service = ServiceProvider.GetService<IErrorMessagesService>();
            var response = service.GetErrorMessage(new GetErrorMessageRequest()
                {
                    Language = null,
                    Key = "ErrorCode_Sample"
                })
                .GetAwaiter()
                .GetResult();

            response.Message.ShouldBeNull();
            response.Notifications.HasErrors().ShouldBeTrue();
        }
    }
}
