using System.Threading.Tasks;
using br.com.galdino.microservice.domain.core.Entity.Square;

namespace br.com.galdino.microservice.domain.core.Interface
{
    public interface ISquareMeterService
    {
        Task<SquareValue> Get();
    }
}
