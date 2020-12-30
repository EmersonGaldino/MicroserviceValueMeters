using br.com.galdino.microservice.infra.data.DTO.Square;
using br.com.galdino.microservice.infra.data.Interface;
using System.Threading.Tasks;

namespace br.com.galdino.microservice.infra.data.Repository
{
    public class SquareRepository : ISquareRepository
    {
        
        public async Task<SquareValueCommand> Get() => new SquareValueCommand
        {
            Value = 5214.00
        };
        
    }
}
