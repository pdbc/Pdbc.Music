using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Core.CQRS.Errors.List;
using Pdbc.Music.Core.Extensions;

namespace Pdbc.Music.Core.CQRS.ErrorMessages.List
{
    public class ListErrorMessagesQueryHandler : IRequestHandler<ListErrorMessagesQuery, ListErrorMessagesViewModel>
    {
        public Task<ListErrorMessagesViewModel> Handle(ListErrorMessagesQuery request, CancellationToken cancellationToken)
        {
            var result = new ListErrorMessagesViewModel()
            {
                Resources = request.Language.GetErrorResources()
            };

            return Task.FromResult(result);
        }
    }
}