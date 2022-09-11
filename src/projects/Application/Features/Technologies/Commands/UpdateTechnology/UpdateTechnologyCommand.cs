using Application.Services.Repositories;
namespace Application.Features.Technologies.Commands.UpdateTechnology;

public class UpdateTechnologyCommand : IRequest<UpdateTechnologyCommandResponseDto>
{
    public UpdateTechnologyCommandRequestDto Technology { get; set; }
}

public class UpdateTechnologyCommandHandler : IRequestHandler<UpdateTechnologyCommand, UpdateTechnologyCommandResponseDto>
{
    private readonly ITechnologyRepository _technologyRepository;
    private readonly TechnologyBusinessRules _businessRules;
    private readonly IMapper _mapper;

    public UpdateTechnologyCommandHandler(ITechnologyRepository technologyRepository, TechnologyBusinessRules businessRules, IMapper mapper)
    {
        _technologyRepository = technologyRepository;
        _businessRules = businessRules;
        _mapper = mapper;
    }

    public async Task<UpdateTechnologyCommandResponseDto> Handle(UpdateTechnologyCommand request, CancellationToken cancellationToken)
    {
        Technology? technology = await _technologyRepository.GetAsync(t => t.Id == request.Technology.Id);

        _businessRules.NullCheck(technology);
        await _businessRules.TechnologyNameCanNotBeDuplicated(request.Technology.Name);

        technology = _mapper.Map(request.Technology, technology);
        await _technologyRepository.UpdateAsync(technology);

        return _mapper.Map<UpdateTechnologyCommandResponseDto>(technology);
    }
}
