using System.Threading.Tasks;
using br.com.galdino.microservice.application.Interface;
using br.com.galdino.microservice.domain.core.Entity.Square;
using br.com.galdino.microservice.domain.core.Interface;

namespace br.com.galdino.microservice.application.Service
{
    public class SquareMeterValueAppService : ISquareMeterValueAppService
    {
        private readonly ISquareMeterService service;
        public SquareMeterValueAppService(ISquareMeterService service)
        {
            this.service = service;
        }

        public async Task<SquareValue> Get() => await service.Get();

    }
}
