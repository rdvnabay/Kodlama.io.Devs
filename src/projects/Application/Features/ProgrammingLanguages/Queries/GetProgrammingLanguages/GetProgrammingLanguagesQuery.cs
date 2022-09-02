using Application.Features.ProgrammingLanguages.Models;
using Application.Services.Repositories;
using Core.Application.Requests;

namespace Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguages;
public class GetProgrammingLanguagesQuery : IRequest<ProgrammingLanguagesModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetProgrammingLanguagesQueryHandler : IRequestHandler<GetProgrammingLanguagesQuery, ProgrammingLanguagesModel>
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
        private readonly IMapper _mapper;

        public GetProgrammingLanguagesQueryHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
            _mapper = mapper;
        }

        public async Task<ProgrammingLanguagesModel> Handle(GetProgrammingLanguagesQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguages = await _programmingLanguageRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
            return _mapper.Map<ProgrammingLanguagesModel>(programmingLanguages);
        }
    }
}
