using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests.Errors;
using Pdbc.Music.Data;
using Pdbc.Music.UnitTests.Base;

namespace Pdbc.Music.Integration.Tests.Errors.List
{
    public class ListErrorMessagesTest : ErrorMessageServiceTest<ListErrorMessagesResponse>
    {
        public ListErrorMessagesTest(IErrorMessagesService service, MusicDbContext dbContext) 
            : base(service, dbContext)
        {
        }

        private ListErrorMessagesRequest _request;

        public override void Setup()
        {
            _request = new ListErrorMessagesRequest()
            {
                Language = "NL"
            };
        }

        public override void Cleanup()
        {
        }

        public override ListErrorMessagesResponse PerformAction()
        {
            return Service.ListErrorMessages(_request)
                        .GetAwaiter()
                        .GetResult();
        }

        public override void VerifyResponse(ListErrorMessagesResponse response)
        {
            response.Resources.ShouldNotBeNull();
            response.Resources.Count.ShouldBeGreaterThan(0);
        }
    }
}
