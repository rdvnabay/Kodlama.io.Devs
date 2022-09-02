using Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguageById;
using Application.Features.ProgrammingLanguages.Queries.GetProgrammingLanguages;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProgrammingLanguagesController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
        => Ok(await Mediator.Send(new GetProgrammingLanguagesQuery { PageRequest = pageRequest }));

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
        => Ok(await Mediator.Send(new GetProgrammingLanguageByIdQuery { Id = id }));
}
