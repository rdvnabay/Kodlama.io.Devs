﻿using Application.Features.ProgrammingLanguages.Commands.CreateProgramminLanguage;
using Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
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

        //CreateProgrammingLanguage
        CreateMap<CreateProgrammingLanguageCommandRequestDto, ProgrammingLanguage>();
        CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommandResponseDto>();

        //UpdateProgrammingLanguage
        CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommandDto>().ReverseMap();
    }
}
