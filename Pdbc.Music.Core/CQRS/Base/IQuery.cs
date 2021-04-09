using MediatR;

namespace Pdbc.Music.Core.CQRS
{
    public interface IQuery
    {

    }
    public interface IQuery<T> : IRequest<T>, IQuery
    {
    }
}