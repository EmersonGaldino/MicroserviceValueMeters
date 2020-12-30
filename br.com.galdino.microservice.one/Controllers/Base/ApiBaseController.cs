using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace br.com.galdino.microservice.one.api.Controllers.Base
{
    public abstract class ApiBaseController : ControllerBase
    {
        protected async Task<IActionResult> AutoResult<T>(Func<Task<T>> func)
        {
            try
            {
                return Ok(await func());
            }
            catch (ValidationException)
            {
                var erroBuilder = new StringBuilder();

                return BadRequest(erroBuilder.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
