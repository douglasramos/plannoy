using MediatR;

namespace Plannoy.Application.CommonInterfaces
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, bool> where TCommand : class, ICommand
    {
    }
}