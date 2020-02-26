using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using Plannoy.Domain.RepositoryInterfaces;
using Plannoy.Domain.Transaction;
using System;
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

        public CreateTransactionCommandHandler(ITransactionRepository transactions, IEstablishmentRepository establishments,
            ICreateTransactionOutputPort outputPort)
        {
            _transactions = transactions;
            _establishments = establishments;
            _outputPort = outputPort;
        }

        public async Task<bool> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var establishment = await _establishments.GetByNameAsync(request.Establishment);

                // Two sources -> One Destination [mapper doesn't support this natively]
                var transaction = new Transaction(
                    request.ReferenceDate,
                    establishment,
                    request.PaymentMethod,
                    request.Money);

                var transactionAdded = await _transactions.AddAsync(transaction);

                _outputPort.Success(transactionAdded);
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
