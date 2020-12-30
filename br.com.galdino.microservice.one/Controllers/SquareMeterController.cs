using br.com.galdino.microservice.application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using br.com.galdino.microservice.one.api.Controllers.Base;
using br.com.galdino.microservice.one.api.Model.Base;
using br.com.galdino.microservice.one.api.Model.ModelView;

namespace br.com.galdino.microservice.one.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    [AllowAnonymous]
    public class SquareMeterController : ApiBaseController
    {


        [HttpGet]
        [SwaggerOperation(Summary = "Buscar valor do metro quadrado",
            Description = "Obtém o valor do metro quadrado.")]
        [SwaggerResponse(200, "Valor do metro quadrado")]
        [SwaggerResponse(400, "Não foi possível buscar o valor do metro")]
        [SwaggerResponse(500, "Erro interno, procure o suporte tecnico.")]
        public async Task<IActionResult> Get([FromServices] ISquareMeterValueAppService applicationService) 
            => await AutoResult(async () => new BaseModelView<object>
            {
                Data = await applicationService.Get(),
                Message = "Value per square meter obtained successfully."
            });
    }
}
