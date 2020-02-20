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

        private readonly IEstablishmentRepository _establishments;

        private readonly ICreateTransactionOutputPort _outputPort;

        private readonly IMapper _mapper;

        public CreateTransactionCommandHandler(IEstablishmentRepository establishments, ICreateTransactionOutputPort outputPort,
            IMapper mapper)
        {
            _establishments = establishments;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var establishment = _mapper.Map<Establishment>(request);

                var id = await _establishments.AddAsync(establishment);

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
