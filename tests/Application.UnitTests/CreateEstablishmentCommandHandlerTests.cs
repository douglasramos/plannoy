using System;
using Xunit;
using NSubstitute;
using Plannoy.Domain;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CommonInterfaces;
using System.Threading.Tasks;
using AutoMapper;

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
                var establishmentRepo = Substitute.For<IEstablishmentRepository>();
                establishmentRepo.AddAsync(Arg.Any<Establishment>()).Returns(id);

                var outputPort = Substitute.For<ICreateEstablishmentOutputPort>();
                var command = new CreateEstablishmentCommand { Name= "Uspao", Sector= "Alimentos"};

                var mapper = Substitute.For<IMapper>();
                mapper.Map<Establishment>(command).Returns(new Establishment(name: "Uspao", sector: "Alimentos"));


                // act
                var createEstablishmentUseCase = new CreateEstablishmentCommandHandler(establishmentRepo, outputPort, mapper);
                var success = await createEstablishmentUseCase.Handle(command, new System.Threading.CancellationToken());

                // assert
                Assert.True(success);
                outputPort.Received().Success(Arg.Is<CreateEstablishmentResponse>(i => i.Id == id));
            }
        }
    }
}
