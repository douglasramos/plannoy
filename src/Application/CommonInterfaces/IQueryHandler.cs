using MediatR;

namespace Plannoy.Application.CommonInterfaces
{
    public interface IQueryHandler<TQuery> : IRequestHandler<TQuery, bool> where TQuery : class, IQuery
    {
    }
}