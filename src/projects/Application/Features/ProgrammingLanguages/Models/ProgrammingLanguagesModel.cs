using Application.Features.ProgrammingLanguages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Models;
public class ProgrammingLanguagesModel:BasePageableModel
{
    public List<ProgrammingLanguagesDto> Items { get; set; }
}
