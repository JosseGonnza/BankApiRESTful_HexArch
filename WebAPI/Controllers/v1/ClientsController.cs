using Application.Features.Clients.Commands.CreateClientCommand;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion(Versions.V1)]
    public class ClientsController : BaseApiController
    {
        private readonly IMediator mediator;

        public ClientsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateClientRequest request, CancellationToken cancellationToken)
        {
            // El controlador se encarga solo de enrutar, toda la lógica se queda en el Core
            await mediator.Send(request, cancellationToken).ConfigureAwait(false);
            return Ok();
        }
    }
}
