using Application.Services.Repositories;
namespace Application.Features.Technologies.Commands.DeleteTechnology;

public class DeleteTechnologyCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class DeleteTechnologyCommandHandler : IRequestHandler<DeleteTechnologyCommand, bool>
{
    private readonly ITechnologyRepository _technologyRepository;
    private readonly TechnologyBusinessRules _businessRules;

    public DeleteTechnologyCommandHandler(ITechnologyRepository technologyRepository, TechnologyBusinessRules businessRules)
    {
        _technologyRepository = technologyRepository;
        _businessRules = businessRules;
    }

    public async Task<bool> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
    {
        Technology? technology = await _technologyRepository.GetAsync(t => t.Id == request.Id);

        _businessRules.NullCheck(technology);
        await _technologyRepository.DeleteAsync(technology);

        return true;
    }
}