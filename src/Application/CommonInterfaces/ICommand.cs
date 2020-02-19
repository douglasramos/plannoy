using MediatR;

namespace Plannoy.Application.CommonInterfaces
{
    public interface ICommand : IRequest<bool>
    {
    }
}