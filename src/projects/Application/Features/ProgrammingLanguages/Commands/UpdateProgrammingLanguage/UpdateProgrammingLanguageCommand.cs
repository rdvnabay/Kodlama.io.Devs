using Application.Services.Repositories;
namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;

public class UpdateProgrammingLanguageCommand : IRequest<UpdateProgrammingLanguageCommandDto>
{
    public UpdateProgrammingLanguageCommandDto ProgrammingLanguage { get; set; }
}

public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand, UpdateProgrammingLanguageCommandDto>
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
    private readonly ProgrammingLanguageBusinessRules _businessRules;
    private readonly IMapper _mapper;

    public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules businessRules, IMapper mapper)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
        _businessRules = businessRules;
        _mapper = mapper;
    }

    public async Task<UpdateProgrammingLanguageCommandDto> Handle(UpdateProgrammingLanguageCommand request, CancellationToken cancellationToken)
    {
        ProgrammingLanguage? programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.ProgrammingLanguage.Id);

        _businessRules.NullCheck(programmingLanguage);

        if (programmingLanguage.Name != request.ProgrammingLanguage.Name)
            await _businessRules.ProgramingLanguageNameCanNotBeDuplicated(request.ProgrammingLanguage.Name);

        programmingLanguage = _mapper.Map(request.ProgrammingLanguage, programmingLanguage);
        await _programmingLanguageRepository.UpdateAsync(programmingLanguage);

        return _mapper.Map<UpdateProgrammingLanguageCommandDto>(programmingLanguage);
    }
}
