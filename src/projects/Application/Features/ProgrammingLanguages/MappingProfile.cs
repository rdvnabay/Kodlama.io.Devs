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
        CreateMap<IPaginate<ProgrammingLanguage>, GetProgrammingLanguagesQueryModel>();
        CreateMap<ProgrammingLanguage, GetProgrammingLanguagesQueryDto>();

        //GetProgrammingLanguageById
        CreateMap<ProgrammingLanguage, GetProgrammingLanguageByIdQueryDto>();

        //CreateProgrammingLanguage
        CreateMap<CreateProgrammingLanguageCommandRequestDto, ProgrammingLanguage>();
        CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommandResponseDto>();

        //UpdateProgrammingLanguage
        CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommandDto>().ReverseMap();
    }
}
