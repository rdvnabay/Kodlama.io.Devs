using Application.Features.ProgrammingLanguages.Dtos;
using Application.Features.ProgrammingLanguages.Models;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguagesModel>();
        CreateMap<ProgrammingLanguage, ProgrammingLanguagesDto>();
    }
}
