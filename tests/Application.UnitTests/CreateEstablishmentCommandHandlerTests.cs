using System;
using Xunit;
using NSubstitute;
using Plannoy.Domain;
using Plannoy.Application.CreateEstablishment;

namespace Plannoy.Application.UnitTests
{
    public class CreateEstablishmentCommandHandlerTests
    {
        public class Handle
        {

            [Fact]
            public void ValidCommand_SuccessfulEstablishmentCreation()
            {
                // arrange
                var establishmentRepo = Substitute.For<IRepository<Establishment>>();
                var outputPort = Substitute.For<IOutputPortError>();

                // act
                var createEstablishmentUseCase = new CreateEstablishmentCommandHandler(establishmentRepo, outputPort);



            }

        }
    }
}
