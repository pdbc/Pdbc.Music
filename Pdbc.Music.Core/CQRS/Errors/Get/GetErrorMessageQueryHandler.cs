using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Core.CQRS.Errors.List;
using Pdbc.Music.Core.Extensions;
using Pdbc.Music.I18N;

namespace Pdbc.Music.Core.CQRS.Errors.Get
{
    public class GetErrorMessageQueryHandler : IRequestHandler<GetErrorMessageQuery, GetErrorMessageQueryResult>
    {
        public Task<GetErrorMessageQueryResult> Handle(GetErrorMessageQuery request, CancellationToken cancellationToken)
        {
            var result = new GetErrorMessageQueryResult()
            {
                Message = request.Language.GetErrorResource(request.Key)
            };

            return Task.FromResult(result);
        }
    }
}