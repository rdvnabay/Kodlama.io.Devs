using Application.Services.Repositories;
namespace Application.Features.Technologies.Commands.CreateTechnology;

public class CreateTechnologyCommand : IRequest<CreateTechnologyCommandResponseDto>
{
    public CreateTechnologyCommandRequestDto Technology { get; set; }


    public class CreateTechnologyCommandHandler : IRequestHandler<CreateTechnologyCommand, CreateTechnologyCommandResponseDto>
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly TechnologyBusinessRules _rules;
        private readonly IMapper _mapper;

        public CreateTechnologyCommandHandler(ITechnologyRepository technologyRepository, TechnologyBusinessRules rules, IMapper mapper)
        {
            _technologyRepository = technologyRepository;
            _rules = rules;
            _mapper = mapper;
        }

        public async Task<CreateTechnologyCommandResponseDto> Handle(CreateTechnologyCommand request, CancellationToken cancellationToken)
        {
            await _rules.TechnologyNameCanNotBeDuplicated(request.Technology.Name);

            var technology = _mapper.Map<Technology>(request.Technology);
            await _technologyRepository.AddAsync(technology);

            return _mapper.Map<CreateTechnologyCommandResponseDto>(technology);
        }
    }
}
