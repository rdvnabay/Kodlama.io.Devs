using Application.Features.SocialMediaAccounts.Commands.CreateSocialMediaAccount;
using Application.Features.SocialMediaAccounts.Commands.UpdateSocialMediaAccount;
namespace Application.Features.SocialMediaAccounts;

public partial class MappingProfile : Profile
{
    public MappingProfile()
    {
        //CreateSocialMediaAccount
        CreateMap<CreateSocialMediaAccountCommandRequestDto, SocialMediaAccount>();
        CreateMap<SocialMediaAccount, CreateSocialMediaAccountCommandResponseDto>();

        //UpdateSocialMediaAccount
        CreateMap<UpdateSocialMediaAccountCommandRequestDto, SocialMediaAccount>();
        CreateMap<SocialMediaAccount, UpdateSocialMediaAccountCommandResponseDto>();
    }
}
