using AutoMapper;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using Plannoy.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plannoy.Application.GetTransactionsByFilter
{
    public class GetTransactionByFilterQueryHandler : IQueryHandler<GetTransactionsByFilterQuery>
    {

        private readonly ITransactionRepository _transactions;

        private readonly IGetTransactionsByFilterOutputPort _outputPort;

        private readonly IMapper _mapper;

        public GetTransactionByFilterQueryHandler(ITransactionRepository transactions,
            IGetTransactionsByFilterOutputPort outputPort,
            IMapper mapper)
        {
            _transactions = transactions;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task<bool> Handle(GetTransactionsByFilterQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var transactions = await _transactions.GetByFilter(request.InitialDate, request.FinalDate);

                _outputPort.Success(transactions);
                return true;
            }
            catch (Exception ex)
            {
                _outputPort.Error(ex);
                return false;
            }
        }
    }
}
