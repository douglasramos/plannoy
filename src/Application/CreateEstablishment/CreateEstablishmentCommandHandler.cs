using MediatR;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plannoy.Application.CreateEstablishment
{
    public class CreateEstablishmentCommandHandler : ICommandHandler
    {

        private readonly IRepository<Establishment> _establishments;

        private readonly IOutputPortError _outputPort;

        public CreateEstablishmentCommandHandler(IRepository<Establishment> establishments, IOutputPortError outputPort)
        {
            _establishments = establishments;
            _outputPort = outputPort;
        }

        public Task<bool> Handle(ICommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
