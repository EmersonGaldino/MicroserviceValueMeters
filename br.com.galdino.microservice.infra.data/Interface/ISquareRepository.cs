using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using br.com.galdino.microservice.infra.data.DTO.Square;

namespace br.com.galdino.microservice.infra.data.Interface
{
    public interface ISquareRepository
    {
        
        Task<SquareValueCommand> Get();
    }
}
