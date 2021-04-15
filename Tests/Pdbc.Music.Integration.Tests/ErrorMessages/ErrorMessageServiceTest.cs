using Pdbc.Music.Api.Contracts;
using Pdbc.Music.Api.Contracts.Requests;
using Pdbc.Music.Data;

namespace Pdbc.Music.Integration.Tests.Errors
{
    public abstract class ErrorMessageServiceTest<Result> : IntegrationTest<Result> where Result : MusicResponse
    {
        protected IErrorMessagesService Service;

        protected ErrorMessageServiceTest(IErrorMessagesService service, MusicDbContext dbContext) : base(dbContext)
        {
            Service = service;
        }
    }
}
