using AutoMapper;
using MediatR;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using Plannoy.Domain.Establishment;
using Plannoy.Domain.RepositoryInterfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Plannoy.Application.CreateEstablishment
{
    public class CreateEstablishmentCommandHandler : ICommandHandler<CreateEstablishmentCommand>
    {
        private readonly IEstablishmentRepository _establishments;
        private readonly ICreateEstablishmentOutputPort _outputPort;
        private readonly IMapper _mapper;

        public CreateEstablishmentCommandHandler(IEstablishmentRepository establishments, ICreateEstablishmentOutputPort outputPort,
            IMapper mapper)
        {
            _establishments = establishments;
            _outputPort = outputPort;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateEstablishmentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var establishment = _mapper.Map<Establishment>(request);

                var establishmentAdded = await _establishments.AddAsync(establishment);

                _outputPort.Success(establishmentAdded);
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
