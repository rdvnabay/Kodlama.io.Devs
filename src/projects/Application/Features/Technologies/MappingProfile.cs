using Application.Features.Technologies.Commands.CreateTechnology;

namespace Application.Features.Technologies;
public partial class MappingProfile:Profile
{
    public MappingProfile()
    {
        //CreateTechnology
        CreateMap<CreateTechnologyCommandRequestDto, Technology>();
        CreateMap<Technology, CreateTechnologyCommandResponseDto>();
    }
}
