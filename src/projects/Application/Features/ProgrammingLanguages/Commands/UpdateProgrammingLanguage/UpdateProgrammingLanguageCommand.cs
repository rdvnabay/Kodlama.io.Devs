using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;
public class UpdateProgrammingLanguageCommand : IRequest<UpdateProgrammingLanguageCommandDto>
{
    public UpdateProgrammingLanguageCommandDto ProgrammingLanguage { get; set; }


    public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand, UpdateProgrammingLanguageCommandDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<UpdateProgrammingLanguageCommandDto> Handle(UpdateProgrammingLanguageCommand request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.ProgrammingLanguage.Id);
            var mappedProgrammingLanguage = _mapper.Map(request.ProgrammingLanguage, programmingLanguage);
            await _programmingLanguageRepository.UpdateAsync(mappedProgrammingLanguage);

            return _mapper.Map<UpdateProgrammingLanguageCommandDto>(mappedProgrammingLanguage);
        }
    }
}
