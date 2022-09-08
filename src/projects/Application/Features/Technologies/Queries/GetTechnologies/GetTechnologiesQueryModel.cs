using Core.Persistence.Paging;
namespace Application.Features.Technologies.Queries.GetTechnologies;

public class GetTechnologiesQueryModel : BasePageableModel
{
    public List<GetTechnologiesQueryDto> Items { get; set; }
}
