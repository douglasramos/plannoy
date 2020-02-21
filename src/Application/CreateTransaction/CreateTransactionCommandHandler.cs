using AutoMapper;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plannoy.Application.CreateTransaction
{
    public class CreateTransactionCommandHandler : ICommandHandler<CreateTransactionCommand>
    {

        private readonly ITransactionRepository _transactions;

        private readonly IEstablishmentRepository _establishments;

        private readonly ICreateTransactionOutputPort _outputPort;

        private readonly IMapper _mapper;

        public CreateTransactionCommandHandler(ITransactionRepository transactions, IEstablishmentRepository establishments,
            ICreateTransactionOutputPort outputPort,
            IMapper mapper)
        {
            _transactions = transactions;
            _establishments = establishments;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var establishment = await _establishments.GetByNameAsync(request.Establishment);

                var transactions = new Transaction(
                    request.ReferenceDate,
                    establishment,
                    request.PaymentMethod,
                    request.Money);

                var id = await _transactions.AddAsync(transactions);

                _outputPort.Success(new CreateTransactionResponse { Id = id });
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
