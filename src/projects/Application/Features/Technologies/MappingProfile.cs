using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Commands.UpdateTechnology;
namespace Application.Features.Technologies;

public partial class MappingProfile:Profile
{
    public MappingProfile()
    {
        //CreateTechnology
        CreateMap<CreateTechnologyCommandRequestDto, Technology>();
        CreateMap<Technology, CreateTechnologyCommandResponseDto>();

        //UpdateTechnology
        CreateMap<UpdateTechnologyCommandRequestDto, Technology>();
        CreateMap<Technology, UpdateTechnologyCommandResponseDto>();
    }
}
