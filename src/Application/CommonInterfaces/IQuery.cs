using MediatR;

namespace Plannoy.Application.CommonInterfaces
{
    public interface IQuery : IRequest<bool>
    {
    }
}