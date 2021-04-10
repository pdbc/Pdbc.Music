using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Data;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Integration.Tests.Errors.Get
{
    public class GetErrorMessageWithoutLanguageTest : ErrorMessageServiceTest<GetErrorMessageResponse>
    {
        public GetErrorMessageWithoutLanguageTest(IErrorMessagesService service, MusicDbContext dbContext) 
            : base(service, dbContext)
        {
        }

        private GetErrorMessageRequest _request;

        public override void Setup()
        {
            _request = new GetErrorMessageRequest()
            {
                Key = "ErrorCode_Sample",
                Language = ""
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
            response.Message.ShouldBeNull();
            response.Message.ShouldHaveCount(1);
        }
    }
}
