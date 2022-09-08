using Application.Services.Repositories;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Technologies.Queries.GetTechnologies;

public class GetTechnologiesQuery : IRequest<GetTechnologiesQueryModel>
{
    public PageRequest PageRequest { get; set; }


    public class GetTechnologiesQueryHandler : IRequestHandler<GetTechnologiesQuery, GetTechnologiesQueryModel>
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly IMapper _mapper;

        public GetTechnologiesQueryHandler(ITechnologyRepository technologyRepository, IMapper mapper)
        {
            _technologyRepository = technologyRepository;
            _mapper = mapper;
        }

        public async Task<GetTechnologiesQueryModel> Handle(GetTechnologiesQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Technology> technologies = await _technologyRepository.GetListAsync(
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize,
                include: t => t
                .Include(t => t.ProgrammingLanguage));

            return _mapper.Map<GetTechnologiesQueryModel>(technologies);
        }
    }
}
