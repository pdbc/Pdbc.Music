using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Data;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Integration.Tests.Errors.Get
{
    public class GetErrorMessageTest : ErrorMessageServiceTest<GetErrorMessageResponse>
    {
        public GetErrorMessageTest(IErrorMessagesService service, MusicDbContext dbContext)
            : base(service, dbContext)
        {
        }

        private GetErrorMessageRequest _request;

        public override void Setup()
        {
            _request = new GetErrorMessageRequest()
            {
                Key = "ErrorCode_Sample",
                Language = "NL"
            };
        }

        public override void Cleanup()
        {
        }

        public override GetErrorMessageResponse PerformAction()
        {
            return Service.GetErrorMessage(_request)
                        .GetAwaiter()
                        .GetResult();
        }

        public override void VerifyResponse(GetErrorMessageResponse response)
        {
            response.Message.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
