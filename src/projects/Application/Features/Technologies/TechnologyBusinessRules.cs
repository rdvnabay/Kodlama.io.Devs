using Application.Services.Repositories;
using Core.Application.BusinessRules;
namespace Application.Features.Technologies;

public class TechnologyBusinessRules : GlobalBusinessRules
{
    private readonly ITechnologyRepository _technologyRepository;

    public TechnologyBusinessRules(ITechnologyRepository technologyRepository)
    {
        _technologyRepository = technologyRepository;
    }

    public async Task TechnologyNameCanNotBeDuplicated(string name)
    {
        if (await _technologyRepository.AnyAsync(t => t.Name == name))
            throw new BusinessException("Technology name exists");
    }
}
