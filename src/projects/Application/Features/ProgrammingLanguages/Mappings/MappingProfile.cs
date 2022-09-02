using Application.Features.ProgrammingLanguages.Dtos;
using Application.Features.ProgrammingLanguages.Models;
using Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguageById;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //GetProgrammingLanguages
        CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguagesModel>();
        CreateMap<ProgrammingLanguage, ProgrammingLanguagesDto>();

        //GetProgrammingLanguageById
        CreateMap<ProgrammingLanguage, GetProgrammingLanguageByIdDto>();
    }
}
