using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Core.Extensions;

namespace Pdbc.Music.Core.CQRS.ErrorMessages.Get
{
    public class GetErrorMessageQueryHandler : IRequestHandler<GetErrorMessageQuery, GetErrorMessageViewModel>
    {
        public Task<GetErrorMessageViewModel> Handle(GetErrorMessageQuery request, CancellationToken cancellationToken)
        {
            var result = new GetErrorMessageViewModel()
            {
                Message = request.Language.GetErrorResource(request.Key)
            };

            return Task.FromResult(result);
        }
    }
}