using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Core.CQRS.ErrorMessages.Get;
using Pdbc.Music.Core.CQRS.Errors.List;
using Pdbc.Music.Core.Extensions;
using Pdbc.Music.I18N;

namespace Pdbc.Music.Core.CQRS.Errors.Get
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