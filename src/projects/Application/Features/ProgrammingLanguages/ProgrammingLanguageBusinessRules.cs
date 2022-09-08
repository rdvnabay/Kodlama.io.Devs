using Application.Services.Repositories;
namespace Application.Features.ProgrammingLanguages;

public class ProgrammingLanguageBusinessRules
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

    public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
    }

    public async Task ProgramingLanguageNameCanNotBeDuplicated(string name)
    {
        var recordExists = await _programmingLanguageRepository.AnyAsync(pl => pl.Name == name);
        if (recordExists) throw new BusinessException("Programming language exists");
    }

    public void NullCheck(ProgrammingLanguage programmingLanguage) => ArgumentNullException.ThrowIfNull(programmingLanguage);
}
