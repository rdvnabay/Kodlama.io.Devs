using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.CreateProgramminLanguage;
public class CreateProgrammingLanguageCommand : IRequest<CreateProgrammingLanguageCommandResponseDto>
{
    public CreateProgrammingLanguageCommandRequestDto ProgrammingLanguage { get; set; }

    public class CreateProgramminLanguageCommandHandler : IRequestHandler<CreateProgrammingLanguageCommand, CreateProgrammingLanguageCommandResponseDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly ProgrammingLanguageBusinessRules _rules;
        private readonly IMapper _mapper;

        public CreateProgramminLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules rules, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _rules = rules;
            _mapper = mapper;
        }

        public async Task<CreateProgrammingLanguageCommandResponseDto> Handle(CreateProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            await _rules.ProgramingLanguageNameCanNotBeDuplicated(request.ProgrammingLanguage.Name);

            var programmingLanguage = _mapper.Map<ProgrammingLanguage>(request.ProgrammingLanguage);
            await _programmingLanguageRepository.AddAsync(programmingLanguage);

            return _mapper.Map<CreateProgrammingLanguageCommandResponseDto>(programmingLanguage);
        }
    }
}
