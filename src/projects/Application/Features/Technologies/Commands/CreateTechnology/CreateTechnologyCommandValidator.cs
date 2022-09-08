namespace Application.Features.Technologies.Commands.CreateTechnology;

public class CreateTechnologyCommandValidator : AbstractValidator<CreateTechnologyCommand>
{
    public CreateTechnologyCommandValidator()
    {
        RuleFor(t => t.Technology.Name).NotEmpty().NotNull();
        RuleFor(t => t.Technology.ProgrammingLanguageId).NotNull();
    }
}
