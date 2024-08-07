using MediatR;

namespace Application.Features.Clients.Commands.CreateClientCommand
{
    public class CreateClientRequest : IRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
