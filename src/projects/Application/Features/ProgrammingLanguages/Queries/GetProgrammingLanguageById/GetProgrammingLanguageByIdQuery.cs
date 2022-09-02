using Application.Services.Repositories;

namespace Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguageById;
public class GetProgrammingLanguageByIdQuery : IRequest<GetProgrammingLanguageByIdDto>
{
    public int Id { get; set; }


    public class GetProgrammingLanguageByIdQueryHandler : IRequestHandler<GetProgrammingLanguageByIdQuery, GetProgrammingLanguageByIdDto>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageByIdQueryHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<GetProgrammingLanguageByIdDto> Handle(GetProgrammingLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageRepository.GetAsync(pl => pl.Id == request.Id);
            return _mapper.Map<GetProgrammingLanguageByIdDto>(programmingLanguage);
        }
    }
}
