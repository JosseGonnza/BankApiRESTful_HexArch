using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Clients.Commands.CreateClientCommand;

public class CreateClientCommandHandler : IRequestHandler<CreateClientRequest, Unit>
{
    // Ayuda a mapear automaticamente
    private readonly IRepositoryAsync<Client> _repositoryAsync;
    private readonly IMapper _mapper;

    public CreateClientCommandHandler(IRepositoryAsync<Client> repositoryAsync, IMapper mapper)
    {
        _repositoryAsync = repositoryAsync;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(CreateClientRequest request, CancellationToken cancellationToken)
    {
        var newRecord = _mapper.Map<Client>(request);
        await _repositoryAsync.AddAsync(newRecord, cancellationToken);
        
        return Unit.Value;
    }
}