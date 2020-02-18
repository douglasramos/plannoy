using MediatR;

namespace Plannoy.Application.CreateEstablishment
{
    public interface ICommandHandler: IRequestHandler<ICommand, bool>
    {
    }
}