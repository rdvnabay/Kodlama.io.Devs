using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
public class UpdateProgrammingLanguageCommand : IRequest<UpdateProgrammingLanguageCommandDto>
{
    public UpdateProgrammingLanguageCommandDto ProgrammingLanguage { get; set; }


    public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand, UpdateProgrammingLanguageCommandDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly ProgrammingLanguageBusinessRules _rules;
        private readonly IMapper _mapper;

        public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules rules, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _rules = rules;
            _mapper = mapper;
        }

        public async Task<UpdateProgrammingLanguageCommandDto> Handle(UpdateProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.ProgrammingLanguage.Id);

            if (programmingLanguage.Name != request.ProgrammingLanguage.Name)
                await _rules.ProgramingLanguageNameCanNotBeDuplicated(request.ProgrammingLanguage.Name);

            var mappedProgrammingLanguage = _mapper.Map(request.ProgrammingLanguage, programmingLanguage);
            await _programmingLanguageRepository.UpdateAsync(mappedProgrammingLanguage);

            return _mapper.Map<UpdateProgrammingLanguageCommandDto>(mappedProgrammingLanguage);
        }
    }
}
