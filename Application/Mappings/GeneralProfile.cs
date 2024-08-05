using Application.Features.Clients.Commands.CreateClientCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Commands
            // Se encarga de mapear automaticamente las pripiedades de CreateClientCommand a Client 
            CreateMap<CreateClientCommand, Client>();
            #endregion
        }
    }
}
