using Application.Services.Repositories;
namespace Application.Features.Technologies.Commands.UpdateTechnology;

public class UpdateTechnologyCommand : IRequest<UpdateTechnologyCommandResponseDto>
{
    public UpdateTechnologyCommandRequestDto Technology { get; set; }


    public class UpdateTechnologyCommandHandler : IRequestHandler<UpdateTechnologyCommand, UpdateTechnologyCommandResponseDto>
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly TechnologyBusinessRules _rules;
        private readonly IMapper _mapper;

        public UpdateTechnologyCommandHandler(ITechnologyRepository technologyRepository, TechnologyBusinessRules rules, IMapper mapper)
        {
            _technologyRepository = technologyRepository;
            _rules = rules;
            _mapper = mapper;
        }

        public async Task<UpdateTechnologyCommandResponseDto> Handle(UpdateTechnologyCommand request, CancellationToken cancellationToken)
        {
            Technology? technology = await _technologyRepository.GetAsync(t => t.Id == request.Technology.Id);
           
            _rules.NullCheck(technology);
            await _rules.TechnologyNameCanNotBeDuplicated(request.Technology.Name);

            Technology mappedTechnology = _mapper.Map(request.Technology, technology);
            await _technologyRepository.UpdateAsync(mappedTechnology);

            return _mapper.Map<UpdateTechnologyCommandResponseDto>(mappedTechnology);
        }
    }
}
