using Application.Services.Repositories;
namespace Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;

public class DeleteProgrammingLanguageCommand : IRequest<bool>
{
    public int Id { get; set; }


    public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand, bool>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly ProgrammingLanguageBusinessRules _rules;

        public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules rules)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _rules = rules;
        }

        public async Task<bool> Handle(DeleteProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            ProgrammingLanguage? programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.Id);

            _rules.NullCheck(programmingLanguage);
            await _programmingLanguageRepository.DeleteAsync(programmingLanguage);

            return true;
        }
    }
}
