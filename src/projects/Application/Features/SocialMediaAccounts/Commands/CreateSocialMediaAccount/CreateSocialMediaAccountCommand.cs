using Application.Services.Repositories;
namespace Application.Features.SocialMediaAccounts.Commands.CreateSocialMediaAccount;

public class CreateSocialMediaAccountCommand : IRequest<CreateSocialMediaAccountCommandResponseDto>
{
    public CreateSocialMediaAccountCommandRequestDto SocialMediaAccount { get; set; }
}

public class CreateSocialMediaAccountCommandHandler : IRequestHandler<CreateSocialMediaAccountCommand, CreateSocialMediaAccountCommandResponseDto>
{
    private readonly ISocialMediaAccountRepository _socialMediaAccountRepository;
    private readonly IMapper _mapper;

    public CreateSocialMediaAccountCommandHandler(ISocialMediaAccountRepository socialMediaAccountRepository, IMapper mapper)
    {
        _socialMediaAccountRepository = socialMediaAccountRepository;
        _mapper = mapper;
    }

    public async Task<CreateSocialMediaAccountCommandResponseDto> Handle(CreateSocialMediaAccountCommand request, CancellationToken cancellationToken)
    {
        var socialMediaAccount = _mapper.Map<SocialMediaAccount>(request.SocialMediaAccount);
        await _socialMediaAccountRepository.AddAsync(socialMediaAccount);

        return _mapper.Map<CreateSocialMediaAccountCommandResponseDto>(socialMediaAccount);
    }
}
