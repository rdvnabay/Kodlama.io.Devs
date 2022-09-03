using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguages;
public class GetProgrammingLanguagesModel : BasePageableModel
{
    public List<GetProgrammingLanguagesDto> Items { get; set; }
}
