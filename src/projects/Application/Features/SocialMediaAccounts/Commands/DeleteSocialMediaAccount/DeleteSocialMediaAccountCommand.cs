using Application.Services.Repositories;
namespace Application.Features.SocialMediaAccounts.Commands.DeleteSocialMediaAccount;

public class DeleteSocialMediaAccountCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class DeleteSocialMediaAccountCommandHandler : IRequestHandler<DeleteSocialMediaAccountCommand, bool>
{
    private readonly ISocialMediaAccountRepository _socialMediaAccountRepository;
    private readonly SocialMediaAccountBusinessRules _businessRules;

    public DeleteSocialMediaAccountCommandHandler(ISocialMediaAccountRepository socialMediaAccountRepository, SocialMediaAccountBusinessRules businessRules)
    {
        _socialMediaAccountRepository = socialMediaAccountRepository;
        _businessRules = businessRules;
    }

    public async Task<bool> Handle(DeleteSocialMediaAccountCommand request, CancellationToken cancellationToken)
    {
        SocialMediaAccount? socialMediaAccount = await _socialMediaAccountRepository.GetAsync(s => s.Id == request.Id);
        _businessRules.NullCheck(socialMediaAccount);

        await _socialMediaAccountRepository.DeleteAsync(socialMediaAccount);
        return true;
    }
}
