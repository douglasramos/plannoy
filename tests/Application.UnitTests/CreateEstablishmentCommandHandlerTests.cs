using System;
using Xunit;
using NSubstitute;
using Plannoy.Domain;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CommonInterfaces;
using System.Threading.Tasks;
using AutoMapper;
using Plannoy.Domain.Establishment;
using Plannoy.Domain.RepositoryInterfaces;

namespace Plannoy.Application.UnitTests
{
    public class CreateEstablishmentCommandHandlerTests
    {
        public class Handle
        {
            [Fact]
            public async Task ValidCommand_SuccessfulEstablishmentCreation()
            {
                // arrange
                long id = 3;
                var name = "Uspao";
                var sector = "Alimentos";
                var establishmentRepo = Substitute.For<IEstablishmentRepository>();
                establishmentRepo.AddAsync(Arg.Any<Establishment>()).Returns(new Establishment(name, sector) { Id = id });

                var outputPort = Substitute.For<ICreateEstablishmentOutputPort>();
                var command = new CreateEstablishmentCommand(name, sector);

                var mapper = Substitute.For<IMapper>();
                mapper.Map<Establishment>(command).Returns(new Establishment(name: name, sector: sector));


                // act
                var createEstablishmentUseCase = new CreateEstablishmentCommandHandler(establishmentRepo, outputPort, mapper);
                var success = await createEstablishmentUseCase.Handle(command, new System.Threading.CancellationToken());

                // assert
                Assert.True(success);
                outputPort.Received().Success(Arg.Is<Establishment>(i => i.Id == id));
            }
        }
    }
}
