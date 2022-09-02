namespace Application.Features.ProgrammingLanguages.Commands.CreateProgramminLanguage;

public class CreateProgramminLanguageCommandValidator : AbstractValidator<CreateProgrammingLanguageCommand>
{
    public CreateProgramminLanguageCommandValidator()
    {
        RuleFor(pl => pl.ProgrammingLanguage.Name).NotEmpty().NotNull();
    }
}
