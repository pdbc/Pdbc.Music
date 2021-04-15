using MediatR;

namespace Pdbc.Music.Core.CQRS
{
    public interface IQuery
    {

    }
    public interface IQuery<out T> : IRequest<T>, IQuery
    {
    }
}