using Application.Services.Repositories;
namespace Application.Features.Technologies;

public class TechnologyBusinessRules
{
    private readonly ITechnologyRepository _technologyRepository;

    public TechnologyBusinessRules(ITechnologyRepository technologyRepository)
    {
        _technologyRepository = technologyRepository;
    }

    public async Task TechnologyNameCanNotBeDuplicated(string name)
    {
        var recordExists = await _technologyRepository.AnyAsync(t => t.Name == name);
        if (recordExists) throw new BusinessException("Technology name exists");
    }

    public void NullCheck(Technology technology) => ArgumentNullException.ThrowIfNull(technology);
}
