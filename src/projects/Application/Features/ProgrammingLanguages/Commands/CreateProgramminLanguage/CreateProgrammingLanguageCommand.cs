using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.CreateProgramminLanguage;
public class CreateProgrammingLanguageCommand : IRequest<CreateProgrammingLanguageCommandResponseDto>
{
    public CreateProgrammingLanguageCommandRequestDto ProgrammingLanguage { get; set; }

    public class CreateProgramminLanguageCommandHandler : IRequestHandler<CreateProgrammingLanguageCommand, CreateProgrammingLanguageCommandResponseDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public CreateProgramminLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<CreateProgrammingLanguageCommandResponseDto> Handle(CreateProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            var programmingLanguage = _mapper.Map<ProgrammingLanguage>(request.ProgrammingLanguage);
            await _programmingLanguageRepository.AddAsync(programmingLanguage);

            return _mapper.Map<CreateProgrammingLanguageCommandResponseDto>(programmingLanguage);
        }
    }
}
