namespace Application.Features.SocialMediaAccounts.Commands.CreateSocialMediaAccount;

public class CreateSocialMediaAccountCommandValidator:AbstractValidator<CreateSocialMediaAccountCommand>
{
    public CreateSocialMediaAccountCommandValidator()
    {
        RuleFor(x=>x.SocialMediaAccount.Website).NotEmpty().NotNull();
        RuleFor(x => x.SocialMediaAccount.Link).NotEmpty().NotNull();
    }
}
