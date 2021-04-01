using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pdbc.Music.Core.CQRS.Errors.List
{
    public class ListErrorMessagesQueryHandler : IRequestHandler<ListErrorMessagesQuery, ListErrorMessagesQueryResult>
    {
        public Task<ListErrorMessagesQueryResult> Handle(ListErrorMessagesQuery request, CancellationToken cancellationToken)
        {
            var result = new ListErrorMessagesQueryResult();
            return Task.FromResult(result);
        }
    }
}