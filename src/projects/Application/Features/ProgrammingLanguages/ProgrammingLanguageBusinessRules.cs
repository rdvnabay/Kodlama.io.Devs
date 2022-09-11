using Application.Services.Repositories;
using Core.Application.BusinessRules;
namespace Application.Features.ProgrammingLanguages;

public class ProgrammingLanguageBusinessRules : GlobalBusinessRules
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

    public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
    }

    public async Task ProgramingLanguageNameCanNotBeDuplicated(string name)
    {
        if (await _programmingLanguageRepository.AnyAsync(pl => pl.Name == name))
            throw new BusinessException("Programming language exists");
    }
}
