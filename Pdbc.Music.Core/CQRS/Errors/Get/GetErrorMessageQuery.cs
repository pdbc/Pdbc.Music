using MediatR;

namespace Pdbc.Music.Core.CQRS.Errors.Get
{
    public class GetErrorMessageQuery : IRequest<GetErrorMessageQueryResult>
    {
        public string Language { get; set; }

        public string Key { get; set; }
    }
}