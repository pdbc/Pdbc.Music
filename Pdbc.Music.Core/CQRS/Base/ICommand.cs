using MediatR;

namespace Pdbc.Music.Core.CQRS
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<out T> : IRequest<T>
    {
    }
}