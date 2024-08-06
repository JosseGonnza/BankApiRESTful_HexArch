using Application.Features.Clients.Commands.CreateClientCommand;
using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClientsController : BaseApiController
    {
        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateClientCommand command)
        {
            // El controlador se encarga solo de enrutar, toda la lógica se queda en el Core
            return Ok(Mediator.Send(command));
        }
    }
}
