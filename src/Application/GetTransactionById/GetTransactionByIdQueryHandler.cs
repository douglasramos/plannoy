using AutoMapper;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plannoy.Application.GetTransactionById
{
    public class GetTransactionByIdQueryHandler : IQueryHandler<GetTransactionByIdQuery>
    {

        private readonly ITransactionRepository _transactions;

        private readonly IGetTransactionByIdOutputPort _outputPort;

        private readonly IMapper _mapper;

        public GetTransactionByIdQueryHandler(ITransactionRepository transactions,
            IGetTransactionByIdOutputPort outputPort,
            IMapper mapper)
        {
            _transactions = transactions;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task<bool> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var transaction = await _transactions.GetByIdAsync(request.Id);

                _outputPort.Success(transaction);
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
