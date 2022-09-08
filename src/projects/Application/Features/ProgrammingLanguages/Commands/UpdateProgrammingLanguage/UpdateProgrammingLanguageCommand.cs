using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
public class UpdateProgrammingLanguageCommand : IRequest<UpdateProgrammingLanguageCommandDto>
{
    public UpdateProgrammingLanguageCommandDto ProgrammingLanguage { get; set; }


    public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand, UpdateProgrammingLanguageCommandDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly ProgrammingLanguageBusinessRules _rules;
        private readonly IMapper _mapper;

        public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules rules, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _rules = rules;
            _mapper = mapper;
        }

        public async Task<UpdateProgrammingLanguageCommandDto> Handle(UpdateProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            ProgrammingLanguage? programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.ProgrammingLanguage.Id);

             _rules.NullCheck(programmingLanguage);

            if (programmingLanguage.Name != request.ProgrammingLanguage.Name)
                await _rules.ProgramingLanguageNameCanNotBeDuplicated(request.ProgrammingLanguage.Name);

            ProgrammingLanguage mappedProgrammingLanguage = _mapper.Map(request.ProgrammingLanguage, programmingLanguage);
            await _programmingLanguageRepository.UpdateAsync(mappedProgrammingLanguage);

            return _mapper.Map<UpdateProgrammingLanguageCommandDto>(mappedProgrammingLanguage);
        }
    }
}
