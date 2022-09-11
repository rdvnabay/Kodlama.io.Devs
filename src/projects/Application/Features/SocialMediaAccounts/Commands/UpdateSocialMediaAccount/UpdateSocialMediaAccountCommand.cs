using Application.Services.Repositories;
namespace Application.Features.SocialMediaAccounts.Commands.UpdateSocialMediaAccount;

public class UpdateSocialMediaAccountCommand : IRequest<UpdateSocialMediaAccountCommandResponseDto>
{
    public UpdateSocialMediaAccountCommandRequestDto SocialMediaAccount { get; set; }
}


public class UpdateSocialMediaAccountCommandHandler : IRequestHandler<UpdateSocialMediaAccountCommand, UpdateSocialMediaAccountCommandResponseDto>
{
    private readonly ISocialMediaAccountRepository _socialMediaAccountRepository;
    private readonly SocialMediaAccountBusinessRules _businessRules;
    private readonly IMapper _mapper;

    public UpdateSocialMediaAccountCommandHandler(ISocialMediaAccountRepository socialMediaAccountRepository, SocialMediaAccountBusinessRules businessRules, IMapper mapper)
    {
        _socialMediaAccountRepository = socialMediaAccountRepository;
        _businessRules = businessRules;
        _mapper = mapper;
    }

    public async Task<UpdateSocialMediaAccountCommandResponseDto> Handle(UpdateSocialMediaAccountCommand request, CancellationToken cancellationToken)
    {
        SocialMediaAccount? socialMediaAccount = await _socialMediaAccountRepository.GetAsync(s => s.Id == request.SocialMediaAccount.Id);
        
        _businessRules.NullCheck(socialMediaAccount);    
        socialMediaAccount = _mapper.Map(request.SocialMediaAccount, socialMediaAccount);
        await _socialMediaAccountRepository.UpdateAsync(socialMediaAccount);

        return _mapper.Map<UpdateSocialMediaAccountCommandResponseDto>(socialMediaAccount);
    }
}
