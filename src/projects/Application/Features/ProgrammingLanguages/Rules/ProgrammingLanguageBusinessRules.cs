using Application.Services.Repositories;
using Core.CrossCuttingConcers.Exceptions;

namespace Application.Features.ProgrammingLanguages.Rules;
public class ProgrammingLanguageBusinessRules
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

    public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
    }

    public async Task ProgramingLanguageNameCanNotBeDuplicated(string name)
    {
        var programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Name == name);
        if (programmingLanguage is not null) throw new BusinessException("Programming language exists");
    }
}
