using System.Threading.Tasks;
using br.com.galdino.microservice.domain.core.Entity.Square;

namespace br.com.galdino.microservice.application.Interface
{
    public interface ISquareMeterValueAppService
    {
        Task<SquareValue> Get();
    }
}
