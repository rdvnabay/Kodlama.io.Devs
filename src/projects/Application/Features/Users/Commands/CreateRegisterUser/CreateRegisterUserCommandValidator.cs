namespace Application.Features.Users.Commands.CreateRegisterUser;

public class CreateRegisterUserCommandValidator : AbstractValidator<CreateRegisterUserCommand>
{
    public CreateRegisterUserCommandValidator()
    {
        RuleFor(u => u.User.FirstName).NotEmpty().NotNull();
        RuleFor(u => u.User.LastName).NotEmpty().NotNull();
        RuleFor(u => u.User.Email).NotEmpty().NotNull();
        RuleFor(u => u.User.Password).MinimumLength(6);
        RuleFor(u => u.User.RePassword).MinimumLength(6);

        RuleFor(u => u.User.RePassword)
         .Equal(u => u.User.Password);
    }
}
