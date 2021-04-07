using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Pdbc.Music.Core.Extensions;

namespace Pdbc.Music.Core.CQRS.Errors.List
{
    public class ListErrorMessagesQueryHandler : IRequestHandler<ListErrorMessagesQuery, ListErrorMessagesQueryResult>
    {
        public Task<ListErrorMessagesQueryResult> Handle(ListErrorMessagesQuery request, CancellationToken cancellationToken)
        {
            var result = new ListErrorMessagesQueryResult()
            {
                Resources = request.Language.GetErrorResources()
            };

            return Task.FromResult(result);
        }
    }
}