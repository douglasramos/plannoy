using MediatR;

namespace Plannoy.Application.CreateEstablishment
{
    public interface ICommand: IRequest<bool>
    {
    }
}