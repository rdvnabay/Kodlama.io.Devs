using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Commands.UpdateTechnology;
using Application.Features.Technologies.Queries.GetTechnologies;
using Core.Persistence.Paging;
namespace Application.Features.Technologies;

public partial class MappingProfile:Profile
{
    public MappingProfile()
    {
        //GetTechnologies
        CreateMap<IPaginate<Technology>, GetTechnologiesQueryModel>();
        CreateMap<Technology, GetTechnologiesQueryDto>();

        //CreateTechnology
        CreateMap<CreateTechnologyCommandRequestDto, Technology>();
        CreateMap<Technology, CreateTechnologyCommandResponseDto>();

        //UpdateTechnology
        CreateMap<UpdateTechnologyCommandRequestDto, Technology>();
        CreateMap<Technology, UpdateTechnologyCommandResponseDto>();
    }
}
