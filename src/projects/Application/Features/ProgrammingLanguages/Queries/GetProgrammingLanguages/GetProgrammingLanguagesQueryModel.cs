using Core.Persistence.Paging;
namespace Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguages;

public class GetProgrammingLanguagesQueryModel : BasePageableModel
{
    public List<GetProgrammingLanguagesQueryDto> Items { get; set; }
}
