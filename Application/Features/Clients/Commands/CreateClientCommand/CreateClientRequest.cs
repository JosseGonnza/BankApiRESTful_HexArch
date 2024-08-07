using MediatR;

namespace Application.Features.Clients.Commands.CreateClientCommand
{
    public class CreateClientRequest : IRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimineto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
