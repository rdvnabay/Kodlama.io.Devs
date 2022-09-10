using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Commands.DeleteTechnology;
using Application.Features.Technologies.Commands.UpdateTechnology;
using Application.Features.Technologies.Queries.GetTechnologies;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TechnologiesController : BaseController
{

    [HttpGet]
    public async Task<IActionResult> CreateAsync([FromQuery] PageRequest pageRequest)
        => Ok(await Mediator.Send(new GetTechnologiesQuery { PageRequest = pageRequest }));

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateTechnologyCommand technology)
        => Ok(await Mediator.Send(technology));

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] UpdateTechnologyCommand technology)
       => Ok(await Mediator.Send(technology));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] int id)
      => Ok(await Mediator.Send(new DeleteTechnologyCommand { Id = id }));
}
