using Application.Services.Repositories;
namespace Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;

public class DeleteProgrammingLanguageCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand, bool>
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
    private readonly ProgrammingLanguageBusinessRules _businessRules;

    public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules businessRules)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
        _businessRules = businessRules;
    }

    public async Task<bool> Handle(DeleteProgrammingLanguageCommand request, CancellationToken cancellationToken)
    {
        ProgrammingLanguage? programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.Id);

        _businessRules.NullCheck(programmingLanguage);
        await _programmingLanguageRepository.DeleteAsync(programmingLanguage);

        return true;
    }
}
