using br.com.galdino.microservice.domain.core.Entity.Square;
using br.com.galdino.microservice.domain.core.Interface;
using br.com.galdino.microservice.infra.data.Interface;
using System.Threading.Tasks;

namespace br.com.galdino.microservice.domain.core.Service
{
    public class SquareService : ISquareMeterService
    {
        private readonly ISquareRepository repository;
        public SquareService(ISquareRepository repository)
        {
            this.repository = repository;
        }

        public async Task<SquareValue> Get()
        {
            var reult = await repository.Get();

            return new SquareValue
            {
                Value = reult.Value
            };
        } 
        

    }
}
