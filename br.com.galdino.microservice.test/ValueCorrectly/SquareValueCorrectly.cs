using System;
using br.com.galdino.microservice.domain.core.Interface;
using br.com.galdino.microservice.domain.core.Service;
using br.com.galdino.microservice.infra.data.Interface;
using Moq;
using System.Threading.Tasks;
using br.com.galdino.microservice.domain.core.Entity.Square;
using br.com.galdino.microservice.infra.data.DTO.Square;
using br.com.galdino.microservice.infra.data.Repository;
using Xunit;

namespace br.com.galdino.microservice.test.ValueCorrectly
{
    public class SquareValueCorrectly
    {
        private readonly Mock<ISquareMeterService> mokcServiceSquare = new Mock<ISquareMeterService>();
        private readonly Mock<ISquareRepository> mockSquareRepository = new Mock<ISquareRepository>();

        private SquareService GetSquareValueService() => new SquareService(mockSquareRepository.Object);

        private SquareRepository GetSquareValueRepository() => new SquareRepository();



        [Theory]
        [InlineData(5214.00)]
        public async Task SquareValueGet(double valueMeter)
        {
            mokcServiceSquare
                .Setup(c => c.Get()).ReturnsAsync(It.IsAny<SquareValue>());

            mockSquareRepository
                .Setup(x => x.Get()).ReturnsAsync(It.IsAny<SquareValueCommand>());

            var repo = GetSquareValueRepository();
            var response = await repo.Get();

            Assert.Equal(valueMeter, response.Value);

        }
    }
}
