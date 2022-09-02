using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.DeleteProgrammingLanguage;
public class DeleteProgrammingLanguageCommand : IRequest<bool>
{
    public int Id { get; set; }


    public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand, bool>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task<bool> Handle(DeleteProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.Id);
            await _programmingLanguageRepository.DeleteAsync(programmingLanguage);
            return true;
        }
    }
}
