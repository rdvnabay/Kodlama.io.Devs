using Application.Features.ProgrammingLanguages.Commands.CreateProgramminLanguage;
using Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
using Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguageById;
using Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguages;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages;
public partial class MappingProfile : Profile
{
    public MappingProfile()
    {
        //GetProgrammingLanguages
        CreateMap<IPaginate<ProgrammingLanguage>, GetProgrammingLanguagesModel>();
        CreateMap<ProgrammingLanguage, GetProgrammingLanguagesDto>();

        //GetProgrammingLanguageById
        CreateMap<ProgrammingLanguage, GetProgrammingLanguageByIdDto>();

        //CreateProgrammingLanguage
        CreateMap<CreateProgrammingLanguageCommandRequestDto, ProgrammingLanguage>();
        CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommandResponseDto>();

        //UpdateProgrammingLanguage
        CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommandDto>().ReverseMap();
    }
}
